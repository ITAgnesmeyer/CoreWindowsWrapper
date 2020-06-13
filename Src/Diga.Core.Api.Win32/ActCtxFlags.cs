// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Local

namespace Diga.Core.Api.Win32
{
    public static class ActCtxFlags
    {

        public const uint ACTCTX_FLAG_PROCESSOR_ARCHITECTURE_VALID = 0x001;
        public const uint ACTCTX_FLAG_LANGID_VALID = 0x002;
        public const uint ACTCTX_FLAG_ASSEMBLY_DIRECTORY_VALID = 0x004;
        public const uint ACTCTX_FLAG_RESOURCE_NAME_VALID = 0x008;
        public const uint ACTCTX_FLAG_SET_PROCESS_DEFAULT = 0x010;
        public const uint ACTCTX_FLAG_APPLICATION_NAME_VALID = 0x020;
        public const uint ACTCTX_FLAG_HMODULE_VALID = 0x080;
        public const uint RT_MANIFEST = 24;
        public const uint CREATEPROCESS_MANIFEST_RESOURCE_ID = 1;
        public const uint ISOLATIONAWARE_MANIFEST_RESOURCE_ID = 2;
        public const uint ISOLATIONAWARE_NOSTATICIMPORT_MANIFEST_RESOURCE_ID = 3;
    }
}


