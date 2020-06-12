using CoreWindowsWrapper;
using CoreWindowsWrapper.Win32ApiForm;
using System.Drawing;

namespace ConsoleCaller
{
    public class Window4 : NativeWindow
    {
        private Point _StartPoint;
        private Point _LastEndPoint;
        private Point _EndPoint;
        private bool _DoDraw;
        protected override void InitControls()
        {
            this.Text = "Drawin Surface";
            this.Name = "MainWindow";
            this.MouseMove += Window4_MoseMove;
            this.MouseDown += Window4_MouseDown;
            this.MouseUp += Window4_MouseUp;

            
            this.StatusBar = true;
           
            this.Width = 500;
            this.Height = 400;
            this.StartUpPosition = WindowsStartupPosition.CenterScreen;

        }

        private void Window4_MouseUp(object sender, MouseClickPositionEventArgs e)
        {
            if (e.Button == MouseButton.Left)
            {
                
                this._EndPoint = e.Point;
                this._DoDraw = false;
                
            }
        }

        private void Window4_MouseDown(object sender, MouseClickPositionEventArgs e)
        {
            if (e.Button == MouseButton.Left)
            {
                this._DoDraw = true;
                this._StartPoint = e.Point;
                
            }
        }

        private void Window4_MoseMove(object sender, MouseMoveEventArgs e)
        {
            this.Text = "location=>" + e.Point.X + ";" + e.Point.Y;
            this._LastEndPoint = this._EndPoint;
            this._EndPoint = e.Point;
            if(this._DoDraw) this.Invalidate();
        }

        protected override void OnPaint( PaintEventArgs e)
        {
            if(!this._DoDraw) return;
            Color c = Color.FromArgb(this.BackColor);
            Color fc = Color.Black;
            
            using (Graphics g = Graphics.FromHdc(e.PaintObject.Hdc))
            {
                
                using (Pen p = new Pen(fc))
                {
                   g.DrawLine(p, this._StartPoint.X,this._StartPoint.Y,this._EndPoint.X, this._EndPoint.Y);
                }
                
            }
            
        }
    }
}