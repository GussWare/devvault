using System.Reflection;

namespace DevVault.Web.Services;

public static class AppVersionProvider
{
    private static readonly DateTimeOffset StartupTimeUtc = DateTimeOffset.UtcNow;

    public static AppVersionInfo GetCurrentVersionInfo()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var informationalVersion = assembly
            .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
            ?.InformationalVersion;
        var assemblyNameVersion = assembly.GetName().Version?.ToString();

        return CreateCurrentVersionInfo(informationalVersion, assemblyNameVersion);
    }

    internal static AppVersionInfo CreateCurrentVersionInfo(string? informationalVersion, string? assemblyNameVersion)
    {
        if (!string.IsNullOrWhiteSpace(informationalVersion))
        {
            return new AppVersionInfo(
                IsAvailable: true,
                Version: NormalizeVersion(informationalVersion),
                StartedAt: StartupTimeUtc,
                ErrorMessage: null);
        }

        if (!string.IsNullOrWhiteSpace(assemblyNameVersion))
        {
            return new AppVersionInfo(
                IsAvailable: true,
                Version: NormalizeVersion(assemblyNameVersion),
                StartedAt: StartupTimeUtc,
                ErrorMessage: null);
        }

        return new AppVersionInfo(
            IsAvailable: false,
            Version: null,
            StartedAt: StartupTimeUtc,
            ErrorMessage: "No se pudo resolver la versión actual de DevVault.");
    }

    private static string NormalizeVersion(string version)
        => version.Split('+', 2)[0];
}
