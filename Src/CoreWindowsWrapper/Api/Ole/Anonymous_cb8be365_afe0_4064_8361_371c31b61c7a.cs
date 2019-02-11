using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_cb8be365_afe0_4064_8361_371c31b61c7a
    {
        /// HBITMAP->HBITMAP__*
        [FieldOffset(0)]
        public IntPtr hBitmap;

        /// HMETAFILEPICT->void*
        [FieldOffset(0)]
        public IntPtr hMetaFilePict;

        /// HENHMETAFILE->HENHMETAFILE__*
        [FieldOffset(0)]
        public IntPtr hEnhMetaFile;

        /// HGLOBAL->HANDLE->void*
        [FieldOffset(0)]
        public IntPtr hGlobal;

        /// LPOLESTR->OLECHAR*
        [FieldOffset(0)]
        public IntPtr lpszFileName;

        /// IStream*
        [FieldOffset(0)]
        public IntPtr pstm;

        /// IStorage*
        [FieldOffset(0)]
        public IntPtr pstg;
    }
}