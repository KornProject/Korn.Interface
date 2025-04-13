namespace Korn.Interface
{
    public class GithubEntry
    {
        public GithubEntry(string githubPath, string directoryPath, string versionFilePath, string versionableFileName)
            => (GithubPath, DirectoryPath, VersionFilePath, VersionableFileName) = (githubPath, directoryPath, versionFilePath, versionableFileName);

        public readonly string GithubPath, DirectoryPath, VersionFilePath, VersionableFileName;
    }
}
