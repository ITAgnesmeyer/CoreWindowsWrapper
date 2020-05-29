using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Win32
{
    internal static class ComCtl32
    {
        [DllImport("comctl32.dll", EntryPoint = "InitCommonControlsEx", CallingConvention = CallingConvention.StdCall)]
        public static extern bool InitCommonControlsEx(ref INITCOMMONCONTROLSEX iccex);

        /// Return Type: void*
        ///cx: int
        ///cy: int
        ///flags: int
        ///cInitial: int
        ///cGrow: int
        [DllImport("Comctl32.dll", EntryPoint = "ImageList_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ImageList_Create(int cx, int cy, int flags, int cInitial, int cGrow);

        /// Return Type: int
        ///himl: void*
        ///hbmImage: void*
        ///hbmMask: void*
        [DllImport("Comctl32.dll", EntryPoint = "ImageList_Add", CallingConvention = CallingConvention.StdCall)]
        public static extern int ImageList_Add(IntPtr himl, IntPtr hbmImage, IntPtr hbmMask);

        /// Return Type: int
        ///himl: void*
        [DllImport("Comctl32.dll", EntryPoint = "ImageList_Destroy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ImageList_Destroy(IntPtr himl);
    }
}