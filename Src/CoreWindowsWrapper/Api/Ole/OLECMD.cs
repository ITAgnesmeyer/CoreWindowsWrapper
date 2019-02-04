using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public class OLECMD
    {
      [MarshalAs(UnmanagedType.U4)]
      public int cmdID;
      [MarshalAs(UnmanagedType.U4)]
      public int cmdf;
    }

}
