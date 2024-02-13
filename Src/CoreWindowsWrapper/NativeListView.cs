using Diga.Core.Api.Win32;
using System;
using System.Collections.Generic;

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
            this.Style = LVS_REPORT | LVS_SINGLESEL | LVS_SHOWSELALWAYS | LVS_EDITLABELS | LVS_ALIGNLEFT | (uint)WindowStyles.WS_CHILD | (uint)WindowStyles.WS_VISIBLE | (uint)WindowStyles.WS_BORDER | (uint)WindowStyles.WS_TABSTOP;

        }
        protected override void AfterCreate()
        {

            base.AfterCreate();
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
            return ListViewMacros.ListView_InsertItemW(this.Handle, item);

        }

        public int GetItemCount()
        {
            IntPtr result = User32.SendMessage(this.Handle, ListViewMessageConst.LVM_GETITEMCOUNT, IntPtr.Zero, IntPtr.Zero);
            return result.ToInt32();
        }


    }
}