namespace DevVault.Web.Services;

public sealed record AboutVersionViewModel(
    bool HasError,
    string? ErrorText,
    string? VersionText,
    string StartedAtText);
