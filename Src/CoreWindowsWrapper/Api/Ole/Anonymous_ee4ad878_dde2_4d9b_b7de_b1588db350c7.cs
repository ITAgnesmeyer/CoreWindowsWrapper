using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_ee4ad878_dde2_4d9b_b7de_b1588db350c7
    {
        /// WCHAR->wchar_t->unsigned short
        [FieldOffset(0)]
        public ushort UnicodeChar;

        /// CHAR->char
        [FieldOffset(0)]
        public byte AsciiChar;
    }
}