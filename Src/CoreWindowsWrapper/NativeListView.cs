using Diga.Core.Api.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace CoreWindowsWrapper
{
    public class ListViewItem
    {
        private tagLVITEMW _Item;
        public ListViewItem(tagLVITEMW item)
        {
            this._Item = item;
        }
        public ListViewItem()
        {
            this._Item = new tagLVITEMW();
            this.Mask = ListViewItemMemberValidInfoConst.LVIF_TEXT;
            this.SubItemIndex = 0;
        }

        public tagLVITEMW ToStruct()
        { return this._Item; }

        public int ItemIndex
        {
            get
            {
                return this._Item.iItem;
            }
            set
            {
                this._Item.iItem = value;
            }
        }

        public int SubItemIndex
        {
            get
            {
                return this._Item.iSubItem;
            }
            set
            {
                this._Item.iSubItem = value;
            }
        }

        public uint Mask
        {
            get
            {
                return this._Item.mask;
            }
            set
            {
                this._Item.mask = value;
            }
        }

        public uint State
        {
            get
            {
                return this._Item.state;
            }
            set
            {
                this._Item.state = value;
            }
        }

        public uint StateMask
        {
            get
            {
                return this._Item.stateMask;
            }
            set
            {
                this._Item.stateMask = value;
            }
        }
        public string Text
        {
            get
            {
                return this._Item.pszText;
            }
            set
            {
                this._Item.pszText = value;
            }
        }

        public int CChTextMax
        {
            get
            {
                return this._Item.cchTextMax;
            }
            set
            {
                this._Item.cchTextMax = value;
            }
        }

        public int ImageIndex
        {
            get
            {
                return this._Item.iImage;
            }
            set
            {
                this._Item.iImage = value;
            }
        }

        public IntPtr LParam
        {
            get
            {
                return (IntPtr)this._Item.lParam;
            }
            set
            {
                this._Item.lParam = (int)value;
            }
        }

        public int Indent
        {
            get
            {
                return this._Item.iIndent;
            }
            set 
            { 
                this._Item.iIndent = value;
            }
        }

        public int GroupId
        {
            get
            {
                return ((int)this._Item.iGroupId);
            }
            set
            {
                this._Item.iGroupId = value;
            }
        }

        public IntPtr ColumnsPtr
        {
            get
            {
                return this._Item.puColumns;
            }
            set
            {
                this._Item.puColumns = value;
            }
        }

        public IntPtr ColumnFormatPtr
        {
            get
            {
                return this._Item.piColFmt;
            }
            set
            {
                this._Item.piColFmt = value;
            }
        }

        public int GroupIndex
        {
            get
            {
                return this._Item.iGroup;
            }
            set
            {
                this._Item.iGroup = value;  
            }
        }

        public static implicit operator tagLVITEMW(ListViewItem input)
        {
            return input.ToStruct();
        }
        public static implicit operator ListViewItem(tagLVITEMW input)
        {
            return new ListViewItem(input);
        }
    }

    public class ListViewColumn
    {
        private tagLVCOLUMNW _Column;
        public ListViewColumn(tagLVCOLUMNW column)
        {
            this._Column = column;
        }
        public ListViewColumn()
        {
            _Column = new tagLVCOLUMNW();
            this.Mask = ListViewColumnMemberValidInfoConst.LVCF_FMT |
                                               ListViewColumnMemberValidInfoConst.LVCF_WIDTH |
                                               ListViewColumnMemberValidInfoConst.LVCF_TEXT;
            this.Format = ListViewColumnHeaderAlignConst.LVCFMT_LEFT;
            this.Cx = 100;
        }
        public tagLVCOLUMNW ToStruct()
        { 
            return this._Column; 
        }
        public uint Mask
        {
            get
            {
                return this._Column.mask;
            }
            set
            {
                this._Column.mask = value;
            }
        }

       

        public int Format
        {
            get
            {
                return this._Column.fmt;
            }
            set
            {
                this._Column.fmt = value;
            }
        }
        public int Cx
        {
            get
            {
                return (int)this._Column.cx;
            }
            set 
            { 
                this._Column.cx = value; 
            }
        }
        public string Text
        {
            get
            {
                return this._Column.pszText;
            }
            set
            {
                this._Column.pszText = value;
                this.CChTextMax = value.Length;
            }
        }

        public int CChTextMax
        {
            get
            {
                return this._Column.cchTextMax;
            }
            set
            {
                this._Column.cchTextMax = value;
            }
        }


        public int SubItemIndex
        {
            get
            {
                return this._Column.iSubItem;
            }
            set
            {
                this._Column.iSubItem = value;
            }
        }

        public int ImageIndex
        {
            get
            {
                return this._Column.iImage;
            }
            set 
            { 
                this._Column.iImage = value;
            }
        }
       
        public int Order
        {
            get
            {
                return this._Column.iOrder;
            }
            set
            {
                this._Column.iOrder = value;
            }
        }

        public int CxMin
        {
            get
            {
                return this._Column.cxMin;
            }
            set 
            { 
                this._Column.cxMin = value;
            }
        }

        public int CxDefault
        {
            get
            {
                return this._Column.cxDefault;
            }
            set 
            { 
                this._Column.cxDefault = value;
            }
        }

        public int CxIdeal
        {
            get
            {
                return this._Column.cxIdeal;
            }
            set
            {
                this._Column.cxIdeal = value;
            }
        }
        
        public static implicit operator tagLVCOLUMNW(ListViewColumn input)
        {
            return input.ToStruct();
        }
        public static implicit operator ListViewColumn(tagLVCOLUMNW input)
        {
            return new ListViewColumn(input);
        }


    }
    public class NativeListView : NativeControlBase
    {
        private const uint HDM_GETITEMRECT = (0x1200 + 7);
        private const uint LVS_ICON = 0x0000;
        private const uint LVS_REPORT = 0x0001;
        private const uint LVS_SMALLICON = 0x0002;
        private const uint LVS_LIST = 0x0003;
        private const uint LVS_TYPEMASK = 0x0003;
        private const uint LVS_SINGLESEL = 0x0004;
        private const uint LVS_SHOWSELALWAYS = 0x0008;
        private const uint LVS_SORTASCENDING = 0x0010;
        private const uint LVS_SORTDESCENDING = 0x0020;
        private const uint LVS_SHAREIMAGELISTS = 0x0040;
        private const uint LVS_NOLABELWRAP = 0x0080;
        private const uint LVS_AUTOARRANGE = 0x0100;
        private const uint LVS_EDITLABELS = 0x0200;
        private const uint LVS_OWNERDATA = 0x1000;
        private const uint LVS_NOSCROLL = 0x2000;
        private const uint LVS_TYPESTYLEMASK = 0xfc00;
        private const uint LVS_ALIGNTOP = 0x0000;
        private const uint LVS_ALIGNLEFT = 0x0800;
        private const uint LVS_ALIGNMASK = 0x0c00;
        private const uint LVS_OWNERDRAWFIXED = 0x0400;
        private const uint LVS_NOCOLUMNHEADER = 0x4000;
        private const uint LVS_NOSORTHEADER = 0x8000;
        private List<ListViewColumn> _Columns = new List<ListViewColumn>();
        protected override void Initialize()
        {
            base.Initialize();
            //this.ControlType = Win32ApiForm.ControlType.ListView;
            this.CommonControlType = CommonControls.ICC_LISTVIEW_CLASSES;
            this.TypeIdentifier = "SysListView32";
            
            this.Style =  LVS_SINGLESEL| LVS_REPORT | LVS_SHOWSELALWAYS | LVS_EDITLABELS | LVS_ALIGNLEFT | (uint)WindowStyles.WS_CHILD | (uint)WindowStyles.WS_VISIBLE | (uint)WindowStyles.WS_BORDER | (uint)WindowStyles.WS_TABSTOP;



        }
        protected override void AfterCreate()
        {

            base.AfterCreate();
            //Old_EditProc = User32.SetWindowLongPtr(this.Handle, GWL.GWL_WNDPROC, Marshal.GetFunctionPointerForDelegate((WndProc)EditProc));

        }
        public void DeleteItem(int index)
        {
            ListViewMacros.ListView_DeleteItem(this.Handle, index);
        }
        public void SetItemText(int index, int column,  string text)
        {
            ListViewMacros.ListView_SetItemTextW(this.Handle, index, column, text);
        }
        public void CancelLabelEdit()
        {
            ListViewMacros.ListView_CancelEditLabel(this.Handle);
        }
        public tagLVHITTESTINFO SubItemHistTest(int x , int y)
        {
            tagLVHITTESTINFO itemCliced  = new tagLVHITTESTINFO();
            itemCliced.pt.X = x;
            itemCliced.pt.Y = y;
            int lRect = ListViewMacros.ListView_SubItemHitTest(this.Handle, ref itemCliced);
            if(lRect != -1 )
            {
                return itemCliced;
            }
            else
            {
                itemCliced.iItem = -1;
                itemCliced.iSubItem = -1;
                return itemCliced;
            }
        }
        public void InsertColumn(ListViewColumn column)
        {
            int i = column.SubItemIndex;
            ListViewMacros.ListView_InsertColumnW(this.Handle, i, column);
        }
        public Rect GetSubItemRect(int index, int subItemIndex)
        {
            ListViewMacros.ListView_GetSubItemRect(this.Handle, index, subItemIndex, ListViewItemRectConst.LVIR_BOUNDS, out Rect rect);
            return rect;

        }
        public string GetItemText(int index, int columnIndex)
        {
            ListViewMacros.ListView_GetItemTextW(this.Handle, index, columnIndex, out string txt);
            return txt;
        }
        public void Clear()
        {
            ListViewMacros.ListView_DeleteAllItems(this.Handle);
        }
        

        public void SetExStyle(uint exStyle)
        {
            ListViewMacros.ListView_SetExtendedListViewStyle(this.Handle, exStyle);
        }

        public int InsertItem(ListViewItem item)
        {
            tagLVITEMW pItem = item.ToStruct();
            pItem.cchTextMax = pItem.pszText.Length;
            IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(tagLVITEMW)));
            Marshal.StructureToPtr(pItem, p, false);
            IntPtr result = User32.SendMessage(this.Handle, (int)ListViewMessageConst.LVM_INSERTITEMW, IntPtr.Zero, p);
            int r = result.ToInt32();
            Marshal.FreeHGlobal(p);
            return r;
            //return ListViewMacros.ListView_InsertItemW(this.Handle, tagLVITEMW);

        }

        public int GetItemCount()
        {
            IntPtr result = User32.SendMessage(this.Handle, ListViewMessageConst.LVM_GETITEMCOUNT, IntPtr.Zero, IntPtr.Zero);
            return result.ToInt32();
        }
        private static int Last_Item = 0;
        private static int Last_SubItem = 0;
        private static IntPtr Old_EditProc = IntPtr.Zero;
        private static IntPtr Last_EditControl = IntPtr.Zero;
        private static IntPtr EditProc(IntPtr hwnd, uint msg, IntPtr wparam, IntPtr lparam)
        {
            switch(msg)
            {
                case WindowsMessages.WM_KEYUP:
                    HighLow hl = Win32Api.MakeHiLo(wparam);
                    int vkKey = hl.iLow;
                    if(vkKey == VirtualKeys.VK_RETURN)
                    {
                        IntPtr parent = User32.GetParent(hwnd);
                        User32.SetFocus(parent);
                    }
                    break;
                case WindowsMessages.WM_KILLFOCUS:
                    if(wparam != IntPtr.Zero)
                    {
                        tagLVDISPINFOW dispInfo = new tagLVDISPINFOW();
                        IntPtr parent = User32.GetParent(hwnd);
                        uint parentId = (uint)User32.GetDlgCtrlID(parent);

                        dispInfo.hdr.hwndFrom = parent;
                        dispInfo.hdr.idFrom = parentId;
                        dispInfo.hdr.code = new IntPtr(ListViewNotifyConst.LVN_ENDLABELEDITW);
                        dispInfo.item.mask = ListViewItemMemberValidInfoConst.LVIF_TEXT;
                        dispInfo.item.iItem = Last_Item;
                        dispInfo.item.iSubItem = Last_SubItem;
                        string txt = User32.GetWindowTextRaw(hwnd);
                        dispInfo.item.pszText = txt;
                        dispInfo.item.cchTextMax = txt.Length;
                        using(var p = new ApiClassHandleRef<tagLVDISPINFOW>(dispInfo))
                        {
                            IntPtr pParent = User32.GetParent(parent);
                            User32.SendMessage(pParent, (int)WindowsMessages.WM_NOTIFY, (int)parentId, p);
                        }

                        User32.DestroyWindow(hwnd);
                        return IntPtr.Zero;
                    }
                    break;
            }
            return User32.CallWindowProc(Old_EditProc, hwnd, (int)msg, wparam, lparam);
        }
        
        protected override bool ControlProc(IntPtr hWndParent, IntPtr hWndControl, int controlId, uint command, IntPtr wParam, IntPtr lParam)
        {
            bool result = false;
            switch (command)
            {
                case ListViewNotifyConst.LVN_HOTTRACK:
                    try
                    {
                        tagNMLISTVIEW track = Marshal.PtrToStructure<tagNMLISTVIEW>(lParam);

                        
                        

                    }
                    catch 
                    {

                        break;
                    }
                    break;
                case NotifyMessageConst.NM_CLICK:
                    try
                    {
                        tagNMITEMACTIVATE track = Marshal.PtrToStructure<tagNMITEMACTIVATE>(lParam);

                    }
                    catch 
                    {

                        
                    }
                    OnClicked();
                    result = true; 
                    break;
                case NotifyMessageConst.NM_DBLCLK:
                    try
                    {
                        tagNMITEMACTIVATE track = Marshal.PtrToStructure<tagNMITEMACTIVATE>(lParam);
                        if(track.iItem > -1)
                        {

                            if(Last_EditControl != IntPtr.Zero)
                            {
                                User32.SendMessage(Last_EditControl, WindowsMessages.WM_KILLFOCUS, 0, 0);
                            }
                            
                            ListViewMacros.ListView_GetSubItemRect(this.Handle, track.iItem, track.iSubItem, ListViewItemRectConst.LVIR_BOUNDS, out Rect rect);
                            int height = rect.Height;
                            int width = rect.Width;
                            if(track.iSubItem == 0)
                            {
                                IntPtr header = User32.SendMessage(this.Handle, ListViewMessageConst.LVM_GETHEADER, 0, 0);
                                if(header != IntPtr.Zero)
                                {
                                    using(var p = new ApiStructHandleRef<Rect>())
                                    {
                                        var r = User32.SendMessage(header, (int)HDM_GETITEMRECT, 0, p);
                                        if((ApiBool)r.ToInt32())
                                        {
                                            var rr = p.GetStruct();
                                            width = rr.Width;
                                        }
                                    }
                                }
                                else
                                {
                                    width = width / 4;
                                }
                                
                            }

                            string txt = this.GetItemText(track.iItem, track.iSubItem);
                            Last_EditControl = User32.CreateWindowEx(0, "Edit", "", (uint)WindowStyles.WS_CHILD | (uint)WindowStyles.WS_VISIBLE | (uint)EditBoxStyles.ES_WANTRETURN | (uint)EditBoxStyles.ES_AUTOHSCROLL, rect.Left, rect.Top, width, height, this.Handle, IntPtr.Zero, Kernel32.GetModuleHandle(null), IntPtr.Zero);
                            User32.SetWindowText(Last_EditControl, txt);
                            User32.SetFocus(Last_EditControl);
                            User32.SendMessage(Last_EditControl, EditBoxMessages.EM_SETSEL, 0, -1);
                            Old_EditProc = User32.SetWindowLongPtr(Last_EditControl, GWL.GWL_WNDPROC, Marshal.GetFunctionPointerForDelegate((WndProc)EditProc));
                            Last_Item = track.iItem;
                            Last_SubItem = track.iSubItem;
                            result = true;
                        }
                    }
                    catch 
                    {

                        break;
                    }
                    OnDblClicked(); 
                    result = true;
                    break;
                case ListViewNotifyConst.LVN_BEGINLABELEDITW:
                    try
                    {
                        tagLVDISPINFOW track = Marshal.PtrToStructure<tagLVDISPINFOW>(lParam);

                    }
                    catch 
                    {

                     
                    }
                    ListViewMacros.ListView_CancelEditLabel(this.Handle);
                    result = true;
                    break;
                case ListViewNotifyConst.LVN_ENDLABELEDITW:
                    tagLVDISPINFOW dispInfo = default;
                    try 
                    {
                        dispInfo = Marshal.PtrToStructure<tagLVDISPINFOW>(lParam);

                    } 
                    catch { }
                    if(dispInfo != null)
                    {
                        if(dispInfo.item.pszText != null)
                        {
                            this.SetItemText(dispInfo.item.iItem, dispInfo.item.iSubItem, dispInfo.item.pszText);
                            result = true;
                            break;
                        }
                    }
                    result = false;
                    break;
                case ListViewNotifyConst.LVN_COLUMNCLICK:
                    OnClicked();
                    result = true;
                    break;
                    

            }
            return result;
        }
        public uint GetBkColor()
        {
            IntPtr result = User32.SendMessage(this.Handle, ListViewMessageConst.LVM_GETBKCOLOR ,IntPtr.Zero, IntPtr.Zero);
            return Win32Api.GetIntPtrUInt(result);
        }

        public void SetBkColor(uint color)
        {
            User32.SendMessage(this.Handle, ListViewMessageConst.LVM_SETBKCOLOR, 0, color);


        }

        public void SetOutlinedColor(uint color)
        {
            User32.SendMessage(this.Handle, ListViewMessageConst.LVM_SETOUTLINECOLOR, 0, color);    
        }

        

    }
}