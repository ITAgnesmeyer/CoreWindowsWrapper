using Diga.Core.Api.Win32;
using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper
{
    public class NativeKeyEventArgs : EventArgs
    {
        private const int KF_EXTENDED = 0x0100;
        private const int KF_DLGMODE = 0x0800;
        private const int KF_MENUMODE = 0x1000;
        private const int KF_ALTDOWN = 0x2000;
        private const int KF_REPEAT = 0x4000;
        private const int KF_UP = 0x8000;
        private const uint MAPVK_VK_TO_VSC = 0;
        private const uint MAPVK_VSC_TO_VK = 1;
        private const uint MAPVK_VK_TO_CHAR = 2;
        private const uint MAPVK_VSC_TO_VK_EX = 3;
        private const uint MAPVK_VK_TO_VSC_EX = 4;
        [DllImport("user32.dll", EntryPoint="MapVirtualKeyW")]
        public static extern  uint MapVirtualKeyW(uint uCode, uint uMapType) ;

        public uint Key { get; }
        public int VirtalKey { get; }
        public int ScanCode { get; }
        public bool ScanCodeE0 { get; }
        public bool IsUp { get; }
        public bool IsRepeat { get; }
        public int RepeatCount { get; }
        public bool IsAlt { get; }
        public bool IsDlgMode { get; }
        public bool IsMenuMode { get; }
        public bool Handled { get; set; }
        public IntPtr ResturnCode { get; set; } = IntPtr.Zero;
        internal NativeKeyEventArgs(IntPtr wParam, IntPtr lParam)
        {
            this.Handled = false;
            var wParamHiLow = Win32Api.MakeHiLo(wParam);

            var vkKey = wParamHiLow.iLow;
            this.VirtalKey = vkKey;
            this.Key = Win32Api.GetIntPtrUInt(wParam);
            var lParamHiLow = Win32Api.MakeHiLo(lParam);

            var hiWord = (ushort)lParamHiLow.iHigh;
            var loWord = (ushort)lParamHiLow.iLow;
            
            byte scanCode = Win32Api.LoByte((ushort)hiWord);
            ApiBool scanCodeE0 = (hiWord & KF_EXTENDED) == KF_EXTENDED;
            ApiBool upFlag = (hiWord & KF_UP) == KF_UP;
            ApiBool repeatFlag = (hiWord & KF_REPEAT) == KF_REPEAT;
            ushort repeatCount = (ushort)loWord;
            ApiBool altDownFalg = (hiWord & KF_ALTDOWN) == KF_ALTDOWN;
            ApiBool dlgModeFalg = (hiWord & KF_DLGMODE) == KF_DLGMODE;
            ApiBool menuModeFlag = (hiWord & KF_MENUMODE) == KF_MENUMODE;
            switch ((uint)vkKey)
            {
                case VirtualKeys.VK_SHIFT:
                case VirtualKeys.VK_CONTROL:
                case VirtualKeys.VK_MENU:
                    this.VirtalKey = Win32Api.LoWord(MapVirtualKeyW(scanCode, MAPVK_VSC_TO_VK_EX));
                    break;
            }
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