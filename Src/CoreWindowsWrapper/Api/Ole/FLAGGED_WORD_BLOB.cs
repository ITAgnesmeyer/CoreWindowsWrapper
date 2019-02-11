using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FLAGGED_WORD_BLOB
    {
        /// unsigned int
        public uint fFlags;

        /// unsigned int
        public uint clSize;

        /// unsigned short[1]
        [MarshalAs(UnmanagedType.ByValArray,
            SizeConst = 1, ArraySubType = UnmanagedType.U2)]
        public ushort[] asData;
    }
}