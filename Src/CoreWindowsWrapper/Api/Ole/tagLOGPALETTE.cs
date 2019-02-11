using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagLOGPALETTE
    {
        /// WORD->unsigned short
        public ushort palVersion;

        /// WORD->unsigned short
        public ushort palNumEntries;

        /// PALETTEENTRY[1]
        [MarshalAs(UnmanagedType.ByValArray,
            SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public tagPALETTEENTRY[] palPalEntry;
    }
}