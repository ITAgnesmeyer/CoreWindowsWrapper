using CoreWindowsWrapper;

namespace ConsleCaller
{
    public class Window2 : NativeWindow
    {
        private NativeWebBrowser _WebBrowser;

        //public Window2(NativeWindow parent) : base(parent)
        //{

        //}
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
            this._WebBrowser = new NativeWebBrowser();
            this._WebBrowser.Location = new CoreWindowsWrapper.Api.Win32.Point(100,100);
            this._WebBrowser.Width = 200;
            this._WebBrowser.Height = 200;
            
            this.Controls.Add(this._WebBrowser);
           
           
        }

        private void Window2_Create(object sender, CreateEventArgs e)
        {
            
        }

        private void Window2_DblClick(object sender, MouseClickEventArgs e)
        {
            MessageBox.Show("BrowserID:" + this._WebBrowser.Handle.ToInt32());
            this.Close();
        }

        private void Window2_Click(object sender, MouseClickEventArgs e)
        {
            
        }
    }
}