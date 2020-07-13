using System;
using System.Runtime.InteropServices;
using System.Text;
using Diga.Core.Api.Win32;
namespace CoreWindowsWrapper
{
    public class OpenFolderDialog
    {
        private IntPtr _ParentHandle;
        private string _InitFolder;
        public string Caption { get; set; }
        public string SelectedPath { get; set; }
        public string InitialPath { get => this._InitFolder; set => this._InitFolder = value; }
        public OpenFolderDialog()
        {
            this._ParentHandle = IntPtr.Zero;
            this.Caption = "Selec a Folder";

        }
        private int OnBffCallByck(IntPtr hwnd, uint msg, IntPtr lp, IntPtr wp)
        {
            switch (msg)
            {
                case BrowseForFolderConst.BFFM_INITIALIZED:
                    User32.SendMessage(hwnd, (int)BrowseForFolderConst.BFFM_SETSELECTIONW, 1, _InitFolder);
                    break;
                case BrowseForFolderConst.BFFM_SELCHANGED:
                    StringBuilder sb = new StringBuilder(256);
                    if (Shell32.SHGetPathFromIDList(lp, sb))
                    {
                        User32.SendMessage(hwnd, (int)BrowseForFolderConst.BFFM_SETSTATUSTEXTW, 0, sb);
                    }
                    break;
            }
            return 0;
        }


        public bool Show(IControl control = null)
        {
            if (control != null)
                this._ParentHandle = control.Handle;


            BrowseInfo bf = new BrowseInfo();
            bf.hwndOwner = this._ParentHandle;
            bf.pidlRoot = IntPtr.Zero;
            bf.lpszTitle = this.Caption;
            bf.ulFlags = BrowseForFolderConst.BIF_NEWDIALOGSTYLE | BrowseForFolderConst.BIF_SHAREABLE;
            bf.lpfn = new BrowseCallBackProc(OnBffCallByck);
            bf.lParam = IntPtr.Zero;
            bf.iImage = 0;
            IntPtr pidl = IntPtr.Zero;
            try
            {
                StringBuilder sb = new StringBuilder(256);
                pidl = Shell32.SHBrowseForFolder(ref bf);
                if (pidl == IntPtr.Zero)
                    return false;

                bool retVal = Shell32.SHGetPathFromIDList(pidl, sb);
                if(retVal)
                {
                    this.SelectedPath = sb.ToString();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(this._ParentHandle, "Cannot show Select Folder dialog!", "Error!" + ex.Message, MessageBoxOptions.OkOnly | MessageBoxOptions.IconError);
                return false;
            }
            finally
            {
                if (pidl != IntPtr.Zero)
                    Marshal.FreeCoTaskMem(pidl);

            }
        }
    }
}
