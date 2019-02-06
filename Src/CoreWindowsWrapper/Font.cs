using System;
using CoreWindowsWrapper.Api.Win32;
namespace CoreWindowsWrapper
{
    public class Font
    {
        private LOGFONTW _LogFont;
        private int? _Size;
        private bool? _Italic;
        private bool? _Bold;

        public Font()
        {
            this._LogFont = Tools.FontTool.GetDefaultLogFont();
        }
        internal Font(LOGFONTW logFont)
        {
            this._LogFont = logFont;

        }

        internal void FormLogFont(LOGFONTW logFon, IntPtr hWnd)
        {
            this._LogFont = logFon;
            this.FromLogFont(hWnd,true);
        }
        internal void FromLogFont(IntPtr hWnd, bool overwrite = false)
        {
            IntPtr hDc = Win32Api.GetDC(hWnd);
            if(overwrite)
            {
                    this.Name = this._LogFont.lfFaceName;
                    this.Italic = Win32Api.ByteToBool(this._LogFont.lfItalic);
                    this.Bold = false;
                    if (this._LogFont.lfWeight == FontWeight.FW_BOLD)
                        this.Bold = true;
                    this.Size = Tools.FontTool.FontHeightToSize(this._LogFont.lfHeight, hDc);

            }
            else
            {
                if (string.IsNullOrEmpty(this.Name))
                    this.Name = this._LogFont.lfFaceName;
            

                if(this._Italic == null)
                    this.Italic = Win32Api.ByteToBool(this._LogFont.lfItalic);
                if(this._Bold == null)
                {
                    this.Bold = false;
                    if (this._LogFont.lfWeight == FontWeight.FW_BOLD)
                        this.Bold = true;

                }
                if(this._Size == null)
                {
                    this.Size = Tools.FontTool.FontHeightToSize(this._LogFont.lfHeight, hDc);
                }

            }
            
            Win32Api.ReleaseDC(hWnd, hDc);

        }

        public string Name { get; set; }

        public int Size { get => _Size.GetValueOrDefault(0); set => _Size = value; }

        public bool Italic { get => _Italic.GetValueOrDefault(false); set => _Italic = value; }

        public bool Bold { get => _Bold.GetValueOrDefault(false); set => _Bold = value; }

        internal LOGFONTW ToLogFont(IntPtr hWnd)
        {
            IntPtr hDc = Win32Api.GetDC(hWnd);
            this._LogFont = new LOGFONTW();
            this._LogFont.lfFaceName = this.Name;
            
            this._LogFont.lfItalic = Win32Api.BoolToByte(this.Italic);

            this._LogFont.lfWeight = FontWeight.FW_NORMAL;
            if(this.Bold == true)
                this._LogFont.lfWeight = FontWeight.FW_BOLD;

            this._LogFont.lfHeight = Tools.FontTool.FontSizeToHeight(this.Size, hDc);

            Win32Api.ReleaseDC(hWnd, hDc);
            return this._LogFont;
        }

    }
}
