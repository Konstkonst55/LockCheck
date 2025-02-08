
namespace LockCheck
{
    partial class FormLockCheck
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLockCheck));
            this.labelExit = new System.Windows.Forms.Label();
            this.labelTray = new System.Windows.Forms.Label();
            this.notifyIconCapsLock = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconNumLock = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelInputScrolll = new System.Windows.Forms.Label();
            this.labelTextScroll = new System.Windows.Forms.Label();
            this.labelInputNum = new System.Windows.Forms.Label();
            this.labelInputCaps = new System.Windows.Forms.Label();
            this.labelTextNum = new System.Windows.Forms.Label();
            this.labelTextCaps = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelExit
            // 
            this.labelExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.ForeColor = System.Drawing.Color.LightSalmon;
            this.labelExit.Location = new System.Drawing.Point(288, 0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(33, 33);
            this.labelExit.TabIndex = 0;
            this.labelExit.Text = "❌";
            this.labelExit.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelExit.Click += new System.EventHandler(this.LabelExit_Click);
            // 
            // labelTray
            // 
            this.labelTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTray.ForeColor = System.Drawing.Color.Cyan;
            this.labelTray.Location = new System.Drawing.Point(263, -4);
            this.labelTray.Name = "labelTray";
            this.labelTray.Size = new System.Drawing.Size(31, 33);
            this.labelTray.TabIndex = 1;
            this.labelTray.Text = "_";
            this.labelTray.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelTray.Click += new System.EventHandler(this.labelTray_Click);
            // 
            // notifyIconCapsLock
            // 
            this.notifyIconCapsLock.Text = "CapsLock";
            this.notifyIconCapsLock.Click += new System.EventHandler(this.NotifyIconCapsLock_Click);
            // 
            // notifyIconNumLock
            // 
            this.notifyIconNumLock.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconNumLock.BalloonTipText = "биба боба";
            this.notifyIconNumLock.Text = "NumLock";
            this.notifyIconNumLock.Click += new System.EventHandler(this.NotifyIconCapsLock_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.labelInputScrolll);
            this.panelMenu.Controls.Add(this.labelTextScroll);
            this.panelMenu.Controls.Add(this.labelInputNum);
            this.panelMenu.Controls.Add(this.labelInputCaps);
            this.panelMenu.Controls.Add(this.labelTextNum);
            this.panelMenu.Controls.Add(this.labelTextCaps);
            this.panelMenu.Location = new System.Drawing.Point(0, 39);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(327, 152);
            this.panelMenu.TabIndex = 2;
            // 
            // labelInputScrolll
            // 
            this.labelInputScrolll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelInputScrolll.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputScrolll.ForeColor = System.Drawing.SystemColors.Window;
            this.labelInputScrolll.Location = new System.Drawing.Point(218, 103);
            this.labelInputScrolll.Name = "labelInputScrolll";
            this.labelInputScrolll.Size = new System.Drawing.Size(97, 27);
            this.labelInputScrolll.TabIndex = 5;
            this.labelInputScrolll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTextScroll
            // 
            this.labelTextScroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTextScroll.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextScroll.ForeColor = System.Drawing.SystemColors.Window;
            this.labelTextScroll.Location = new System.Drawing.Point(12, 103);
            this.labelTextScroll.Name = "labelTextScroll";
            this.labelTextScroll.Size = new System.Drawing.Size(138, 27);
            this.labelTextScroll.TabIndex = 4;
            this.labelTextScroll.Text = "ScrollLock";
            this.labelTextScroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInputNum
            // 
            this.labelInputNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelInputNum.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputNum.ForeColor = System.Drawing.SystemColors.Window;
            this.labelInputNum.Location = new System.Drawing.Point(218, 67);
            this.labelInputNum.Name = "labelInputNum";
            this.labelInputNum.Size = new System.Drawing.Size(97, 27);
            this.labelInputNum.TabIndex = 3;
            this.labelInputNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelInputCaps
            // 
            this.labelInputCaps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelInputCaps.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputCaps.ForeColor = System.Drawing.SystemColors.Window;
            this.labelInputCaps.Location = new System.Drawing.Point(218, 29);
            this.labelInputCaps.Name = "labelInputCaps";
            this.labelInputCaps.Size = new System.Drawing.Size(97, 27);
            this.labelInputCaps.TabIndex = 2;
            this.labelInputCaps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTextNum
            // 
            this.labelTextNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTextNum.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextNum.ForeColor = System.Drawing.SystemColors.Window;
            this.labelTextNum.Location = new System.Drawing.Point(12, 67);
            this.labelTextNum.Name = "labelTextNum";
            this.labelTextNum.Size = new System.Drawing.Size(138, 27);
            this.labelTextNum.TabIndex = 1;
            this.labelTextNum.Text = "NumLock";
            this.labelTextNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTextCaps
            // 
            this.labelTextCaps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTextCaps.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextCaps.ForeColor = System.Drawing.SystemColors.Window;
            this.labelTextCaps.Location = new System.Drawing.Point(12, 29);
            this.labelTextCaps.Name = "labelTextCaps";
            this.labelTextCaps.Size = new System.Drawing.Size(138, 27);
            this.labelTextCaps.TabIndex = 0;
            this.labelTextCaps.Text = "CapsLock";
            this.labelTextCaps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormLockCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(327, 191);
            this.Controls.Add(this.labelTray);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLockCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lock";
            this.Deactivate += new System.EventHandler(this.FormLockCheck_Deactivate);
            this.Load += new System.EventHandler(this.FormLockCheck_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormLockCheck_MouseMove);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelTray;
        private System.Windows.Forms.NotifyIcon notifyIconCapsLock;
        private System.Windows.Forms.NotifyIcon notifyIconNumLock;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelTextCaps;
        private System.Windows.Forms.Label labelTextNum;
        private System.Windows.Forms.Label labelInputNum;
        private System.Windows.Forms.Label labelInputCaps;
        private System.Windows.Forms.Label labelInputScrolll;
        private System.Windows.Forms.Label labelTextScroll;
    }
}

