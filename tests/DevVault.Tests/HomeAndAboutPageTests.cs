namespace DevVault.Tests;

public class HomeAndAboutPageTests : IClassFixture<WebAppFactory>
{
    private readonly WebAppFactory _factory;

    public HomeAndAboutPageTests(WebAppFactory factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task Root_route_renders_without_requesting_AppVersion_string_service()
    {
        var client = _factory.CreateClient();

        var response = await client.GetAsync("/");

        response.EnsureSuccessStatusCode();

        var html = await response.Content.ReadAsStringAsync();

        Assert.Contains("Home", html);
    }

    [Fact]
    public async Task About_route_renders_version_information()
    {
        var client = _factory.CreateClient();

        var response = await client.GetAsync("/about");

        response.EnsureSuccessStatusCode();

        var html = await response.Content.ReadAsStringAsync();

        Assert.Contains("Acerca de", html);
        Assert.Contains("Versión actual", html);
        Assert.Contains("Fecha de arranque", html);
    }
}
