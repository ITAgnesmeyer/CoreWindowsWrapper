using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IUnknown
    {
        /// IUnknownVtbl*
        public IntPtr lpVtbl;
    }

    //public interface IUnknown
    //{
    //    int QueryInterface(object This, GUID riid, object ppvObject[] );

    //}
}