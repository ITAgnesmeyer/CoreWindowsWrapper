using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagOLEVERB
    {
        /// LONG->int
        public int lVerb;

        /// LPOLESTR->OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszVerbName;

        /// DWORD->unsigned int
        public uint fuFlags;

        /// DWORD->unsigned int
        public uint grfAttribs;
    }
}