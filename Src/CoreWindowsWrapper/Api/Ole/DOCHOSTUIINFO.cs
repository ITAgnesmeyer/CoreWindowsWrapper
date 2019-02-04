using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [ComVisible(true)]
    [StructLayout(LayoutKind.Sequential)]
    public class DOCHOSTUIINFO
    {
        [MarshalAs(UnmanagedType.U4)]
        public int cbSize = Marshal.SizeOf(typeof(DOCHOSTUIINFO));
        [MarshalAs(UnmanagedType.I4)]
        public int dwFlags;
        [MarshalAs(UnmanagedType.I4)]
        public int dwDoubleClick;
        [MarshalAs(UnmanagedType.I4)]
        public int dwReserved1;
        [MarshalAs(UnmanagedType.I4)]
        public int dwReserved2;
    }

}
