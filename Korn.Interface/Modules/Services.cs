using System.Collections.Generic;

namespace Korn.Interface 
{
    public static class Services
    {
        public const string RootDirectory = ServiceHub.ServicesDirectory,
            InjectorServiceDirectory = RootDirectory + "\\" + "Injector",
            LoggerServiceDirectory = RootDirectory + "\\" + "Logger";

        public static readonly string[] Directories = new string[] { RootDirectory, InjectorServiceDirectory, LoggerServiceDirectory };

        public static readonly string[] Processes = new string[] { InjectorService.ProcessName, LoggerService.ProcessName };

        public static IEnumerable<string> GetAllDirectories() => DirectoryEnumeration.Enumerate(RootDirectory, Directories, InjectorService.Diretories, LoggerService.Diretories);
    }
}