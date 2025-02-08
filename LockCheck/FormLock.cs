using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace LockCheck
{
    public partial class FormLockCheck : Form
    {   /// <summary>
        /// Идентификатор хука клавиатуры
        /// </summary>
        private IntPtr _hookID = IntPtr.Zero;
        /// <summary>
        /// Делегат для обработки низкоуровневых событий клавиатуры
        /// </summary>
        private LowLevelKeyboardProc _keyboardProc;
        /// <summary>
        /// Код хука для клавиатуры
        /// </summary>
        private const int WhKeyboard = 13;
        /// <summary>
        /// Код клавиши CapsLock
        /// </summary>
        private const int VkCapsLock = 0x14;
        /// <summary>
        /// Код клавиши NumLock
        /// </summary>
        private const int VkNumLock = 0x90;
        /// <summary>
        /// Код клавиши ScrollLock
        /// </summary>
        private const int VkScrollLock = 0x91;
        /// <summary>
        /// Сообщение о нажатии клавиши
        /// </summary>
        private const int WmKeyDown = 0x0100;
        /// <summary>
        /// Сообщение об отпускании клавиши
        /// </summary>
        private const int WmKeyUp = 0x0101;
        /// <summary>
        /// Делегат для обработки низкоуровневых событий клавиатуры.
        /// </summary>
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        public FormLockCheck()
        {
            InitializeComponent();
            _keyboardProc = HookCallback;
            _hookID = SetHook(_keyboardProc);
            UpdateIcons(); 
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll")]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll")]
        private static extern short GetKeyState(int nVirtKey);

        /// <summary>
        /// Устанавливает хук для перехвата нажатий клавиш
        /// </summary>
        private IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())

            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WhKeyboard, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        /// <summary>
        /// Обработчик хука для клавиатуры, вызывается при нажатии или отпускании клавиш
        /// </summary>
        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && (wParam == (IntPtr)WmKeyDown || wParam == (IntPtr)WmKeyUp))
            {
                UpdateIcons();
            }

            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        /// <summary>
        /// Обновляет иконки в зависимости от состояния клавиш CapsLock, NumLock и ScrollLock
        /// </summary>
        private void UpdateIcons()
        {
            if ((GetKeyState(VkCapsLock) & 0x0001) != 0)
            {
                labelInputCaps.Text = "1";
                notifyIconCapsLock.Icon = LockCheck.Properties.Resources.CapsOn;
            }
            else
            {
                labelInputCaps.Text = "0";
                notifyIconCapsLock.Icon = LockCheck.Properties.Resources.CapsOff;
            }

            if ((GetKeyState(VkNumLock) & 0x0001) == 0)
            {
                labelInputNum.Text = "1";
                notifyIconNumLock.Icon = LockCheck.Properties.Resources.NumOn;
            }
            else
            {
                labelInputNum.Text = "0";
                notifyIconNumLock.Icon = LockCheck.Properties.Resources.NumOff;
            }

            if ((GetKeyState(VkScrollLock) & 0x0001) != 0)
            {
                labelInputScrolll.Text = "1";
            }
            else
            {
                labelInputScrolll.Text = "0";
            }
        }

        /// <summary>
        /// Обработчик события закрытия формы. Отменяет хук при закрытии приложения
        /// </summary>
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            UnhookWindowsHookEx(_hookID);
            base.OnFormClosed(e);
        }

        /// <summary>
        /// Минимизирует окно приложения
        /// </summary>
        private void MinimizeWindow()
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Обработчик клика на иконке трея. Минимизирует окно при клике
        /// </summary>
        private void labelTray_Click(object sender, EventArgs e)
        {
            MinimizeWindow();
        }

        /// <summary>
        /// Обработчик события деактивации формы. При сворачивании в трей иконки становятся видимыми
        /// </summary>
        private void FormLockCheck_Deactivate(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                notifyIconCapsLock.Visible = true;
                notifyIconNumLock.Visible = true; 
            }
        }

        /// <summary>
        /// Обработчик клика по иконке CapsLock в трее. Восстанавливает форму при клике
        /// </summary>
        private void NotifyIconCapsLock_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
                ShowInTaskbar = true;
                sender.GetType().GetProperty("Visible").SetValue(sender, true);
            }
        }

        /// <summary>
        /// Обработчик события загрузки формы. Минимизирует окно и скрывает иконки в трее
        /// </summary>
        private void FormLockCheck_Load(object sender, EventArgs e)
        {
            MinimizeWindow();
            FormLockCheck_Deactivate(sender, e);
        }

        /// <summary>
        /// Обработчик клика на кнопку "Выход". Закрывает приложение
        /// </summary>
        private void LabelExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выйти?", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Обработчик движения мыши по форме. Позволяет перетаскивать форму
        /// </summary>
        private void FormLockCheck_MouseMove(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m); 
        }
    }
}
