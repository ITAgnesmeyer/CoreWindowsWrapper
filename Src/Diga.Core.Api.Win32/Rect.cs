using System.Runtime.InteropServices;

namespace Diga.Core.Api.Win32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Rect
    {
        public int Left, Top, Right, Bottom;

        public Rect(int left, int top, int right, int bottom)
        {
            this.Left = left;
            this.Top = top;
            this.Right = right;
            this.Bottom = bottom;
        }

        public Rect(System.Drawing.Rectangle r) : this(r.Left, r.Top, r.Right, r.Bottom)
        {
        }

        public int X
        {
            get { return this.Left; }
            set
            {
                this.Right -= (this.Left - value);
                this.Left = value;
            }
        }

        public int Y
        {
            get { return this.Top; }
            set
            {
                this.Bottom -= (this.Top - value);
                this.Top = value;
            }
        }

        public int Height
        {
            get { return this.Bottom - this.Top; }
            set { this.Bottom = value + this.Top; }
        }

        public int Width
        {
            get { return this.Right - this.Left; }
            set { this.Right = value + this.Left; }
        }

        public System.Drawing.Point Location
        {
            get { return new System.Drawing.Point(this.Left, this.Top); }
            set
            {
                this.X = value.X;
                this.Y = value.Y;
            }
        }

        public System.Drawing.Size Size
        {
            get { return new System.Drawing.Size(this.Width, this.Height); }
            set
            {
                this.Width = value.Width;
                this.Height = value.Height;
            }
        }

        public static implicit operator System.Drawing.Rectangle(Rect r)
        {
            return new System.Drawing.Rectangle(r.Left, r.Top, r.Width, r.Height);
        }

        public static implicit operator Rect(System.Drawing.Rectangle r)
        {
            return new Rect(r);
        }

        public static bool operator ==(Rect r1, Rect r2)
        {
            return r1.Equals(r2);
        }

        public static bool operator !=(Rect r1, Rect r2)
        {
            return !r1.Equals(r2);
        }

        public bool Equals(Rect r)
        {
            return r.Left == this.Left && r.Top == this.Top && r.Right == this.Right && r.Bottom == this.Bottom;
        }

        public override bool Equals(object obj)
        {
            if (obj is Rect)
                return Equals((Rect) obj);
            else if (obj is System.Drawing.Rectangle)
                return Equals(new Rect((System.Drawing.Rectangle) obj));
            return false;
        }

        public override int GetHashCode()
        {
            return ((System.Drawing.Rectangle) this).GetHashCode();
        }

        public override string ToString()
        {
            return string.Format(System.Globalization.CultureInfo.CurrentCulture,
                "{{Left={0},Top={1},Right={2},Bottom={3}}}", this.Left, this.Top, this.Right, this.Bottom);
        }
    }
}