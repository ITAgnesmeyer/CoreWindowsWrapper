using Diga.Core.Api.Win32;
using System;

namespace CoreWindowsWrapper
{
    public class NativeKeyEventArgs : EventArgs
    {
        public int VirtalKey { get; }
        public int ScanCode { get; }
        public bool ScanCodeE0 { get; }
        public bool IsUp { get; }
        public bool IsRepeat { get; }
        public int RepeatCount { get; }
        public bool IsAlt { get; }
        public bool IsDlgMode { get; }
        public bool IsMenuMode { get; }
        internal NativeKeyEventArgs(IntPtr wParam, IntPtr lParam)
        {
            var wParamHiLow = Win32Api.MakeHiLo(wParam);

            var vkKey = wParamHiLow.iLow;
            this.VirtalKey = vkKey;

            var lParamHiLow = Win32Api.MakeHiLo(lParam);

            var hiWord = (ushort)lParamHiLow.iHigh;
            var loWord = (ushort)lParamHiLow.iLow;

            byte scanCode = Win32Api.LoByte((ushort)hiWord);
            ApiBool scanCodeE0 = (hiWord & 0x0100) == 0x0100;
            ApiBool upFlag = (hiWord & 0x8000) == 0x8000;
            ApiBool repeatFlag = (hiWord & 0x4000) == 0x4000;
            ushort repeatCount = (ushort)loWord;
            ApiBool altDownFalg = (hiWord & 0x2000) == 0x2000;
            ApiBool dlgModeFalg = (hiWord & 0x0800) == 0x0800;
            ApiBool menuModeFlag = (hiWord & 0x1000) == 0x1000;
            this.ScanCode = scanCode;
            this.ScanCodeE0 = scanCodeE0;
            this.IsUp = upFlag;
            this.IsRepeat = repeatFlag;
            this.RepeatCount = repeatCount;
            this.IsAlt = altDownFalg;
            this.IsDlgMode = dlgModeFalg;
            this.IsMenuMode = menuModeFlag;



        }
    }
}