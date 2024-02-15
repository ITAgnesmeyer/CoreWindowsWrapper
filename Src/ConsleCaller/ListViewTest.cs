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
            this.Text = "List View Test";
            this.BackColor = ColorTool.White;
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
                Height = 100,
                Font = new Font { Size = 10}

            };

            this.Controls.Add(this._Button);
            this.Controls.Add(this._ListView);
        }
        
        protected override void OnCreate(CreateEventArgs e)
        {
            base.OnCreate(e);
            Diga.Core.Api.Win32.Rect rect = this.GetClientRect();
            this._ListView.Width = rect.Width;
            this._ListView.Height = rect.Height - 50;
            
            //(uint)ListViewStylesEx.LVS_EX_BORDERSELECT |
            this._ListView.SetExStyle( (uint)ListViewStylesEx.LVS_EX_FULLROWSELECT |
                                               (uint)ListViewStylesEx.LVS_EX_DOUBLEBUFFER |
                                               (uint)ListViewStylesEx.LVS_EX_HEADERDRAGDROP| (uint)ListViewStylesEx.LVS_EX_GRIDLINES  );
            for (int i = 0;i<100;i++)
            {
                this._ListView.InsertColumn(new ListViewColumn { SubItemIndex = i, Text = $"Column{i}" });

            }
            this._ListView.SetBkColor((uint)ColorTool.Rgb(240, 240, 240));//Schnelltaste: Alt+X
            this._ListView.SetOutlinedColor((uint)ColorTool.Rgb(0,240,240));
            //this._ListView.InsertColumn(new ListViewColumn { SubItemIndex = 0, Text = "Column1" });
            //this._ListView.InsertColumn(new ListViewColumn { SubItemIndex = 1, Text = "Column2" });
            //this._ListView.InsertColumn(new ListViewColumn { SubItemIndex = 2, Text = "Column3" });


        }

        protected override void OnSize(SizeEventArgs e)
        {
            base.OnSize(e);
            this._ListView.Width = e.Width;
            this._ListView.Height = e.Height - 40;
        }
        private void OnButtonClicked(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 10; i++)
            {
                int anz = this._ListView.GetItemCount()+1;
                int index = this._ListView.InsertItem(new ListViewItem { ItemIndex = anz, Text = "Value1" });
               
                for (int j = 1; j < 101; j++)
                {
                    this._ListView.SetItemText(index, j, $"Value{j}-{anz}" );
                }
               
            }
            //this._ListView.SetBkColor((uint)ColorTool.LightGray);
            //this._ListView.SetItemText(index, 1, "Value2-"+ index.ToString());
            //this._ListView.SetItemText(index, 2, "value3" + index.ToString());
        }
    }
}
