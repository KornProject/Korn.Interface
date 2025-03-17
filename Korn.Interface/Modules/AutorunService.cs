using Korn.Shared.Internal;
using System.IO;

namespace Korn.Interface
{
    public static class AutorunService
    {
        public static readonly string 
            RootDirectory = Path.Combine(KornDirectory.RootDirectory, "AutorunService"),
                VersionFile = Path.Combine(RootDirectory, "version.gittime"), 
                BinDirectory = Path.Combine(RootDirectory, "bin"),
                    BinNet472Diretory = Path.Combine(BinDirectory, KornSharedInternal.Net472TargetVersion),
                        ExecutableFile = Path.Combine(BinNet472Diretory, "Korn.AutorunService.exe");

        public static readonly string[] Diretories = new string[] { RootDirectory, BinDirectory, BinNet472Diretory };
    }
}