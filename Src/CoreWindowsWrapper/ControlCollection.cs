using System.Collections.Generic;

namespace CoreWindowsWrapper
{
    public class ControlCollection : Dictionary<int, IControl>
    {
        public void Add(IControl contorl)
        {
            base.Add(contorl.ControlId , contorl);
        }
    }
}