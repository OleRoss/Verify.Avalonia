public static class ModuleInit
{
    #region EnableDisableImageGeneration

    [ModuleInitializer]
    public static void Init()
    {
        VerifyAvalonia.DisableImageGeneration();
        VerifierSettings.InitializePlugins();
    }

    #endregion
}