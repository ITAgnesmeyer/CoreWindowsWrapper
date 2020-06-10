using CoreWindowsWrapper;
using CoreWindowsWrapper.Win32ApiForm;

namespace ConsoleCaller
{
    public class Window4 : NativeWindow
    {
        protected override void InitControls()
        {
            this.Text = "Drawin Surface";
            this.Name = "MainWindow";
            this.MouseMove += Window4_MoseMove;
            
            this.StatusBar = true;
           
            this.Width = 500;
            this.Height = 400;
            this.StartUpPosition = WindowsStartupPosition.CenterScreen;

        }

        private void Window4_MoseMove(object sender, MouseMoveEventArgs e)
        {
            this.Text = "location=>" + e.Point.X + ";" + e.Point.Y;
        }

        protected override void OnPaint( PaintEventArgs e)
        {
            
            base.OnPaint( e);
        }
    }
}