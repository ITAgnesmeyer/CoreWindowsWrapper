using System;

namespace CoreWindowsWrapper
{
    [Flags]
    public enum MessageBoxOptions : uint
    {
        OkOnly = 0x000000,
        OkCancel = 0x000001,
        AbortRetryIgnore = 0x000002,
        YesNoCancel = 0x000003,
        YesNo = 0x000004,
        RetryCancel = 0x000005,
        CancelTryContinue = 0x000006,
        IconHand = 0x000010,
        IconQuestion = 0x000020,
        IconExclamation = 0x000030,
        IconAsterisk = 0x000040,
        UserIcon = 0x000080,
        IconWarning = IconExclamation,
        IconError = IconHand,
        IconInformation = IconAsterisk,
        IconStop = IconHand,
        DefButton1 = 0x000000,
        DefButton2 = 0x000100,
        DefButton3 = 0x000200,
        DefButton4 = 0x000300,
        ApplicationModal = 0x000000,
        SystemModal = 0x001000,
        TaskModal = 0x002000,
        Help = 0x004000,
        NoFocus = 0x008000,
        SetForeground = 0x010000,
        DefaultDesktopOnly = 0x020000,
        Topmost = 0x040000,
        Right = 0x080000,
        RtlReading = 0x100000
    }
}