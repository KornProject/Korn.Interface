using System.IO;

namespace Korn.Interface
{
    public static class Service
    {
        public static readonly string
            RootDirectory = Path.Combine(KornDirectory.RootDirectory, "Service"),
                PluginsListFile = Path.Combine(RootDirectory, "plugins.txt"),
                LibrariesDirectory = Path.Combine(RootDirectory, "Libraries"),
                PluginsDirectory = Path.Combine(RootDirectory, "Plugins"),
                BinDirectory = Path.Combine(RootDirectory, "bin"),
                    BinNet8Directory = Path.Combine(BinDirectory, ".net8");

        public static readonly string[] Diretories = new string[] { RootDirectory, LibrariesDirectory, PluginsDirectory, BinDirectory, BinNet8Directory };

        public static string GetDirectoryForPlugin(string name) => Path.Combine(RootDirectory, name);
    }
}
