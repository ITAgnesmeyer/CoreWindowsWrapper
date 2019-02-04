using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [InterfaceType(1)]
  [Guid("0000000F-0000-0000-C000-000000000046")]
  [ComImport]
  public interface IMoniker : IPersistStream
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int GetClassID(out Guid pClassID);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int IsDirty();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void Load([MarshalAs(UnmanagedType.Interface), In] IStream pstm);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void Save([MarshalAs(UnmanagedType.Interface), In] IStream pstm, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL"), In] int fClearDirty);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void GetSizeMax([ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULARGE_INTEGER"), MarshalAs(UnmanagedType.LPArray), Out] ULARGE_INTEGER[] pcbSize);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void BindToObject([MarshalAs(UnmanagedType.Interface), In] IBindCtx pbc, [MarshalAs(UnmanagedType.Interface), In] IMoniker pmkToLeft, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.REFIID"), In] ref Guid riidResult, [MarshalAs(UnmanagedType.IUnknown)] out object ppvResult);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void BindToStorage([MarshalAs(UnmanagedType.Interface), In] IBindCtx pbc, [MarshalAs(UnmanagedType.Interface), In] IMoniker pmkToLeft, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.REFIID"), In] ref Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppvObj);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Reduce(
      [MarshalAs(UnmanagedType.Interface), In] IBindCtx pbc,
      [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint dwReduceHowFar,
      [MarshalAs(UnmanagedType.Interface), In, Out] ref IMoniker ppmkToLeft,
      [MarshalAs(UnmanagedType.Interface)] out IMoniker ppmkReduced);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ComposeWith([MarshalAs(UnmanagedType.Interface), In] IMoniker pmkRight, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL"), In] int fOnlyIfNotGeneric, [MarshalAs(UnmanagedType.Interface)] out IMoniker ppmkComposite);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Enum([ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL"), In] int fForward, [MarshalAs(UnmanagedType.Interface)] out IEnumMoniker ppenumMoniker);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void IsEqual([MarshalAs(UnmanagedType.Interface), In] IMoniker pmkOtherMoniker);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Hash([ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")] out uint pdwHash);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int IsRunning([MarshalAs(UnmanagedType.Interface), In] IBindCtx pbc, [MarshalAs(UnmanagedType.Interface), In] IMoniker pmkToLeft, [MarshalAs(UnmanagedType.Interface), In] IMoniker pmkNewlyRunning);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetTimeOfLastChange([MarshalAs(UnmanagedType.Interface), In] IBindCtx pbc, [MarshalAs(UnmanagedType.Interface), In] IMoniker pmkToLeft, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.FILETIME"), MarshalAs(UnmanagedType.LPArray), Out] FILETIME[] pFileTime);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Inverse([MarshalAs(UnmanagedType.Interface)] out IMoniker ppmk);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CommonPrefixWith([MarshalAs(UnmanagedType.Interface), In] IMoniker pmkOther, [MarshalAs(UnmanagedType.Interface)] out IMoniker ppmkPrefix);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RelativePathTo([MarshalAs(UnmanagedType.Interface), In] IMoniker pmkOther, [MarshalAs(UnmanagedType.Interface)] out IMoniker ppmkRelPath);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetDisplayName([MarshalAs(UnmanagedType.Interface), In] IBindCtx pbc, [MarshalAs(UnmanagedType.Interface), In] IMoniker pmkToLeft, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPOLESTR"), MarshalAs(UnmanagedType.LPWStr)] out string ppszDisplayName);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ParseDisplayName(
      [MarshalAs(UnmanagedType.Interface), In] IBindCtx pbc,
      [MarshalAs(UnmanagedType.Interface), In] IMoniker pmkToLeft,
      [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPOLESTR"), MarshalAs(UnmanagedType.LPWStr), In] string pszDisplayName,
      [ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG")] out uint pchEaten,
      [MarshalAs(UnmanagedType.Interface)] out IMoniker ppmkOut);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void IsSystemMoniker([ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")] out uint pdwMksys);
  }

}
