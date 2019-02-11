using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagOleMenuGroupWidths
    {
        /// LONG[6]
        [MarshalAs(UnmanagedType.ByValArray,
            SizeConst = 6, ArraySubType = UnmanagedType.I4)]
        public int[] width;
    }
}