using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DWORD_SIZEDARR
    {
        /// unsigned int
        public uint clSize;

        /// unsigned int*
        public IntPtr pData;
    }
}