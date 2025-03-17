using Korn.Shared.Internal;
using System.CodeDom;

namespace Korn.Interface.ServiceModule
{
    public static class Service
    {
        public const string ServiceProcessName = "Korn.Service";

        public const string
            RootDirectory = KornDirectory.RootDirectory + "\\" + "Service",
                VersionFile = RootDirectory + "\\" + "version.gittime",
                BinDirectory = RootDirectory + "\\" + "bin",
                    BinNet8Directory = BinDirectory + "\\" + KornSharedInternal.Net8TargetVersion,
                        ExecutableFile = BinNet8Directory + "\\" + ServiceProcessName + ".exe";


        public static readonly string[] Diretories = new string[] 
        { 
            RootDirectory, BinDirectory, BinNet8Directory,
            Libraries.LibrariesDirectory, Libraries.LibrariesNet8Directory, Libraries.LibrariesNet472Directory,
            Plugins.PluginsDirectory
        };
    }
}
