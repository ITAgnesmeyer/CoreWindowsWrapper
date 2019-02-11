using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagSTATDATA
    {
        /// FORMATETC->tagFORMATETC
        public tagFORMATETC formatetc;

        /// DWORD->unsigned int
        public uint advf;

        /// IAdviseSink*
        public IntPtr pAdvSink;

        /// DWORD->unsigned int
        public uint dwConnection;
    }
}