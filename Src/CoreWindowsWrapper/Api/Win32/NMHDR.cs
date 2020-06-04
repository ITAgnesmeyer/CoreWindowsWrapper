using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Win32
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public class NmHdr
    {
        public IntPtr hwndFrom;
        public uint idFrom;
        public long code;
    }
}