using DevVault.Web.Services;

namespace DevVault.Tests;

public class AboutVersionPresenterTests
{
    [Fact]
    public void Create_when_version_is_available_builds_display_model()
    {
        var info = new AppVersionInfo(
            IsAvailable: true,
            Version: "0.1.0",
            StartedAt: new DateTimeOffset(2026, 8, 5, 12, 0, 0, TimeSpan.Zero),
            ErrorMessage: null);

        var model = AboutVersionPresenter.Create(info);

        Assert.Equal("0.1.0", model.VersionText);
        Assert.Contains("2026", model.StartedAtText);
        Assert.False(model.HasError);
        Assert.Null(model.ErrorText);
    }

    [Fact]
    public void Create_when_version_is_unavailable_exposes_error_state()
    {
        var info = new AppVersionInfo(
            IsAvailable: false,
            Version: null,
            StartedAt: new DateTimeOffset(2026, 8, 5, 12, 0, 0, TimeSpan.Zero),
            ErrorMessage: "No se pudo resolver la versión actual de DevVault.");

        var model = AboutVersionPresenter.Create(info);

        Assert.True(model.HasError);
        Assert.Equal("No se pudo resolver la versión actual de DevVault.", model.ErrorText);
    }
}
