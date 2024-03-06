using Diga.Core.Api.Win32;
using System;
using System.Collections.Generic;

namespace CoreWindowsWrapper
{

    public class NativeContainerControl : NativeNoCreateControlBase
    {
        protected override void Initialize()
        {
            base.Initialize();

        }

        public override bool Create(IntPtr parentHandle)
        {

            return base.Create(parentHandle);

            //foreach (KeyValuePair<int, IControl> control in this.Controls)
            //{
            //    control.Value
            //}
        }
    }
}