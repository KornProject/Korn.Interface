using Korn.Shared.Internal;

namespace Korn.Interface 
{
    public static class InjectorService
    {
        public const string ProcessName = "Korn.Services.Injector";
        public const string VersionableFileName = ProcessName + ".exe";

        public const string RootDirectory = Services.InjectorServiceDirectory,
            VersionFile = RootDirectory + "\\" + "version.gittime",
            LogFile = RootDirectory + "\\" + "log.txt",
            BinDirectory = RootDirectory + "\\" + "bin",
                BinNet8Directory = BinDirectory + "\\" + KornSharedInternal.Net8TargetVersion,
                    ExecutableFile = BinNet8Directory + "\\" + ProcessName + ".exe";

        public static readonly string[] Diretories = new string[] { RootDirectory, BinDirectory, BinNet8Directory };

        public static readonly GithubEntry GithubEntry = new GithubEntry
        (
            "Services.Injector",
            "Binaries/Services/Injector/" + KornSharedInternal.Net8TargetVersion,
            BinNet8Directory,
            VersionFile,
            VersionableFileName
        );

        public static readonly ServiceEntry ServiceEntry = new ServiceEntry(ExecutableFile, ProcessName);
    }
}