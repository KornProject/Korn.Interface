namespace Korn.Interface
{
    public class GithubEntry
    {
        public GithubEntry(string name, string githubPath, string directoryPath, string versionFilePath, string versionableFileName)
            => (Name, GithubPath, DirectoryPath, VersionFilePath, VersionableFileName) = (name, githubPath, directoryPath, versionFilePath, versionableFileName);

        public readonly string Name, GithubPath, DirectoryPath, VersionFilePath, VersionableFileName;
    }
}
