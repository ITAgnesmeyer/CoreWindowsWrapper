using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagRPCOLEMESSAGE
    {
        /// void*
        public IntPtr reserved1;

        /// RPCOLEDATAREP->unsigned int
        public uint dataRepresentation;

        /// void*
        public IntPtr Buffer;

        /// ULONG->unsigned int
        public uint cbBuffer;

        /// ULONG->unsigned int
        public uint iMethod;

        /// void*[5]
        [MarshalAs(UnmanagedType.ByValArray,
            SizeConst = 5, ArraySubType = UnmanagedType.SysUInt)]
        public IntPtr[] reserved2;

        /// ULONG->unsigned int
        public uint rpcFlags;
    }
}