using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct OLESTREAMVTBL
    {
        /// _OLESTREAMVTBL_Get
        public _OLESTREAMVTBL_Get AnonymousMember1;

        /// _OLESTREAMVTBL_Put
        public _OLESTREAMVTBL_Put AnonymousMember2;
    }
}