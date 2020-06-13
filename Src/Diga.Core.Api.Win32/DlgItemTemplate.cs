namespace Diga.Core.Api.Win32
{
    public struct DlgItemTemplate
    {
        public uint style;
        public uint dwExtendedStyle;
        public short x;
        public short y;
        public short cx;
        public short cy;
        public ushort id;

        public DlgItemTemplate(uint style, uint dwExtendedStyle, short x, short y, short cx, short cy, ushort id)
        {
            this.style = style;
            this.dwExtendedStyle = dwExtendedStyle;
            this.x = x;
            this.y = y;
            this.cx = cx;
            this.cy = cy;
            this.id = id;
        }
    }
}