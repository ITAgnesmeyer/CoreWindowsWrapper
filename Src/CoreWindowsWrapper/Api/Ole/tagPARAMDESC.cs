using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagPARAMDESC
    {
        /// LPPARAMDESCEX->tagPARAMDESCEX*
        public IntPtr pparamdescex;

        /// USHORT->unsigned short
        public ushort wParamFlags;
    }
}