using System;

namespace Diga.Core.Api.Win32
{
    [Flags]
    public enum MouseKey : uint
    {
        MK_CONTROL = MouseKeyConst.MK_CONTROL,
        MK_LBUTTON = MouseKeyConst.MK_LBUTTON,
        MK_MBUTTON = MouseKeyConst.MK_MBUTTON,
        MK_RBUTTON = MouseKeyConst.MK_RBUTTON,
        MK_SHIFT = MouseKeyConst.MK_SHIFT,
        MK_XBUTTON1 = MouseKeyConst.MK_XBUTTON1,
        MK_XBUTTON2 = MouseKeyConst.MK_XBUTTON2
    }
}