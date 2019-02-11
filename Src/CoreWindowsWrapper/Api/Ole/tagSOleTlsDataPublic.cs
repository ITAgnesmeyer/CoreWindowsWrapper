using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagSOleTlsDataPublic
    {
        /// void*[2]
        [MarshalAs(UnmanagedType.ByValArray,
            SizeConst = 2, ArraySubType = UnmanagedType.SysUInt)]
        public IntPtr[] pvReserved0;

        /// DWORD[3]
        [MarshalAs(UnmanagedType.ByValArray,
            SizeConst = 3, ArraySubType = UnmanagedType.U4)]
        public uint[] dwReserved0;

        /// void*[1]
        [MarshalAs(UnmanagedType.ByValArray,
            SizeConst = 1, ArraySubType = UnmanagedType.SysUInt)]
        public IntPtr[] pvReserved1;

        /// DWORD[3]
        [MarshalAs(UnmanagedType.ByValArray,
            SizeConst = 3, ArraySubType = UnmanagedType.U4)]
        public uint[] dwReserved1;

        /// void*[4]
        [MarshalAs(UnmanagedType.ByValArray,
            SizeConst = 4, ArraySubType = UnmanagedType.SysUInt)]
        public IntPtr[] pvReserved2;

        /// DWORD[1]
        [MarshalAs(UnmanagedType.ByValArray,
            SizeConst = 1, ArraySubType = UnmanagedType.U4)]
        public uint[] dwReserved2;

        /// void*
        public IntPtr pCurrentCtx;
    }
}