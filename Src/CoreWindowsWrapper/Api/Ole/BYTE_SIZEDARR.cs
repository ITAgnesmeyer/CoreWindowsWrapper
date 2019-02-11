using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct BYTE_SIZEDARR
    {
        /// unsigned int
        public uint clSize;

        /// byte*
        public IntPtr pData;
    }
}