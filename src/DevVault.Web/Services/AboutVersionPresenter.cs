using System.Globalization;

namespace DevVault.Web.Services;

public static class AboutVersionPresenter
{
    public static AboutVersionViewModel Create(AppVersionInfo info)
    {
        if (!info.IsAvailable || string.IsNullOrWhiteSpace(info.Version))
        {
            return new AboutVersionViewModel(
                HasError: true,
                ErrorText: info.ErrorMessage ?? "No se pudo resolver la versión actual de DevVault.",
                VersionText: null,
                StartedAtText: FormatStartedAt(info.StartedAt));
        }

        return new AboutVersionViewModel(
            HasError: false,
            ErrorText: null,
            VersionText: info.Version,
            StartedAtText: FormatStartedAt(info.StartedAt));
    }

    private static string FormatStartedAt(DateTimeOffset startedAt)
        => startedAt.ToLocalTime().ToString("f", CultureInfo.CurrentCulture);
}
