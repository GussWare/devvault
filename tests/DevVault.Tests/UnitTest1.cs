using DevVault.Web.Services;

namespace DevVault.Tests;

public class AppVersionProviderTests
{
    [Fact]
    public void GetCurrentVersion_returns_a_non_empty_version()
    {
        var version = AppVersionProvider.GetCurrentVersion();

        Assert.False(string.IsNullOrWhiteSpace(version));
    }
}
