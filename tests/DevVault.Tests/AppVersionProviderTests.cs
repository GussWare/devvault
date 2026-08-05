using DevVault.Web.Services;

namespace DevVault.Tests;

public class AppVersionProviderTests
{
    [Fact]
    public void GetCurrentVersionInfo_returns_version_and_start_time()
    {
        var info = AppVersionProvider.GetCurrentVersionInfo();
        var secondRead = AppVersionProvider.GetCurrentVersionInfo();

        Assert.False(string.IsNullOrWhiteSpace(info.Version));
        Assert.Equal(info.StartedAt, secondRead.StartedAt);
        Assert.True(info.IsAvailable);
        Assert.Null(info.ErrorMessage);
    }

    [Fact]
    public void CreateCurrentVersionInfo_returns_explicit_error_when_version_metadata_is_missing()
    {
        var info = AppVersionProvider.CreateCurrentVersionInfo(
            informationalVersion: null,
            assemblyNameVersion: null);

        Assert.False(info.IsAvailable);
        Assert.Null(info.Version);
        Assert.Equal("No se pudo resolver la versión actual de DevVault.", info.ErrorMessage);
    }
}
