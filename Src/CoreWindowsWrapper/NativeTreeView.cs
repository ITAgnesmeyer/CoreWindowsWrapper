﻿using Diga.Core.Api.Win32;
using System;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace CoreWindowsWrapper
{
    public class NativeTreeView : NativeControlBase
    {
        public event EventHandler<EventArgs> SetFocus;
        public event EventHandler<EventArgs> KillFocus;

        protected override void Initialize()
        {
            base.Initialize();
            this.ControlType = Win32ApiForm.ControlType.TreeView;
            this.CommonControlType = CommonControls.ICC_TREEVIEW_CLASSES;
            this.TypeIdentifier = "SysTreeView32";
            this.Style |= WindowStylesConst.WS_BORDER | WindowStylesConst.WS_HSCROLL | WindowStylesConst.WS_TABSTOP;//| TreeViewConst.TVS_HASLINES;
        }

        public void SetImageList(NativeImageList imageList)
        {
            TreeViewMacros.TreeView_SetImageList(this.Handle, imageList.Handle);
        }
        public IntPtr AddItem(IntPtr parent, string text, int imageIndex = 0, int expandImage = -1, int selectImage = -1)
        {
            TVITEMEXW tvi = new TVITEMEXW();
            TVINSERTSTRUCTEXW tvins = new TVINSERTSTRUCTEXW();
            tvi.mask = TreeViewConst.TVIF_TEXT | TreeViewConst.TVIF_IMAGE | TreeViewConst.TVIF_EXPANDEDIMAGE | TreeViewConst.TVIF_SELECTEDIMAGE;
            tvi.pszText = text;
            tvi.cchTextMax = text.Length;
            tvi.iImage = imageIndex;
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
            TVITEMEXW tvi = new TVITEMEXW();
            TVINSERTSTRUCTEXW tvins = new TVINSERTSTRUCTEXW();
            tvi.mask = TreeViewConst.TVIF_TEXT | TreeViewConst.TVIF_IMAGE | TreeViewConst.TVIF_EXPANDEDIMAGE | TreeViewConst.TVIF_SELECTEDIMAGE;
            tvi.pszText = text;
            tvi.cchTextMax = text.Length;
            tvi.iImage = imageIndex;
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