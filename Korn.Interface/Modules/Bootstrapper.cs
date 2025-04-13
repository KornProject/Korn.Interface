using Korn.Shared.Internal;

namespace Korn.Interface
{
    public static class Bootstrapper
    {
        public const string VersionableFileName = "Korn.Bootstrapper.exe";

        public const string
            RootDirectory = KornDirectory.RootDirectory + "\\" + "Bootstapper",
                LogFile = RootDirectory + "\\" + "log.txt",
                Net8VersionFile = RootDirectory + "\\" + "net8-version.sha",
                Net472VersionFile = RootDirectory + "\\" + "net472-version.sha",
                BinDirectory = RootDirectory + "\\" + "bin",
                    BinNet8Directory = BinDirectory + "\\" + KornSharedInternal.Net8TargetVersion,
                    BinNet472Directory = BinDirectory + "\\" + KornSharedInternal.Net472TargetVersion;


        public static readonly string[] Directories = new string[] { RootDirectory, BinDirectory, BinNet8Directory, BinNet472Directory };

        public static readonly GithubEntry GithubNet8Entry = new GithubEntry
        (
            "Binaries/Bootstrapper/" + KornSharedInternal.Net8TargetVersion,
            BinNet8Directory,
            Net8VersionFile,
            VersionableFileName
        );

        public static readonly GithubEntry GithubNet472Entry = new GithubEntry
        (
            "Binaries/Bootstrapper/" + KornSharedInternal.Net472TargetVersion,
            BinNet472Directory,
            Net472VersionFile,
            VersionableFileName
        );
    }
}