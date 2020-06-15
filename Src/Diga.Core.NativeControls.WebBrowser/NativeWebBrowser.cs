using System;
using System.Diagnostics;
using System.IO;
using CoreWindowsWrapper;
using Diga.Core.Api.Win32;

using Diga.WebView2.Wrapper;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Types;
using MimeTypeExtension;

namespace Diga.NativeControls.WebBrowser
{
    public class NativeWebBrowser : NativeControlBase
    {
        private WebView2Control _WebViewControl;
        private string _HtmlContent;
        private bool _DefaultContextMenusEnabled = true;
        private bool _DefaultScriptDialogsEnabled = true;
        private bool _DevToolsEnabled = true;
        private bool _IsWebMessageEnabled = true;
        private bool _IsStatusBarEnabled;
        private bool _IsScriptEnabled = true;
        private string _Url;
        public event EventHandler<NavigationStartingEventArgs> NavigationStart;
        public event EventHandler<ContentLoadingEventArgs> ContentLoading;
        public event EventHandler<SourceChangedEventArgs> SourceChanged;
        public event EventHandler<WebView2EventArgs> HistoryChanged;
        public event EventHandler<NavigationCompletedEventArgs> NavigationCompleted;
        public event EventHandler<WebResourceRequestedEventArgs> WebResourceRequested;
        public event EventHandler<AcceleratorKeyPressedEventArgs> AcceleratorKeyPressed;
        public event EventHandler<WebView2EventArgs> WebViewGotFocus;
        public event EventHandler<WebView2EventArgs> WebViewLostFocus;
        public event EventHandler<MoveFocusRequestedEventArgs> MoveFocusRequested;
        public event EventHandler<WebView2EventArgs> ZoomFactorChanged;
        public event EventHandler<WebView2EventArgs> DocumentTitleChanged;
        //public event EventHandler<DocumentStateChangedEventArgs> DocumentStateChanged;
        public event EventHandler<WebView2EventArgs> ContainsFullScreenElementChanged;
        public event EventHandler<NewWindowRequestedEventArgs> NewWindowRequested;
        public event EventHandler<PermissionRequestedEventArgs> PermissionRequested;
        public event EventHandler<NavigationStartingEventArgs> FrameNavigationStarting;
        public event EventHandler<ExecuteScriptCompletedEventArgs> ExecuteScriptCompleted;
        public event EventHandler<ProcessFailedEventArgs> ProcessFailed;
        public event EventHandler<ScriptDialogOpeningEventArgs> ScriptDialogOpening;
        public event EventHandler<WebMessageReceivedEventArgs> WebMessageReceived;
        public event EventHandler<AddScriptToExecuteOnDocumentCreatedCompletedEventArgs>
            ScriptToExecuteOnDocumentCreatedCompleted;
        public event EventHandler WebViewCreated;


        public string MonitoringFolder { get; set; } = "";
        public string MonitoringUrl { get; set; } = "";
        public bool EnableMonitoring { get; set; } = false;
        public bool IsCreated { get; set; }
        public string Url
        {
            get => this._Url;
            set => this._Url = value;
        }
        public string HtmlContent
        {
            get => this._HtmlContent;
            set
            {

                this.NavigateToString(value);

            }
        }
        protected override void Initialize()
        {
            base.Initialize();
            this.ControlType = CoreWindowsWrapper.Win32ApiForm.ControlType.Label;
            this.TypeIdentifier = "static";
            this.Style = WindowStylesConst.WS_VISIBLE | WindowStylesConst.WS_CHILD | StaticControlStyles.SS_NOTIFY;
            this.BackColor = CoreWindowsWrapper.Tools.ColorTool.White;
            this.ForeColor = CoreWindowsWrapper.Tools.ColorTool.Black;
        }


