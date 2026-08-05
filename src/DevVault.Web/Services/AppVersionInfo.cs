namespace DevVault.Web.Services;

public sealed record AppVersionInfo(
    bool IsAvailable,
    string? Version,
    DateTimeOffset StartedAt,
    string? ErrorMessage);
