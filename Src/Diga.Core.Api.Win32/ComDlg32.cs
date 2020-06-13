using System.Runtime.InteropServices;

namespace Diga.Core.Api.Win32
{
    public static class ComDlg32
    {
        private const string COMDLG32 = "comdlg32.dll";
        private const CharSet CHARSET = CharSet.Auto;
        /// Return Type: BOOL->int
        ///param0: LPOPENFILENAMEW->tagOFNW*
        [DllImport(COMDLG32, EntryPoint = "GetOpenFileName", CharSet = CHARSET)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetOpenFileName(ref OfNw param0);

        /// Return Type: BOOL->int
        ///param0: LPOPENFILENAMEW->tagOFNW*
        [DllImport(COMDLG32, EntryPoint = "GetSaveFileName", CharSet = CHARSET)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetSaveFileName(ref OfNw param0);
    }
}