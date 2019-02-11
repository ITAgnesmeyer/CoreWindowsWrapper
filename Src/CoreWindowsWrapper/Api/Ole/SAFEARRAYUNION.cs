using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SAFEARRAYUNION
    {
        /// ULONG->unsigned int
        public uint sfType;

        /// _wireSAFEARRAY_UNION___MIDL_IOleAutomationTypes_0001
        public _wireSAFEARRAY_UNION___MIDL_IOleAutomationTypes_0001 Union1;
    }
}