using System.Diagnostics;
using System.Runtime.InteropServices;
using CoreWindowsWrapper.Api.Win32;
namespace CoreWindowsWrapper
{
    public class OpenFileDialog
    {
        private OFNW _OFNW;

        public OpenFileDialog()
        {
            this._OFNW = new OFNW {hInstance = Process.GetCurrentProcess().Handle};
            this._OFNW.lStructSize = (uint) Marshal.SizeOf(this._OFNW);
            this._OFNW.lpstrFilter = "All Files\0*.*\0";
            this._OFNW.lpstrFile = new string(new char[257]);
            this._OFNW.nMaxFile = (uint) this._OFNW.lpstrFile.Length;
            this._OFNW.lpstrFileTitle = new string(new char[65]);
            this._OFNW.nMaxFileTitle = (uint) this._OFNW.lpstrFileTitle.Length;
            this._OFNW.lpstrInitialDir = "C:\\";
            this._OFNW.lpstrTitle = "Open File...";
            this._OFNW.lpstrDefExt = "*";
        }

        public bool Show(IControl parent = null)
        {
            if (parent != null)
                this._OFNW.hwndOwner = parent.Handle;
            return Win32Api.GetOpenFileName(ref this._OFNW);
           
        }

        public string File
        {
            get => this._OFNW.lpstrFile;
        }

        public string InitialDir
        {
            get => this._OFNW.lpstrInitialDir;
            set => this._OFNW.lpstrInitialDir = value;
        }

        public string DefaultExtension
        {
            get => this._OFNW.lpstrDefExt;
            set => this._OFNW.lpstrDefExt = value;
        }
        public string Title
        {
            get => this._OFNW.lpstrTitle;
            set => this._OFNW.lpstrTitle = value;
        }

        public string Filter
        {
            get => this._OFNW.lpstrFilter;
            set => this._OFNW.lpstrFilter = value;
        }


    }
}
