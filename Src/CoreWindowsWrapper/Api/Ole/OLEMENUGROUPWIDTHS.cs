using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct OLEMENUGROUPWIDTHS
  {
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
    public int[] width;
  }
}
