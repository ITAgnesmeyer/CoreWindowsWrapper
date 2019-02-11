namespace CoreWindowsWrapper.Api.Ole
{
    public enum tagFUNCKIND
    {
        /// FUNC_VIRTUAL -> 0
        FUNC_VIRTUAL = 0,

        /// FUNC_PUREVIRTUAL -> FUNC_VIRTUAL+1
        FUNC_PUREVIRTUAL = (FUNC_VIRTUAL + 1),

        /// FUNC_NONVIRTUAL -> FUNC_PUREVIRTUAL+1
        FUNC_NONVIRTUAL = (FUNC_PUREVIRTUAL + 1),

        /// FUNC_STATIC -> FUNC_NONVIRTUAL+1
        FUNC_STATIC = (FUNC_NONVIRTUAL + 1),

        /// FUNC_DISPATCH -> FUNC_STATIC+1
        FUNC_DISPATCH = (FUNC_STATIC + 1),
    }
}