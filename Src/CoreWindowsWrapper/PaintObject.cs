using System;
using Diga.Core.Api.Win32;

namespace CoreWindowsWrapper
{
    public class PaintObject
    {
        private PaintStruct _PaintStruct;

        internal PaintObject(PaintStruct ps)
        {
            this._PaintStruct = ps;
            
        }

        public IntPtr Hdc => this._PaintStruct.hdc;

        public bool Erase
        {
            get => this._PaintStruct.fErase;
            set => this._PaintStruct.fErase = value;
        }

        public Rect RcPaint => this._PaintStruct.GetRcPaint();
    }
}