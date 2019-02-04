using System;
using System.IO;
using CoreWindowsWrapper.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativeBitmap:NativeLabel
    {
        protected override void Initialize()
        {
            base.Initialize();
            this.TypeIdentifier = "static";
            this.Style = WindowStylesConst.WS_VISIBLE | WindowStylesConst.WS_CHILD | StaticControlStyles.SS_BITMAP | StaticControlStyles.SS_NOTIFY;
        }

        public string BitMap{get;set;}

        public void Refresh()
        {
            if(string.IsNullOrEmpty(this.BitMap)) return;
            if(!File.Exists(this.BitMap)) return;
            IntPtr hBmp = Tools.ImageTool.SaveLoadBitmapFromFile(this.BitMap);
            Api.Win32.Win32Api.SendMessage(this.Handle, StaticControlMessages.STM_SETIMAGE, ImageTypeConst.IMAGE_BITMAP, hBmp);

        }

    }
}