using System.Diagnostics;
using CoreWindowsWrapper;
using Diga.Core.Api.Win32;
using Diga.NativeControls.WebBrowser;
using Diga.WebView2.Wrapper;
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
                Url = "https://vscode.dev",
                IsStatusBarEnabled = true,
                DefaultContextMenusEnabled = false,
                DevToolsEnabled = false,
                EnableMonitoring = false,
                //BrowserExecutableFolder = ".\\edge",
                BrowserUserDataFolder = "C:\\tmp\\diga",
                MonitoringFolder = ".\\wwwroot",
                MonitoringUrl = "http://localhost:1/",
                AutoDock = true
            };
            this._Browser.DocumentTitleChanged += OnDocumentTitleChanged;
            this._Browser.NavigationStart += OnNavigationStart;
            this._Browser.NavigationCompleted += OnNavigationCompleted;
            this._Browser.WebResourceRequested += OnWebResourceRequested;
            this._Browser.AcceleratorKeyPressed += OnAccessorKeyPressed;
            this.Controls.Add(this._Browser);
        }

        private const uint NoneStyle = 385941504;

        private const uint NoneExStyle = 327680;

        private uint OldStyle;
        private uint OldExStyle;
        private void OnAccessorKeyPressed(object sender, AcceleratorKeyPressedEventArgs e)
        {
            uint currentStyle = this.GetWindowStyle();
            uint currentExStyle = this.GetWindowExStyle();
            if (e.KeyVentType == KeyEventType.KeyDown && e.VirtualKey == Diga.Core.Api.Win32.VirtualKeys.VK_F11)
            {
                if (currentStyle == NoneStyle && currentExStyle == NoneExStyle)
                {
                    this.SetWindowState(WindowState.Normal);
                    this.UpdateStyle(this.OldStyle);
                    this.UpdateExStyle(this.OldExStyle);
                    this.UpdateWidow();
                    
                }
                else
                {
                    this.OldStyle = currentStyle;
                    this.OldExStyle = currentExStyle;
                    this.SetWindowState(WindowState.Maximized);
                    this.UpdateStyle(NoneStyle);
                    this.UpdateExStyle(NoneExStyle);
                    this.UpdateWidow();
                    
                }
                //NativeApp.DoEvents();
                
            }
        }

        private void OnWebResourceRequested(object sender, WebResourceRequestedEventArgs e)
        {
            Debug.Print(e.Request.Uri);
        }

        private void OnNavigationCompleted(object sender, NavigationCompletedEventArgs e)
        {
            if (e.IsSuccess)
                this.Text = e.IsSuccess + "->" + this._Browser.DocumentTitle;
            else
                this.Text = "Navigation-Error=>" + e.GetErrorText();
         
        }
        private void OnNavigationStart(object sender, NavigationStartingEventArgs e)
        {
            this.Text = "Start-Navigate" + e.uri;
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