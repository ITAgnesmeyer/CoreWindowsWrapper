using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Win32
{
    internal static class ComDlg32
    {
        private const string COMDLG32 = "comdlg32.dll";
        private const CharSet CHARSET = CharSet.Auto;
        /// Return Type: BOOL->int
        ///param0: LPOPENFILENAMEW->tagOFNW*
        [DllImport(COMDLG32, EntryPoint = "GetOpenFileName", CharSet = CHARSET)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetOpenFileName(ref OFNW param0);

        /// Return Type: BOOL->int
        ///param0: LPOPENFILENAMEW->tagOFNW*
        [DllImport(COMDLG32, EntryPoint = "GetSaveFileName", CharSet = CHARSET)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetSaveFileName(ref OFNW param0);
    }
}