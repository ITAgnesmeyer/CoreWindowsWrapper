using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Diga.Core.Api.Win32;
namespace CoreWindowsWrapper
{
    public class OpenFileDialog
    {
        private OfNw _OfNw;

        public OpenFileDialog()
        {
            this._OfNw = new OfNw {hInstance = Process.GetCurrentProcess().Handle};
            this._OfNw.lStructSize = (uint) Marshal.SizeOf(this._OfNw);
            this._OfNw.lpstrFilter = "All Files\0*.*\0";
            this._OfNw.lpstrFile = new string(new char[257]);
            this._OfNw.nMaxFile = (uint) this._OfNw.lpstrFile.Length;
            this._OfNw.lpstrFileTitle = new string(new char[65]);
            this._OfNw.nMaxFileTitle = (uint) this._OfNw.lpstrFileTitle.Length;
            this._OfNw.lpstrInitialDir = "C:\\";
            this._OfNw.lpstrTitle = "Open File...";
            this._OfNw.lpstrDefExt = "*";
            
        }

        public bool Show(IControl parent = null)
        {
            if (parent != null)
                this._OfNw.hwndOwner = parent.Handle;
            return ComDlg32.GetOpenFileName(ref this._OfNw);
           
        }

        public int DefaultFilterIndex
        {
            get => (int)this._OfNw.nFilterIndex;
            set => this._OfNw.nFilterIndex = (uint)value;
        }
        public string File
        {
            get => this._OfNw.lpstrFile;
        }

        public string InitialDir
        {
            get => this._OfNw.lpstrInitialDir;
            set => this._OfNw.lpstrInitialDir = value;
        }

        public string DefaultExtension
        {
            get => this._OfNw.lpstrDefExt;
            set => this._OfNw.lpstrDefExt = value;
        }
        public string Title
        {
            get => this._OfNw.lpstrTitle;
            set => this._OfNw.lpstrTitle = value;
        }

        public string Filter
        {
            get => this._OfNw.lpstrFilter;
            set => this._OfNw.lpstrFilter = value;
        }


    }
}
