using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct OLESTREAM
    {
        /// LPOLESTREAMVTBL->OLESTREAMVTBL*
        public IntPtr lpstbl;
    }
}