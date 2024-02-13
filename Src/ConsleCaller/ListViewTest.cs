using System;
using CoreWindowsWrapper;
using CoreWindowsWrapper.Tools;
using Diga.Core.Api.Win32;

namespace ConsoleCaller
{
    class ListViewTest : NativeWindow
    {
        private NativeButton _Button;
        private NativeListView _ListView;
        protected override void InitControls()
        {
            this._Button = new NativeButton
            {
                Left = 0,
                Top = 0,
                Height = 30,
                Width = 255,
                Text = "Run"
            };
            this._Button.Clicked += OnButtonClicked;

            this._ListView = new NativeListView
            {
                Left = 0,
                Top = 40,
                Width = 100,
                Height = 100

            };

            this.Controls.Add(this._Button);
            this.Controls.Add(this._ListView);
        }
        protected override void OnCreate(CreateEventArgs e)
        {
            base.OnCreate(e);
            Diga.Core.Api.Win32.Rect rect = this.GetClientRect();
            this._ListView.Width = rect.Width;
            this._ListView.Height = rect.Height - 40;
            this._ListView.SetExStyle(((uint)ListViewStylesEx.LVS_EX_FULLROWSELECT |
                                               (uint)ListViewStylesEx.LVS_EX_DOUBLEBUFFER |
                                               (uint)ListViewStylesEx.LVS_EX_GRIDLINES));
            this._ListView.InsertColumn(new ListViewColumn { SubItemIndex = 0, Text = "Column1" });
            this._ListView.InsertColumn(new ListViewColumn { SubItemIndex = 1, Text = "Column2" });
            this._ListView.InsertColumn(new ListViewColumn { SubItemIndex = 2, Text = "Column3" });


        }

        protected override void OnSize(SizeEventArgs e)
        {
            base.OnSize(e);
            this._ListView.Width = e.Width;
            this._ListView.Height = e.Height - 40;
        }
        private void OnButtonClicked(object sender, EventArgs e)
        {
            int anz = this._ListView.GetItemCount();
            int index = this._ListView.InsertItem(new ListViewItem { ItemIndex = anz,Text = "Value1" });
            this._ListView.SetItemText(index, 1, "Value2-"+ index.ToString());
            this._ListView.SetItemText(index, 2, "value3" + index.ToString());
        }
    }
}
