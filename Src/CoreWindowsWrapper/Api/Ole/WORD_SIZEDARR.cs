using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WORD_SIZEDARR
    {
        /// unsigned int
        public uint clSize;

        /// unsigned short*
        public IntPtr pData;
    }
}