        public override bool Create(IntPtr parentId)
        {
            bool created = base.Create(parentId);
            if (this.Handle != IntPtr.Zero)
            {
                this._WebViewControl = new WebView2Control(this.Handle);
                this._WebViewControl.Created += OnWebWindowCreated;
                this._WebViewControl.BeforeCreate += OnWebWindowBeforeCreate;
                this._WebViewControl.AcceleratorKeyPressed += OnAcceleratorKeyPressedIntern;
                this._WebViewControl.ContainsFullScreenElementChanged += OnContainsFullScreenElementChangedIntern;
                this._WebViewControl.ContentLoading += OnContentLoadingIntern;
                //this._WebViewControl.DocumentStateChanged += OnDocumentStateChangedIntern;
                this._WebViewControl.DocumentTitleChanged += OnDocumentTitleChangedIntern;
                this._WebViewControl.ExecuteScriptCompleted += OnExecuteScriptCompletedIntern;
                this._WebViewControl.FrameNavigationStarting += OnFrameNavigationStartingIntern;
                this._WebViewControl.GotFocus += OnWebViewGotFocusIntern;
                this._WebViewControl.HistoryChanged += OnHistoryChangedIntern;
                this._WebViewControl.LostFocus += OnWebViewLostFocusIntern;
                this._WebViewControl.MoveFocusRequested += OnMoveFocusRequestedIntern;
                this._WebViewControl.NavigateStart += OnNavigateStartIntern;
                this._WebViewControl.NavigationCompleted += OnNavigationCompletedIntern;
                this._WebViewControl.NewWindowRequested += OnNewWindowRequestedIntern;
                this._WebViewControl.PermissionRequested += OnPermissionRequestedIntern;
                this._WebViewControl.ProcessFailed += OnProcessFailedIntern;
                this._WebViewControl.ScriptDialogOpening += OnScriptDialogOpeningIntern;
                this._WebViewControl.ScriptToExecuteOnDocumentCreatedCompleted +=
                    OnScriptToExecuteOnDocumentCreatedCompletedIntern;
                this._WebViewControl.SourceChanged += OnSourceChangedIntern;
                this._WebViewControl.WebMessageReceived += OnWebMessageReceivedIntern;
                this._WebViewControl.WebResourceRequested += OnWebResourceRequestedIntern;
                this._WebViewControl.ZoomFactorChanged += OnZoomFactorChangedIntern;
            }
            else
            {
                throw new Exception("Cannot create WebView");
            }

            return created;

        }

        private void OnZoomFactorChangedIntern(object sender, WebView2EventArgs e)
        {
            OnZoomFactorChanged(e);
        }

        private void OnWebResourceRequestedIntern(object sender, WebResourceRequestedEventArgs e)
        {
            OnWebResourceRequested(e);
        }

        private void OnWebMessageReceivedIntern(object sender, WebMessageReceivedEventArgs e)
        {
            OnWebMessageReceived(e);
        }

        private void OnSourceChangedIntern(object sender, SourceChangedEventArgs e)
        {
            OnSourceChanged(e);
        }

