using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IAdviseSinkVtbl
    {
        /// IAdviseSinkVtbl_QueryInterface
        public IAdviseSinkVtbl_QueryInterface AnonymousMember1;

        /// IAdviseSinkVtbl_AddRef
        public IAdviseSinkVtbl_AddRef AnonymousMember2;

        /// IAdviseSinkVtbl_Release
        public IAdviseSinkVtbl_Release AnonymousMember3;

        /// IAdviseSinkVtbl_OnDataChange
        public IAdviseSinkVtbl_OnDataChange AnonymousMember4;

        /// IAdviseSinkVtbl_OnViewChange
        public IAdviseSinkVtbl_OnViewChange AnonymousMember5;

        /// IAdviseSinkVtbl_OnRename
        public IAdviseSinkVtbl_OnRename AnonymousMember6;

        /// IAdviseSinkVtbl_OnSave
        public IAdviseSinkVtbl_OnSave AnonymousMember7;

        /// IAdviseSinkVtbl_OnClose
        public IAdviseSinkVtbl_OnClose AnonymousMember8;
    }
}