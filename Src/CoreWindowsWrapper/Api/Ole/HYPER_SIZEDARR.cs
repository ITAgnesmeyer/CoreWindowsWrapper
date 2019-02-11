using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct HYPER_SIZEDARR
    {
        /// unsigned int
        public uint clSize;

        /// __int64*
        public IntPtr pData;
    }
}