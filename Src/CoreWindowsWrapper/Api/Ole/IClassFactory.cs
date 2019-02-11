using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IClassFactory
    {
        /// IClassFactoryVtbl*
        public IntPtr lpVtbl;
    }
}