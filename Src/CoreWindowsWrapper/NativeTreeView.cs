using Diga.Core.Api.Win32;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace CoreWindowsWrapper
{
    public class TreeViewChagneEventArgs : EventArgs
    {
        public uint Action { get; }
        public TVITEMEXW OldItem { get; } 
        public TVITEMEXW NewItem { get; }
        public int OldKey => this.OldItem.lParam.ToInt32();
        public int NewKey => this.NewItem.lParam.ToInt32();
        public TreeViewChagneEventArgs(uint action , TVITEMEXW oldItem, TVITEMEXW newItem)
        {
            this.Action = action;
            this.OldItem = oldItem;
            this.NewItem = newItem;
        }
    }
    public class NativeTreeView : NativeControlBase
    {
        public event EventHandler<EventArgs> SetFocus;
        public event EventHandler<EventArgs> KillFocus;
        public event EventHandler<TreeViewChagneEventArgs> Changed;
        public event EventHandler<TreeViewChagneEventArgs> Changeing;
        protected override void Initialize()
        {
            base.Initialize();
            this.ControlType = Win32ApiForm.ControlType.TreeView;
            this.CommonControlType = CommonControls.ICC_TREEVIEW_CLASSES;
            this.TypeIdentifier = "SysTreeView32";
            this.Style |= WindowStylesConst.WS_BORDER | WindowStylesConst.WS_HSCROLL | WindowStylesConst.WS_TABSTOP | TreeViewConst.TVS_HASLINES | TreeViewConst.TVS_EDITLABELS | TreeViewConst.TVS_HASBUTTONS | TreeViewConst.TVS_LINESATROOT;
        }
        protected override void AfterCreate()
        {
            base.AfterCreate();
            NativeTheaming.SetThemaing(this.Handle);
        }
        public void SetImageList(NativeImageList imageList)
        {
            TreeViewMacros.TreeView_SetImageList(this.Handle, imageList.Handle);
        }
        public IntPtr AddItem(IntPtr parent, string text, int imageIndex = 0, int expandImage = -1, int selectImage = -1)
        {
            var count = TreeViewMacros.TreeView_GetCount(this.Handle);
            TVITEMEXW tvi = new TVITEMEXW();
            TVINSERTSTRUCTEXW tvins = new TVINSERTSTRUCTEXW();
            tvi.mask = TreeViewConst.TVIF_TEXT | TreeViewConst.TVIF_IMAGE | TreeViewConst.TVIF_EXPANDEDIMAGE | TreeViewConst.TVIF_SELECTEDIMAGE | TreeViewConst.TVIF_PARAM;
            tvi.pszText = text;
            tvi.cchTextMax = text.Length;
            tvi.iImage = imageIndex;
            tvi.lParam = new IntPtr(count);
            if (selectImage > -1)
            {
                tvi.iSelectedImage = selectImage;
            }
            else
            {
                tvi.iSelectedImage = imageIndex;
            }

            if (expandImage > -1)
            {
                tvi.iExpandedImage = expandImage;
            }
            else
            {
                tvi.iExpandedImage = imageIndex;
            }
            tvins.item = tvi;
            tvins.hParent = parent;
            tvins.hInsertAfter = parent;
            return TreeViewMacros.TreeView_InsertItem(this.Handle, tvins);
        }
        public IntPtr AddItemToRoot(string text, int imageIndex = 0, int expandImage = -1, int selectImage = -1)
        {
            return AddItem(TreeViewConst.TVI_ROOT, text, imageIndex, expandImage, selectImage);
        }

        public IntPtr AddItemAfter(IntPtr parent, IntPtr after, string text, int imageIndex = 0, int expandImage = -1, int selectImage = -1)
        {
            var count = TreeViewMacros.TreeView_GetCount(this.Handle);

            TVITEMEXW tvi = new TVITEMEXW();
            TVINSERTSTRUCTEXW tvins = new TVINSERTSTRUCTEXW();
            tvi.mask = TreeViewConst.TVIF_TEXT | TreeViewConst.TVIF_IMAGE | TreeViewConst.TVIF_EXPANDEDIMAGE | TreeViewConst.TVIF_SELECTEDIMAGE | TreeViewConst.TVIF_PARAM;
            tvi.pszText = text;
            tvi.cchTextMax = text.Length;
            tvi.iImage = imageIndex;
            tvi.lParam = new IntPtr(count);
            if (expandImage > -1)
            {
                tvi.iExpandedImage = expandImage;
            }
            else
            {
                tvi.iExpandedImage = imageIndex;
            }
            if (selectImage > -1)
            {
                tvi.iSelectedImage  = selectImage;
            }
            else
            {
                tvi.iSelectedImage = imageIndex;
            }


            tvins.item = tvi;
            tvins.hParent = parent;
            tvins.hInsertAfter = after;
            
            return TreeViewMacros.TreeView_InsertItem(this.Handle, tvins);
        }
        private TVITEMEXW GetItem(TVITEMW item)
        {
            var nItem = new TVITEMEXW();
            nItem.mask = TreeViewConst.TVIF_TEXT | TreeViewConst.TVIF_IMAGE | TreeViewConst.TVIF_EXPANDEDIMAGE | TreeViewConst.TVIF_SELECTEDIMAGE | TreeViewConst.TVIF_CHILDREN | TreeViewConst.TVIF_PARAM;
            nItem.pszText = new string('\0', 1000);
            nItem.hItem =item.hItem;
            nItem.cchTextMax = 1000;
            nItem.hwnd = this.Handle;


            if (TreeViewMacros.TreeView_GetItem(this.Handle, ref nItem))
            {
               return nItem;
            }

            return new TVITEMEXW {lParam = new IntPtr(-1) };
        }
        protected override bool ControlProc(IntPtr hWndParent, IntPtr hWndControl, int controlId, uint command, IntPtr wParam, IntPtr lParam)
        {
            bool result = false;
            switch(command)
            {
                case NotifyMessageConst.NM_CLICK:
                    OnClicked();
                    result = false; 
                    break;
                case NotifyMessageConst.NM_DBLCLK:
                    OnDblClicked();
                    result = false;
                    break;
                case NotifyMessageConst.NM_KILLFOCUS:
                    OnKillFocus();
                    result = false;
                    break;
                case NotifyMessageConst.NM_SETFOCUS:
                    OnSetFocus();
                    result = false;
                    break;
                case TreeViewConst.TVN_KEYDOWN:
                    try
                    {
                        
                        NMTVKEYDOWN nmKeyDwon = Marshal.PtrToStructure<NMTVKEYDOWN>(lParam);
                        result = true;
                        break;
                    }
                    catch 
                    {

                        
                    }
                    result = false;
                    break;
               

                case TreeViewConst.TVN_ITEMEXPANDINGW:
                    try
                    {
                        NMTREEVIEWW nmTv = Marshal.PtrToStructure<NMTREEVIEWW>(lParam);
                        result = true;
                        break;
                    }
                    catch 
                    {

                        
                    }
                    result = false;
                    break;
                case TreeViewConst.TVN_ITEMEXPANDED:
                    try
                    {
                        NMTREEVIEWW nmTv = Marshal.PtrToStructure<NMTREEVIEWW>(lParam);
                        result = true;
                        break;
                    }
                    catch 
                    {

                        
                    }
                    result = false;
                    break;
                case TreeViewConst.TVN_SELCHANGEDW:
                    try
                    {
                        NMTREEVIEWW nmTv = Marshal.PtrToStructure<NMTREEVIEWW>(lParam);
                        TVITEMW newItem = nmTv.itemNew;
                        TVITEMW oldItem = nmTv.itemOld;
                        OnChanged(new TreeViewChagneEventArgs(nmTv.action, GetItem(oldItem), GetItem(newItem)));
                        switch(nmTv.action)
                        {
                            case TreeViewConst.TVC_BYKEYBOARD:
                                break;
                            case TreeViewConst.TVC_BYMOUSE:
                                break;
                            case TreeViewConst.TVC_UNKNOWN:
                                break;
                        }
                        result = true;
                        break;
                    }
                    catch
                    {


                    }
                    result = false;
                    break;
                case TreeViewConst.TVN_SELCHANGINGW:
                    try
                    {
                        NMTREEVIEWW nmTv = Marshal.PtrToStructure<NMTREEVIEWW>(lParam);
                        TVITEMW newItem = nmTv.itemNew;
                        TVITEMW oldItem = nmTv.itemOld;
                        OnChangeing(new TreeViewChagneEventArgs(nmTv.action,GetItem( oldItem), GetItem(newItem)));
                        result = true;
                        break;
                    }
                    catch
                    {


                    }
                    result = false;
                    break;
            }
            return result;
        }
        public void Clear()
        {
            TreeViewMacros.TreeView_DeleteAllItems(this.Handle);
        }
        protected virtual void OnChanged(TreeViewChagneEventArgs e)
        {
            SafeInvoke(Changed, e);
        }
        protected virtual void OnChangeing(TreeViewChagneEventArgs e)
        {
            SafeInvoke(Changeing, e);
        }
        public bool Expand(IntPtr item)
        {
            return TreeViewMacros.TreeView_ExpandPtr(this.Handle , item,TreeViewConst.TVE_EXPAND );
        }

        public bool Collapse(IntPtr item)
        {
            return TreeViewMacros.TreeView_ExpandPtr(this.Handle, item, TreeViewConst.TVE_COLLAPSE);
        }

        protected virtual void OnSetFocus()
        {
            SafeInvoke(SetFocus,EventArgs.Empty);
        }

        protected virtual void OnKillFocus()
        {
            SafeInvoke(KillFocus,EventArgs.Empty);
        }
    }
}