using System;
using CoreWindowsWrapper.Api.Win32;
using Diga.WebView2.Wrapper;
using Diga.WebView2.Wrapper.EventArguments;

namespace CoreWindowsWrapper
{


    public class NativeWebBrowser : NativeControlBase
    {
        private WebView2Control _Control;
        private bool _BrowserCreated;
        private bool _DefaultContextMenusEnabled = true;
        private bool _DefaultScriptDialogsEnabled = true;
        private bool _DevToolsEnabled = true;
        private bool _IsWebMessageEnabled = true;
        private bool _IsStatusBarEnabled ;
        private bool _IsScriptEnabled = true;
        public string Url{get;set;}
        protected override void Initialize()
        {
            base.Initialize();
            this.ControlType = Win32ApiForm.ControlType.Label;
            this.TypeIdentifier = "static";
            this.Style = WindowStylesConst.WS_VISIBLE | WindowStylesConst.WS_CHILD | StaticControlStyles.SS_NOTIFY;
            this.BackColor = Tools.ColorTool.White;
            this.ForeColor = Tools.ColorTool.Black;
        }


        public override bool Create(IntPtr parentId)
        {
            bool created = base.Create(parentId);
            if (this.Handle != IntPtr.Zero)
            {
                this._Control = new WebView2Control(this.Handle);
                this._Control.Created += OnBrowserControlCreated;
                this._Control.BeforeCreate += OnWebWindowBeforeCreate;
            }

            return created;

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
            if (this._BrowserCreated)
                this._Control.DockToParent();
        }

        private void OnBrowserControlCreated(object sender, EventArgs e)
        {
            this._BrowserCreated = true;
            this.Navigate(this.Url);
            
        }

        public void Navigate(string uri)
        {
            if (this._BrowserCreated)
                this._Control.Navigate(uri);

        }

        public void NavigateToString(string htmlContent)
        {
            if (this._BrowserCreated)
                this._Control.NavigateToString(htmlContent);
        }

        public void GoBack()
        {
            if (this._BrowserCreated)
                this._Control.GoBack();
        }

        public void GoForward()
        {
            if (this._BrowserCreated)
                this._Control.GoForward();
        }

        public bool CanGoBack
        {
            get
            {
                if (this._BrowserCreated)
                    return this._Control.CanGoBack;
                return false;
            }
        }

        public bool CanGoForward
        {
            get
            {
                if (this._BrowserCreated)
                    return this._Control.CanGoForward;
                return false;
            }
        }

        public string DocumentTitle
        {
            get
            {
                if (this._BrowserCreated)
                    return this._Control.DocumentTitle;
                return "";
            }
        }

        public void AddScriptToExecuteOnDocumentCreated(string javaScript)
        {
            if (this._BrowserCreated)
                this._Control.AddScriptToExecuteOnDocumentCreated(javaScript);
        }
        public void RemoveScriptToExecuteOnDocumentCreated(string id)
        {
            if (this._BrowserCreated)
                this._Control.RemoveScriptToExecuteOnDocumentCreated(id);
        }

        public void PostWebMessageAsJson(string webMessageAsJson)
        {
            if (this._BrowserCreated)
                this._Control.PostWebMessageAsJson(webMessageAsJson);
        }
        public void PostWebMessageAsString(string webMessageAsString)
        {
            if (this._BrowserCreated)
                this._Control.PostWebMessageAsString(webMessageAsString);
        }

        public void AddRemoteObject(string name, object @object)
        {
            if (this._BrowserCreated)
                this._Control.AddRemoteObject(name, @object);
        }

        public void RemoveRemoteObject(string name)
        {
            if (this._BrowserCreated)
                this._Control.RemoveRemoteObject(name);
        }

        public void ExecuteScript(string javaScript)
        {
            if (this._BrowserCreated)
                this._Control.ExecuteScript(javaScript);
        }

        public string InvokeScript(string javaScript, Action<string, int, string> actionToInvoke)
        {
            if (this._BrowserCreated)
                return this._Control.InvokeScript(javaScript, actionToInvoke);
            return "";
        }

        public void OpenDevToolsWindow()
        {
            if (this._BrowserCreated)
                this._Control.OpenDevToolsWindow();
        }

        public bool IsWebMessageEnabled
        {
            get => _IsWebMessageEnabled;
            set
            {
                _IsWebMessageEnabled = value;
                if (this._BrowserCreated)
                {
                    this._Control.Settings.IsWebMessageEnabled = new CBOOL(value);
                }
            }
        }

        public bool IsStatusBarEnabled
        {
            get => _IsStatusBarEnabled;
            set
            {
                _IsStatusBarEnabled = value;
                if (this._BrowserCreated)
                {
                    this._Control.Settings.IsStatusBarEnabled = new CBOOL(value);
                }
            }
        }

        public bool IsScriptEnabled
        {
            get => _IsScriptEnabled;
            set
            {
                _IsScriptEnabled = value;
                if (this._BrowserCreated)
                {
                    this._Control.Settings.IsScriptEnabled = new CBOOL(value);
                }
            }
        }


        public bool DevToolsEnabled
        {
            get => _DevToolsEnabled;
            set
            {
                _DevToolsEnabled = value;
                if (this._BrowserCreated)
                {
                    this._Control.Settings.AreDevToolsEnabled = new CBOOL(value);
                }
            }
        }

        public bool DefaultScriptDialogsEnabled
        {
            get => _DefaultScriptDialogsEnabled;
            set
            {
                _DefaultScriptDialogsEnabled = value;
                if (this._BrowserCreated)
                {
                    this._Control.Settings.AreDefaultScriptDialogsEnabled = new CBOOL(value);
                }
            }
        }

        public bool DefaultContextMenusEnabled
        {
            get => _DefaultContextMenusEnabled;
            set
            {
                _DefaultContextMenusEnabled = value;
                if (this._BrowserCreated)
                {
                    this._Control.Settings.AreDefaultContextMenusEnabled = new CBOOL(value);
                }
            }
        }
    }
}