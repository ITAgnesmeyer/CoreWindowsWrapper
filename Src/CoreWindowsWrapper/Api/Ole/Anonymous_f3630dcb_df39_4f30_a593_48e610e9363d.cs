using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_f3630dcb_df39_4f30_a593_48e610e9363d
    {
        /// WCHAR->wchar_t->unsigned short
        [FieldOffset(0)]
        public ushort UnicodeChar;

        /// CHAR->char
        [FieldOffset(0)]
        public byte AsciiChar;
    }
}