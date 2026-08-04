using System.Reflection;

namespace DevVault.Web.Services;

public static class AppVersionProvider
{
    public static string GetCurrentVersion()
    {
        var assembly = Assembly.GetExecutingAssembly();

        var informationalVersion = assembly
            .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
            ?.InformationalVersion;

        if (!string.IsNullOrWhiteSpace(informationalVersion))
        {
            return NormalizeVersion(informationalVersion);
        }

        var assemblyNameVersion = assembly.GetName().Version?.ToString();
        return string.IsNullOrWhiteSpace(assemblyNameVersion)
            ? "0.0.0"
            : NormalizeVersion(assemblyNameVersion);
    }

    private static string NormalizeVersion(string version)
        => version.Split('+', 2)[0];
}
