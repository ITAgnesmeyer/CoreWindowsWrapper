using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct KEY_EVENT_RECORD
    {
        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool bKeyDown;

        /// WORD->unsigned short
        public ushort wRepeatCount;

        /// WORD->unsigned short
        public ushort wVirtualKeyCode;

        /// WORD->unsigned short
        public ushort wVirtualScanCode;

        /// Anonymous_ee4ad878_dde2_4d9b_b7de_b1588db350c7
        public Anonymous_ee4ad878_dde2_4d9b_b7de_b1588db350c7 uChar;

        /// DWORD->unsigned int
        public uint dwControlKeyState;
    }
}