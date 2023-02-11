partial class Build
{
    const string InstallerProject = "Installer";

    public const string BuildConfiguration = "Release";
    public const string InstallerConfiguration = "Installer";

    const string AddInBinPrefix = "AddIn";
    const string ArtifactsFolder = "output";

    readonly string[] Projects =
    {
        "RevitLookup",
        "RevitLookup.UI"
    };

    readonly Dictionary<string, string> VersionMap = new()
    {
        {"Release R21", "2021.2.0"},
        {"Release R22", "2022.2.0"},
        {"Release R23", "2023.2.0"}
        {"Release R24", "2024.0.0"}
    };
}