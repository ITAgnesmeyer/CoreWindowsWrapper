using System;

namespace CoreWindowsWrapper
{
    [Flags]
    public enum AnchorType
    {
        Top = 0x01,
        Bottom = 0x02,
        Left = 0x04,
        Right = 0x08,
        None = 0,
    }
}