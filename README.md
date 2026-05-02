# LockCheck

Десктопное приложение для отображения состояния клавиш `CapsLock` и `NumLock` (`ScrollLock` отображается только в открытом приложении)

Иконки отображаются в трее панели задач

## Требования

- Windows 7/8/10/11
- .NET Framework 4.7.2

## Установка

1. Скачайте последнюю версию из [раздела Releases](https://github.com/Konstkonst55/LockCheck/releases)
2. Распакуйте архив в удобное место (например, `C:\Programs\LockCheck\`)
3. Запустите **LockCheck.exe**

## Настройка автозагрузки

### Автоматически (при запуске)

Приложение автоматически добавится в автозагрузку при первом запуске.

### Вручную

Если автозагрузка не сработала, выполните в командной строке (`Win + R` → `cmd`):

```cmd
reg add "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" /v LockCheck /t REG_SZ /d "C:\Programs\LockCheck\LockCheck.exe" /f
```