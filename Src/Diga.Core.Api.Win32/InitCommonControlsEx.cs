using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo

namespace Diga.Core.Api.Win32
{
    
    [StructLayout(LayoutKind.Sequential)]
    public struct InitCommonControlsEx
    {
        // ReSharper disable once PrivateFieldCanBeConvertedToLocalVariable
        private int dwSize;
        public uint dwICC;

        //public INITCOMMONCONTROLSEX()
        //{
        //    this.dwSize = Marshal.SizeOf(typeof(INITCOMMONCONTROLSEX));
        //    this.dwICC = 0;
        //}
        public InitCommonControlsEx(uint dwICC)
            : this()
        {
            this.dwSize = Marshal.SizeOf(typeof(InitCommonControlsEx));
            this.dwICC = dwICC;
        }

        public InitCommonControlsEx(CommonControls ICC)
            : this((uint) ICC)
        {
        }

        public CommonControls ICC
        {
            get => (CommonControls) this.dwICC;
            set => this.dwICC = (uint) value;
        }
    }
}