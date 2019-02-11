using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagFORMATETC
    {
        /// CLIPFORMAT->WORD->unsigned short
        public ushort cfFormat;

        /// DVTARGETDEVICE*
        public IntPtr ptd;

        /// DWORD->unsigned int
        public uint dwAspect;

        /// LONG->int
        public int lindex;

        /// DWORD->unsigned int
        public uint tymed;
    }
}