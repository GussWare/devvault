namespace DevVault.Tests;

public class HomePageTests : IClassFixture<WebAppFactory>
{
    private readonly WebAppFactory _factory;

    public HomePageTests(WebAppFactory factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task Root_route_renders_successfully()
    {
        var client = _factory.CreateClient();

        var response = await client.GetAsync("/");

        response.EnsureSuccessStatusCode();
    }
}
