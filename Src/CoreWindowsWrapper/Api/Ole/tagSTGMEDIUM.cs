using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagSTGMEDIUM
    {
        /// DWORD->unsigned int
        public uint tymed;

        /// Anonymous_cb8be365_afe0_4064_8361_371c31b61c7a
        public Anonymous_cb8be365_afe0_4064_8361_371c31b61c7a Union1;

        /// IUnknown*
        public IntPtr pUnkForRelease;
    }
}