using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo

namespace CoreWindowsWrapper.Api.Win32
{
    /// <inheritdoc />
    [StructLayout(LayoutKind.Sequential)]
    public struct INITCOMMONCONTROLSEX
    {
        // ReSharper disable once PrivateFieldCanBeConvertedToLocalVariable
        private int dwSize;
        public uint dwICC;

        //public INITCOMMONCONTROLSEX()
        //{
        //    this.dwSize = Marshal.SizeOf(typeof(INITCOMMONCONTROLSEX));
        //    this.dwICC = 0;
        //}
        public INITCOMMONCONTROLSEX(uint dwICC)
            : this()
        {
            this.dwSize = Marshal.SizeOf(typeof(INITCOMMONCONTROLSEX));
            this.dwICC = dwICC;
        }

        public INITCOMMONCONTROLSEX(CommonControls ICC)
            : this((uint)ICC)
        { }

        public CommonControls ICC
        {
            get => (CommonControls)this.dwICC;
            set => this.dwICC = (uint)value;
        }
    }
}