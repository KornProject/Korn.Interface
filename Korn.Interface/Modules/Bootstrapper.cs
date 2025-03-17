using Korn.Shared.Internal;
using System.IO;
namespace Korn.Interface
{
    public static class Bootstrapper
    {
        public const string
            RootDirectory = KornDirectory.RootDirectory + "\\" + "Bootstapper",
                LogFile = RootDirectory + "\\" + "log.txt",
                Net8VersionFile = RootDirectory + "\\" + "net8-version.sha",
                Net472VersionFile = RootDirectory + "\\" + "net472-version.sha",
                BinDirectory = RootDirectory + "\\" + "bin",
                    BinNet8Directory = BinDirectory + "\\" + KornSharedInternal.Net8TargetVersion,
                    BinNet472Directory = BinDirectory + "\\" + KornSharedInternal.Net472TargetVersion;

        public static readonly string VersionableFileName = "Korn.Bootstrapper.dll";

        public static readonly string[] Diretories = new string[] { RootDirectory, BinDirectory, BinNet8Directory, BinNet472Directory };
    }
}