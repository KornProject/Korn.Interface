using System.Collections.Generic;
using Korn.Shared.Internal;
using Newtonsoft.Json;
using System.IO;

namespace Korn.Interface.ServiceModule 
{
    public static class Libraries
    {
        public static readonly string
            LibrariesListFile = Path.Combine(Service.RootDirectory, "libraries.txt"),
            LibrariesDirectory = Path.Combine(Service.RootDirectory, "Libraries");

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
            "Korn.Utils.GithubExplorer",
            "Korn.Utils.Memory",
            "Korn.Utils.PDBResolver",
            "Korn.Utils.PEImageReader",
            "Korn.Utils.System",
            "Korn.Utils.VisualStudio",
            "Korn.Utils.WinForms"
        };
    }

    public class LibrariesList
    {
        public List<Library> Libraries;

        public string Serialize() => JsonConvert.SerializeObject(this, KornSharedInternal.JsonSettings);

        public static LibrariesList Deserialize(string path) => JsonConvert.DeserializeObject<LibrariesList>(path);

        public class Library
        {
            public string Name;
            public string CurrentEntrySha;
            public string LocalFilePath; // null if don't use local file
        }
    }
}
