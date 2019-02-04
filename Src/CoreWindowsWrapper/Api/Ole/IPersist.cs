using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [InterfaceType(1)]
  [Guid("0000010C-0000-0000-C000-000000000046")]
  [ComImport]
  public interface IPersist
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int GetClassID(out Guid pClassID);
  }

}
