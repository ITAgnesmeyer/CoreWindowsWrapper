using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Win32
{
    internal static class ComCtl32
    {
        private const string COMCTL32 = "comctl32.dll";

        [DllImport(COMCTL32, EntryPoint = "InitCommonControlsEx", CallingConvention = CallingConvention.StdCall)]
        public static extern bool InitCommonControlsEx(ref InitCommonControlsEx iccex);

        /// Return Type: void*
        ///cx: int
        ///cy: int
        ///flags: int
        ///cInitial: int
        ///cGrow: int
        [DllImport(COMCTL32, EntryPoint = "ImageList_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ImageList_Create(int cx, int cy, int flags, int cInitial, int cGrow);

        /// Return Type: int
        ///himl: void*
        ///hbmImage: void*
        ///hbmMask: void*
        [DllImport(COMCTL32, EntryPoint = "ImageList_Add", CallingConvention = CallingConvention.StdCall)]
        public static extern int ImageList_Add(IntPtr himl, IntPtr hbmImage, IntPtr hbmMask);

        /// Return Type: int
        ///himl: void*
        [DllImport(COMCTL32, EntryPoint = "ImageList_Destroy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ImageList_Destroy(IntPtr himl);
    }
}