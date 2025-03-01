using System.Collections.Generic;
using Korn.Shared.Internal;
using Newtonsoft.Json;
using System.IO;

namespace Korn.Interface.ServiceModule
{
    public static class Plugins
    {
        public static readonly string
            PluginsListFile = Path.Combine(Service.RootDirectory, "plugins.txt"),
            PluginsDirectory = Path.Combine(Service.RootDirectory, "Plugins");

        public const string PluginManifestFileName = "plugin.manifest";

        public static PluginDirectoryInfo GetDirectoryForPlugin(string name) => new PluginDirectoryInfo(Path.Combine(PluginsDirectory, name));
        public static PluginsList DeserializePluginsList() => PluginsList.Deserialize(File.ReadAllText(PluginsListFile));

        public static void Save(this PluginsList self) => File.WriteAllText(PluginsListFile, self.Serialize());
    }

    public class PluginDirectoryInfo
    {
        public PluginDirectoryInfo(string rootDirectory) => RootDirectory = rootDirectory;

        public readonly string RootDirectory;
        public string ManifestFilePath => Path.Combine(RootDirectory, Plugins.PluginManifestFileName);
        public string DataDirectory => Path.Combine(RootDirectory, "Data");
        public string BinariesDirectory => Path.Combine(RootDirectory, "bin");

        public PluginManifest DeserializeManifest() => PluginManifest.Deserialize(ManifestFilePath);

        public bool IsDirectoryExists => Directory.Exists(RootDirectory);
        public bool HasManifestFile => File.Exists(ManifestFilePath);
    }

    public class PluginManifest
    {
        public string Name;
        public string DisplayName;
        public string Version;
        public PluginAuthor[] Authors;
        public PluginTarget[] Targets;

        public bool IsValid() => 
            !(
                Name is null ||
                DisplayName is null ||
                Version is null ||
                Authors is null ||
                Authors.Length == 0 ||
                Targets is null ||
                Targets.Length == 0
            );

        public static PluginManifest Deserialize(string path) => JsonConvert.DeserializeObject<PluginManifest>(path);
    }

    public class PluginAuthor
    {
        public string Name;
        public string Github;
    }

    public class PluginTarget
    {
        public PluginFrameworkTarget TargetFramework;
        public string[] TargetProcesses;
        public string ExecutableFilePath;
        public string PluginClass;

        public string GetAbsoluteExecutableFilePath(PluginDirectoryInfo pluginDirectory)
            => ExecutableFilePath.Length > 1 && ExecutableFilePath[1] == ':' // if local path "?:\\?\?"
               ? ExecutableFilePath
               : Path.Combine(pluginDirectory.BinariesDirectory, ExecutableFilePath); // then relative path to plugin\bin
    }

    public enum PluginFrameworkTarget
    {
        Net472,
        Net8
    }

    public class PluginsList
    {
        public List<GithubPlugin> OfficialPlugins;
        public List<LocalPlugin> LocalPlugins;

        public string Serialize() => JsonConvert.SerializeObject(this, KornSharedInternal.JsonSettings); 

        public static PluginsList Deserialize(string path) => JsonConvert.DeserializeObject<PluginsList>(path);

        public class GithubPlugin
        {
            public string Name;
            public string GithubRepository;
        }

        public class LocalPlugin
        {
            public string Name;
        }
    }
}