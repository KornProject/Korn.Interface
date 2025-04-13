using System.Collections.Generic;
using Korn.Shared.Internal;
using Newtonsoft.Json;
using System.IO;

namespace Korn.Interface 
{
    public static class Libraries
    {
        public const string
            LibrariesListFile = InjectorService.RootDirectory + "\\" + "libraries.txt",
            LibrariesDirectory = InjectorService.RootDirectory + "\\" + "Libraries",
                LibrariesNet8Directory = LibrariesDirectory + "\\" + KornSharedInternal.Net8TargetVersion,
                LibrariesNet472Directory = LibrariesDirectory + "\\" + KornSharedInternal.Net472TargetVersion;

        public static LibrariesList DeserializeLibrariesList() => LibrariesList.Deserialize(File.ReadAllText(LibrariesListFile));
        public static bool HasLibrariesList() => File.Exists(LibrariesListFile);

        public static void Save(this LibrariesList self) => File.WriteAllText(LibrariesListFile, self.Serialize());

        public static readonly string[] DefaultLibraries = new string[]
        {
            "Korn.Hooking",
            "Korn.Interface",
            "Korn.Logger",
            "Korn.Plugins.Core",
            "Korn.Shared",
            "Korn.Shared.Internal",
            "Korn.Utils.Assembler",
            "Korn.Utils.Algorithms",
            "Korn.Utils.GithubExplorer",
            "Korn.Utils.Memory",
            "Korn.Utils.PDBResolver",
            "Korn.Utils.PEImageReader",
            "Korn.Utils.System",
            "Korn.Utils.VisualStudio",
            "Korn.Utils.WinForms"
        };

        public static readonly NugetPackage[] NugetPackages = new NugetPackage[]
        {
            new NugetPackage("Newtonsoft.Json", "net6.0"),
            new NugetPackage("Newtonsoft.Json.Bson", "net45")

        };
    }

    public class LibrariesList
    {
        public LibrariesList() => Libraries = new List<Library>();

        public List<Library> Libraries;

        public string Serialize() => JsonConvert.SerializeObject(this, KornSharedInternal.JsonSettings);

        public static LibrariesList Deserialize(string path) => JsonConvert.DeserializeObject<LibrariesList>(path);

        public class Library
        {
            public string Name;
            public string TargetVersion;
            public string Sha;
            public string LocalFilePath;
        }
    }

    public class NugetPackage
    {
        public NugetPackage(string name, string targetVersion) => (Name, TargetVersion) = (name, targetVersion);

        public string Name;
        public string TargetVersion;
    }
}
