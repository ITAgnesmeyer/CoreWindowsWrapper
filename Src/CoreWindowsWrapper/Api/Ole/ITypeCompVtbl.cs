using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ITypeCompVtbl
    {
        /// ITypeCompVtbl_QueryInterface
        public ITypeCompVtbl_QueryInterface AnonymousMember1;

        /// ITypeCompVtbl_AddRef
        public ITypeCompVtbl_AddRef AnonymousMember2;

        /// ITypeCompVtbl_Release
        public ITypeCompVtbl_Release AnonymousMember3;

        /// ITypeCompVtbl_Bind
        public ITypeCompVtbl_Bind AnonymousMember4;

        /// ITypeCompVtbl_BindType
        public ITypeCompVtbl_BindType AnonymousMember5;
    }
}