using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Win32
{
    internal static class ComDlg32
    {
        /// Return Type: BOOL->int
        ///param0: LPOPENFILENAMEW->tagOFNW*
        [DllImport("comdlg32.dll", EntryPoint = "GetOpenFileNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetOpenFileName(ref OFNW param0);

        /// Return Type: BOOL->int
        ///param0: LPOPENFILENAMEW->tagOFNW*
        [DllImport("comdlg32.dll", EntryPoint = "GetSaveFileNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetSaveFileName(ref OFNW param0);
    }
}