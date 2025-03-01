using System.IO;

namespace Korn.Interface.ServiceModule
{
    public static class Service
    {
        public static readonly string
            RootDirectory = Path.Combine(KornDirectory.RootDirectory, "Service"),                
                BinDirectory = Path.Combine(RootDirectory, "bin"),
                    BinNet8Directory = Path.Combine(BinDirectory, "net8");

        public static readonly string[] Diretories = new string[] { RootDirectory, Libraries.LibrariesDirectory, Plugins.PluginsDirectory, BinDirectory, BinNet8Directory };
    }
}
