using System.Diagnostics;
using CoreWindowsWrapper;
using Diga.Core.Api.Win32;
using Diga.NativeControls.WebBrowser;
using Diga.WebView2.Wrapper.EventArguments;

namespace ConsoleCaller
{
    class BrowserWindow : NativeWindow
    {
        private NativeWebBrowser _Browser;
        protected override void InitControls()
        {
            base.InitControls();
            this.Text = "WebBrowser";
            this.Name = "BrowserWindow";
            this.StatusBar = true;
            this.IconFile = "Browser.ico";
            this.Width = 600;
            this.Height = 400;
            this.StatusBar = true;
            this.StartUpPosition = WindowsStartupPosition.CenterScreen;
            
            this._Browser = new NativeWebBrowser()
            {
                Width = this.Width,
                Height = this.Height,
                Url = "http://localhost:1",
                IsStatusBarEnabled = true,
                DefaultContextMenusEnabled = false,
                DevToolsEnabled = false,
                EnableMonitoring = true,
                //BrowserExecutableFolder = ".\\edge",
                BrowserUserDataFolder = "C:\\tmp\\diga",
                MonitoringFolder = ".\\wwwroot",
                MonitoringUrl = "http://localhost:1/",
                AutoDock = true
            };
            this._Browser.DocumentTitleChanged += OnDocumentTitleChanged;
            this._Browser.NavigationStart += OnNavigationStart;
            this._Browser.NavigationCompleted += OnNaviationCompleted;
            this._Browser.WebResourceRequested += OnWebResourceRequested;
            this.Controls.Add(this._Browser);
        }
        
        private void OnWebResourceRequested(object sender, WebResourceRequestedEventArgs e)
        {
            Debug.Print(e.Request.Uri);
        }

        private void OnNaviationCompleted(object sender, NavigationCompletedEventArgs e)
        {
            if (e.IsSuccess)
                this.Text = e.IsSuccess + "->" + this._Browser.DocumentTitle;
            else
                this.Text = "Navigation-Error=>" + e.GetErrorText();
         
        }
        private void OnNavigationStart(object sender, NavigationStartingEventArgs e)
        {
            this.Text = "Start-Navigate" + e.Uri;
        }
        private void OnDocumentTitleChanged(object sender, WebView2EventArgs e)
        {
            this.Text = this._Browser.DocumentTitle;
        }
        
        //protected override void OnSize(SizeEventArgs e)
        //{
        //    if (e.Width == 0) return;
        //    base.OnSize(e);
        //    //Rect rect = this.GetClientRect();
        //    //this.Left = rect.Left;
        //    //this.Top = rect.Top;
        //    //this.Height = rect.Height;
        //    //this.Width = rect.Width;
        //    //this._Browser.DoDock();
        //}
    }
}