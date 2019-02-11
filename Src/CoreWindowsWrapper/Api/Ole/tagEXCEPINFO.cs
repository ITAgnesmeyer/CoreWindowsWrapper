using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagEXCEPINFO
    {
        /// WORD->unsigned short
        public ushort wCode;

        /// WORD->unsigned short
        public ushort wReserved;

        /// BSTR->OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string bstrSource;

        /// BSTR->OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string bstrDescription;

        /// BSTR->OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string bstrHelpFile;

        /// DWORD->unsigned int
        public uint dwHelpContext;

        /// PVOID->void*
        public IntPtr pvReserved;

        /// tagEXCEPINFO_pfnDeferredFillIn
        public tagEXCEPINFO_pfnDeferredFillIn AnonymousMember1;

        /// SCODE->LONG->int
        public int scode;
    }
}