using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagSOLE_AUTHENTICATION_SERVICE
    {
        /// DWORD->unsigned int
        public uint dwAuthnSvc;

        /// DWORD->unsigned int
        public uint dwAuthzSvc;

        /// OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pPrincipalName;

        /// HRESULT->LONG->int
        public int hr;
    }
}