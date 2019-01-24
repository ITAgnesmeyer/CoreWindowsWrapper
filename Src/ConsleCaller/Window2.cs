using CoreWindowsWrapper;
using CoreWindowsWrapper.Win32ApiForm;

namespace ConsleCaller
{
    public class Window2 : NativeWindow
    {
        protected override void InitControls()
        {
            this.Text = "Dies ist ein 2. Fenster";
            this.Name = "Window2";
            this.Left = 100;
            this.Top = 100;
            this.Width = 600;
            this.Height = 400;
            this.BackColor = CoreWindowsWrapper.Tools.ColorTool.LightGray;
            this.Click += Window2_Click;
            this.DoubleClick += Window2_DblClick;
            this.Create += Window2_Create;
        }

        private void Window2_Create(object sender, CreateEventArgs e)
        {
            
        }

        private void Window2_DblClick(object sender, MouseClickEventArgs e)
        {
            this.Close();
        }

        private void Window2_Click(object sender, MouseClickEventArgs e)
        {
            
        }
    }
}