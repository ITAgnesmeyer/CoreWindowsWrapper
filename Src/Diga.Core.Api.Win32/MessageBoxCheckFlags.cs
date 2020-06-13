// ReSharper disable InconsistentNaming

namespace Diga.Core.Api.Win32
{
    public static class MessageBoxCheckFlags
    {
        public const uint MB_OK = 0x00000000,
            MB_OKCANCEL = 0x00000001,
            MB_YESNO = 0x00000004,
            MB_ICONHAND = 0x00000010,
            MB_ICONQUESTION = 0x00000020,
            MB_ICONEXCLAMATION = 0x00000030,
            MB_ICONINFORMATION = 0x00000040;
    }
}