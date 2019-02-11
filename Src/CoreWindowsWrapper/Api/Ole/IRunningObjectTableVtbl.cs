using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IRunningObjectTableVtbl
    {
        /// IRunningObjectTableVtbl_QueryInterface
        public IRunningObjectTableVtbl_QueryInterface AnonymousMember1;

        /// IRunningObjectTableVtbl_AddRef
        public IRunningObjectTableVtbl_AddRef AnonymousMember2;

        /// IRunningObjectTableVtbl_Release
        public IRunningObjectTableVtbl_Release AnonymousMember3;

        /// IRunningObjectTableVtbl_Register
        public IRunningObjectTableVtbl_Register AnonymousMember4;

        /// IRunningObjectTableVtbl_Revoke
        public IRunningObjectTableVtbl_Revoke AnonymousMember5;

        /// IRunningObjectTableVtbl_IsRunning
        public IRunningObjectTableVtbl_IsRunning AnonymousMember6;

        /// IRunningObjectTableVtbl_GetObjectW
        public IRunningObjectTableVtbl_GetObjectW AnonymousMember7;

        /// IRunningObjectTableVtbl_NoteChangeTime
        public IRunningObjectTableVtbl_NoteChangeTime AnonymousMember8;

        /// IRunningObjectTableVtbl_GetTimeOfLastChange
        public IRunningObjectTableVtbl_GetTimeOfLastChange AnonymousMember9;

        /// IRunningObjectTableVtbl_EnumRunning
        public IRunningObjectTableVtbl_EnumRunning AnonymousMember10;
    }
}