        private void OnScriptToExecuteOnDocumentCreatedCompletedIntern(object sender, AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {
            OnScriptToExecuteOnDocumentCreatedCompleted(e);
        }

        private void OnScriptDialogOpeningIntern(object sender, ScriptDialogOpeningEventArgs e)
        {
            OnScriptDialogOpening(e);
        }

        private void OnProcessFailedIntern(object sender, ProcessFailedEventArgs e)
        {
            OnProcessFailed(e);
        }

        private void OnPermissionRequestedIntern(object sender, PermissionRequestedEventArgs e)
        {
            OnPermissionRequested(e);
        }

        private void OnNewWindowRequestedIntern(object sender, NewWindowRequestedEventArgs e)
        {
            OnNewWindowRequested(e);
        }

        private void OnNavigationCompletedIntern(object sender, NavigationCompletedEventArgs e)
        {
            OnNavigationCompleted(e);
        }

        private void OnNavigateStartIntern(object sender, NavigationStartingEventArgs e)
        {
            OnNavigationStart(e);
        }

        private void OnMoveFocusRequestedIntern(object sender, MoveFocusRequestedEventArgs e)
        {
            OnMoveFocusRequested(e);
        }

        private void OnWebViewLostFocusIntern(object sender, WebView2EventArgs e)
        {
            OnWebViewLostFocus(e);
        }

        private void OnHistoryChangedIntern(object sender, WebView2EventArgs e)
        {
            OnHistoryChanged(e);
        }

        private void OnWebViewGotFocusIntern(object sender, WebView2EventArgs e)
        {
            OnWebViewGotFocus(e);
        }

        private void OnFrameNavigationStartingIntern(object sender, NavigationStartingEventArgs e)
        {
            OnFrameNavigationStarting(e);
        }

        private void OnExecuteScriptCompletedIntern(object sender, ExecuteScriptCompletedEventArgs e)
        {
            OnExecuteScriptCompleted(e);
        }

        private void OnDocumentTitleChangedIntern(object sender, WebView2EventArgs e)
        {
            OnDocumentTitleChanged(e);
        }

        //private void OnDocumentStateChangedIntern(object sender, DocumentStateChangedEventArgs e)
        //{
        //    OnDocumentStateChanged(e);
        //}

        private void OnContentLoadingIntern(object sender, ContentLoadingEventArgs e)
        {
            OnContentLoading(e);
        }

        private void OnContainsFullScreenElementChangedIntern(object sender, WebView2EventArgs e)
        {
            OnContainsFullScreenElementChanged(e);
        }

        private void OnAcceleratorKeyPressedIntern(object sender, AcceleratorKeyPressedEventArgs e)
        {
            OnAcceleratorKeyPressed(e);
        }

        private void OnWebWindowBeforeCreate(object sender, BeforeCreateEventArgs e)
        {
            e.Settings.AreDefaultContextMenusEnabled = new CBOOL(this._DefaultContextMenusEnabled);
            e.Settings.AreDefaultScriptDialogsEnabled = new CBOOL(this._DefaultScriptDialogsEnabled);
            e.Settings.AreDevToolsEnabled = new CBOOL(this._DevToolsEnabled);
            e.Settings.IsScriptEnabled = new CBOOL(this._IsScriptEnabled);
            e.Settings.IsStatusBarEnabled = new CBOOL(this._IsStatusBarEnabled);
            e.Settings.IsWebMessageEnabled = new CBOOL(this._IsWebMessageEnabled);
        }

        public void DoDock()
        {
            if (this.IsCreated)
                this._WebViewControl.DockToParent();
        }

        private void OnWebWindowCreated(object sender, EventArgs e)
        {
            this.IsCreated = true;
            this.AddScriptToExecuteOnDocumentCreated(
                "window.external = { sendMessage: function(message) { window.chrome.webview.postMessage(message); }, receiveMessage: function(callback) { window.chrome.webview.addEventListener('message', function(e) { callback(e.data); }); } };");
            if (!string.IsNullOrEmpty(this._Url))
                this.Navigate(this.Url);
            if (!string.IsNullOrEmpty(this._HtmlContent))
                this.NavigateToString(this._HtmlContent);

            OnWebViewCreated();
        }

        public void Navigate(string url)
        {
            this._Url = url;
            if (this.IsCreated && !string.IsNullOrEmpty(this.Url))
            {
                try
                {
                    this._WebViewControl.Navigate(this._Url);
                }
                catch (Exception e)
                {
                    MessageBox.Show(this.Handle, e.Message, "Navigation Error!", MessageBoxOptions.OkOnly | MessageBoxOptions.IconError);

                }

            }

        }

        public void NavigateToString(string htmlContent)
        {
            this._HtmlContent = htmlContent;
            if (this.IsCreated && !string.IsNullOrEmpty(this._HtmlContent))
            {
                try
                {
                    this._WebViewControl.NavigateToString(this._HtmlContent);
                }
                catch (Exception e)
                {
                    MessageBox.Show(this.Handle, e.Message, "Navigation Error!", MessageBoxOptions.OkOnly | MessageBoxOptions.IconError);
                }

            }
        }

        public void GoBack()
        {
            if (this.IsCreated)
                this._WebViewControl.GoBack();
        }

        public void GoForward()
        {
            if (this.IsCreated)
                this._WebViewControl.GoForward();
        }

        public bool CanGoBack
        {
            get
            {
                if (this.IsCreated)
                    return this._WebViewControl.CanGoBack;
                return false;
            }
        }

        public bool CanGoForward
        {
            get
            {
                if (this.IsCreated)
                    return this._WebViewControl.CanGoForward;
                return false;
            }
        }

        public string DocumentTitle
        {
            get
            {
                if (this.IsCreated)
                    return this._WebViewControl.DocumentTitle;
                return "";
            }
        }
        public void SendMessage(string message)
        {
            this._WebViewControl.PostWebMessageAsString(message);
        }
        public void AddScriptToExecuteOnDocumentCreated(string javaScript)
        {
            if (this.IsCreated)
                this._WebViewControl.AddScriptToExecuteOnDocumentCreated(javaScript);
        }
        public void RemoveScriptToExecuteOnDocumentCreated(string id)
        {
            if (this.IsCreated)
                this._WebViewControl.RemoveRemoteObject(id);
        }

        public void PostWebMessageAsJson(string webMessageAsJson)
        {
            if (this.IsCreated)
                this._WebViewControl.PostWebMessageAsJson(webMessageAsJson);
        }
        public void PostWebMessageAsString(string webMessageAsString)
        {
            if (this.IsCreated)
                this._WebViewControl.PostWebMessageAsString(webMessageAsString);
        }

        public void AddRemoteObject(string name, object @object)
        {
            if (this.IsCreated)
                this._WebViewControl.AddRemoteObject(name, @object);
        }

        public void RemoveRemoteObject(string name)
        {
            if (this.IsCreated)
                this._WebViewControl.RemoveRemoteObject(name);
        }

        public void ExecuteScript(string javaScript)
        {
            if (this.IsCreated)
                this._WebViewControl.ExecuteScript(javaScript);
        }

        public string InvokeScript(string javaScript, Action<string, int, string> actionToInvoke)
        {
            if (this.IsCreated)
                return this._WebViewControl.InvokeScript(javaScript, actionToInvoke);
            return "";
        }

        public void OpenDevToolsWindow()
        {
            if (this.IsCreated)
                this._WebViewControl.OpenDevToolsWindow();
        }

        public bool IsWebMessageEnabled
        {
            get => this._IsWebMessageEnabled;
            set
            {
                this._IsWebMessageEnabled = value;
                if (this.IsCreated)
                {
                    this._WebViewControl.Settings.IsWebMessageEnabled = new CBOOL(value);
                }
            }
        }



        public bool IsStatusBarEnabled
        {
            get => this._IsStatusBarEnabled;
            set
            {
                this._IsStatusBarEnabled = value;
                if (this.IsCreated)
                {
                    this._WebViewControl.Settings.IsStatusBarEnabled = new CBOOL(value);
                }
            }
        }

        public bool IsScriptEnabled
        {
            get => this._IsScriptEnabled;
            set
            {
                this._IsScriptEnabled = value;
                if (this.IsCreated)
                {
                    this._WebViewControl.Settings.IsScriptEnabled = new CBOOL(value);
                }
            }
        }


        public bool DevToolsEnabled
        {
            get => this._DevToolsEnabled;
            set
            {
                this._DevToolsEnabled = value;
                if (this.IsCreated)
                {
                    this._WebViewControl.Settings.AreDevToolsEnabled = new CBOOL(value);
                }
            }
        }

        public bool DefaultScriptDialogsEnabled
        {
            get => this._DefaultScriptDialogsEnabled;
            set
            {
                this._DefaultScriptDialogsEnabled = value;
                if (this.IsCreated)
                {
                    this._WebViewControl.Settings.AreDefaultScriptDialogsEnabled = new CBOOL(value);
                }
            }
        }

        public bool DefaultContextMenusEnabled
        {
            get => this._DefaultContextMenusEnabled;
            set
            {
                this._DefaultContextMenusEnabled = value;
                if (this.IsCreated)
                {
                    this._WebViewControl.Settings.AreDefaultContextMenusEnabled = new CBOOL(value);
                }
            }
        }

        protected virtual void OnNavigationStart(NavigationStartingEventArgs e)
        {
            NavigationStart?.Invoke(this, e);
        }

        protected virtual void OnContentLoading(ContentLoadingEventArgs e)
        {
            ContentLoading?.Invoke(this, e);
        }

        protected virtual void OnSourceChanged(SourceChangedEventArgs e)
        {
            SourceChanged?.Invoke(this, e);
        }

        protected virtual void OnHistoryChanged(WebView2EventArgs e)
        {
            HistoryChanged?.Invoke(this, e);
        }

        protected virtual void OnNavigationCompleted(NavigationCompletedEventArgs e)
        {
            NavigationCompleted?.Invoke(this, e);
        }

        protected virtual void OnWebResourceRequested(WebResourceRequestedEventArgs e)
        {
            if (this.EnableMonitoring)
            {
                if (GetFileStream(e.Request.Uri, out var responseInfo))
                {
                    var response = this.CreateResponse(responseInfo);
                    e.Response = response;
                }
            }
            WebResourceRequested?.Invoke(this, e);
        }
        public WebResourceResponse CreateResponse(ResponseInfo responseInfo)
        {
            WebResourceResponse response = null;
            if (this.IsCreated)
            {
                response = this._WebViewControl.GetResponseStream(responseInfo.Stream, responseInfo.StatusCode,
                    responseInfo.StatusText, responseInfo.HeaderToString(), responseInfo.ContentType);
            }

            return response;
        }
        private bool GetFileStream(string url, out ResponseInfo responseInfo)
        {

            if (string.IsNullOrEmpty(url) || !url.StartsWith(this.MonitoringUrl))
            {
                responseInfo = null;
                return false;
            }

            string baseDirectory = this.MonitoringFolder;
            string file = url.Replace(this.MonitoringUrl, "");
            if (string.IsNullOrEmpty(file))
                file = "index.html";
            file = file.Replace("/", "\\");
            file = Path.Combine(baseDirectory, file);
            FileInfo fileInfo = new FileInfo(file);
            if (!fileInfo.Exists)
            {
                responseInfo = new ResponseInfo("<h1>Server Error</h1><h5>file not found:" + file + "</h5>");
                responseInfo.Header.Add("content-type", "text/html");
                responseInfo.ContentType = "content-type: text/html";
                responseInfo.StatusCode = 404;
                responseInfo.StatusText = "Not Found";

                return false;
            }

            string contentType = fileInfo.MimeTypeOrDefault();
            if (contentType == "document")
                Debug.Print(contentType);
            try
            {
                byte[] bytes = File.ReadAllBytes(file);
                responseInfo = new ResponseInfo(bytes);
                responseInfo.Header.Add("content-type", contentType);
                responseInfo.ContentType = "content-type: " + contentType;
                responseInfo.StatusCode = 200;
                responseInfo.StatusText = "OK";
                return true;
            }
            catch (Exception e)
            {
                string message = "Error:" + e.Message;
                responseInfo = new ResponseInfo(message);
                responseInfo.Header.Add("content-type", "text/html");
                responseInfo.ContentType = "content-type: text/html";
                responseInfo.StatusCode = 500;
                responseInfo.StatusText = "Internal Server Error";
                return true;
            }


        }
        protected virtual void OnAcceleratorKeyPressed(AcceleratorKeyPressedEventArgs e)
        {
            AcceleratorKeyPressed?.Invoke(this, e);
        }

        protected virtual void OnWebViewGotFocus(WebView2EventArgs e)
        {
            WebViewGotFocus?.Invoke(this, e);
        }

        protected virtual void OnWebViewLostFocus(WebView2EventArgs e)
        {
            WebViewLostFocus?.Invoke(this, e);
        }

        protected virtual void OnZoomFactorChanged(WebView2EventArgs e)
        {
            ZoomFactorChanged?.Invoke(this, e);
        }

        protected virtual void OnMoveFocusRequested(MoveFocusRequestedEventArgs e)
        {
            MoveFocusRequested?.Invoke(this, e);
        }

        protected virtual void OnDocumentTitleChanged(WebView2EventArgs e)
        {
            DocumentTitleChanged?.Invoke(this, e);
        }

        protected virtual void OnContainsFullScreenElementChanged(WebView2EventArgs e)
        {
            ContainsFullScreenElementChanged?.Invoke(this, e);
        }

        protected virtual void OnNewWindowRequested(NewWindowRequestedEventArgs e)
        {
            NewWindowRequested?.Invoke(this, e);
        }

        protected virtual void OnPermissionRequested(PermissionRequestedEventArgs e)
        {
            PermissionRequested?.Invoke(this, e);
        }

        protected virtual void OnFrameNavigationStarting(NavigationStartingEventArgs e)
        {
            FrameNavigationStarting?.Invoke(this, e);
        }

        protected virtual void OnExecuteScriptCompleted(ExecuteScriptCompletedEventArgs e)
        {
            ExecuteScriptCompleted?.Invoke(this, e);
        }

        protected virtual void OnProcessFailed(ProcessFailedEventArgs e)
        {
            ProcessFailed?.Invoke(this, e);
        }

        protected virtual void OnScriptDialogOpening(ScriptDialogOpeningEventArgs e)
        {
            ScriptDialogOpening?.Invoke(this, e);
        }

        protected virtual void OnWebMessageReceived(WebMessageReceivedEventArgs e)
        {
            WebMessageReceived?.Invoke(this, e);
        }

        protected virtual void OnScriptToExecuteOnDocumentCreatedCompleted(AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {
            ScriptToExecuteOnDocumentCreatedCompleted?.Invoke(this, e);
        }

        //protected virtual void OnDocumentStateChanged(DocumentStateChangedEventArgs e)
        //{
        //    DocumentStateChanged?.Invoke(this, e);
        //}

        protected virtual void OnWebViewCreated()
        {
            WebViewCreated?.Invoke(this, EventArgs.Empty);
        }
    }
}
