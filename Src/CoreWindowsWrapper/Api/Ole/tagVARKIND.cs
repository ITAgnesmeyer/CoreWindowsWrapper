namespace CoreWindowsWrapper.Api.Ole
{
    public enum tagVARKIND
    {
        /// VAR_PERINSTANCE -> 0
        VAR_PERINSTANCE = 0,

        /// VAR_STATIC -> VAR_PERINSTANCE+1
        VAR_STATIC = (VAR_PERINSTANCE + 1),

        /// VAR_CONST -> VAR_STATIC+1
        VAR_CONST = (VAR_STATIC + 1),

        /// VAR_DISPATCH -> VAR_CONST+1
        VAR_DISPATCH = (VAR_CONST + 1),
    }
}