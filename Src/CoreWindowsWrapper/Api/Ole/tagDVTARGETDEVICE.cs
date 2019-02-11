using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagDVTARGETDEVICE
    {
        /// DWORD->unsigned int
        public uint tdSize;

        /// WORD->unsigned short
        public ushort tdDriverNameOffset;

        /// WORD->unsigned short
        public ushort tdDeviceNameOffset;

        /// WORD->unsigned short
        public ushort tdPortNameOffset;

        /// WORD->unsigned short
        public ushort tdExtDevmodeOffset;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray,
            SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] tdData;
    }
}