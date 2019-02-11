using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IPersistStream
    {
        /// IPersistStreamVtbl*
        public IntPtr lpVtbl;
    }
}