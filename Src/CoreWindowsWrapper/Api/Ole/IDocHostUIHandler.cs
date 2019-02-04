using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [ComVisible(true)]
    [Guid("BD3F23C0-D43E-11CF-893B-00AA00BDCE1A")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    public interface IDocHostUIHandler
    {
      [MethodImpl(MethodImplOptions.PreserveSig)]
      [return: MarshalAs(UnmanagedType.I4)]
      int ShowContextMenu(
        [MarshalAs(UnmanagedType.U4), In] int dwID,
        [In] POINT pt,
        [MarshalAs(UnmanagedType.Interface), In] object pcmdtReserved,
        [MarshalAs(UnmanagedType.Interface), In] object pdispReserved);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      [return: MarshalAs(UnmanagedType.I4)]
      int GetHostInfo([In, Out] DOCHOSTUIINFO info);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      [return: MarshalAs(UnmanagedType.I4)]
      int ShowUI(
        [MarshalAs(UnmanagedType.I4), In] int dwID,
        [In] IOleInPlaceActiveObject activeObject,
        [In] IOleCommandTarget commandTarget,
        [In] IOleInPlaceFrame frame,
        [In] IOleInPlaceUIWindow doc);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      [return: MarshalAs(UnmanagedType.I4)]
      int HideUI();

      [MethodImpl(MethodImplOptions.PreserveSig)]
      [return: MarshalAs(UnmanagedType.I4)]
      int UpdateUI();

      [MethodImpl(MethodImplOptions.PreserveSig)]
      [return: MarshalAs(UnmanagedType.I4)]
      int EnableModeless([MarshalAs(UnmanagedType.Bool), In] bool fEnable);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      [return: MarshalAs(UnmanagedType.I4)]
      int OnDocWindowActivate([MarshalAs(UnmanagedType.Bool), In] bool fActivate);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      [return: MarshalAs(UnmanagedType.I4)]
      int OnFrameWindowActivate([MarshalAs(UnmanagedType.Bool), In] bool fActivate);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      [return: MarshalAs(UnmanagedType.I4)]
      int ResizeBorder(
        [In] RECT rect,
        [In] IOleInPlaceUIWindow doc,
        bool fFrameWindow);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      [return: MarshalAs(UnmanagedType.I4)]
      int TranslateAccelerator([In] ref MSG msg, [In] ref Guid group, [MarshalAs(UnmanagedType.I4), In] int nCmdID);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      [return: MarshalAs(UnmanagedType.I4)]
      int GetOptionKeyPath([MarshalAs(UnmanagedType.LPArray), Out] string[] pbstrKey, [MarshalAs(UnmanagedType.U4), In] int dw);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      [return: MarshalAs(UnmanagedType.I4)]
      int GetDropTarget(
        [MarshalAs(UnmanagedType.Interface), In] IOleDropTarget pDropTarget,
        [MarshalAs(UnmanagedType.Interface)] out IOleDropTarget ppDropTarget);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      [return: MarshalAs(UnmanagedType.I4)]
      int GetExternal([MarshalAs(UnmanagedType.Interface)] out object ppDispatch);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      [return: MarshalAs(UnmanagedType.I4)]
      int TranslateUrl([MarshalAs(UnmanagedType.U4), In] int dwTranslate, [MarshalAs(UnmanagedType.LPWStr), In] string strURLIn, [MarshalAs(UnmanagedType.LPWStr)] out string pstrURLOut);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      [return: MarshalAs(UnmanagedType.I4)]
      int FilterDataObject(System.Runtime.InteropServices.ComTypes.IDataObject pDO, out System.Runtime.InteropServices.ComTypes.IDataObject ppDORet);
    }

}
