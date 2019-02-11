using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct INPUT_RECORD
    {
        /// WORD->unsigned short
        public ushort EventType;

        /// Anonymous_79fe9041_6876_475e_b93a_ffb0d7822836
        public Anonymous_79fe9041_6876_475e_b93a_ffb0d7822836 Event;
    }
}