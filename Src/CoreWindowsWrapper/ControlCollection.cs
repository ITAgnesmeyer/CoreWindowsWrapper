using System.Collections.Generic;

namespace CoreWindowsWrapper
{
    public class ControlCollection : Dictionary<int, NativeControlBase>
    {
        public void Add(NativeControlBase contorl)
        {
            IControl ctrl = contorl;
            if(ctrl.ControlId == 0)
            {
                Win32ApiForm.Win32Control.LastControlId+=1;
                ctrl.ControlId = Win32ApiForm.Win32Control.LastControlId;
            }
            base.Add(ctrl.ControlId , contorl);
        }
    }
}