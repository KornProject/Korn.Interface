using Korn.Shared.Internal;
using System.Collections.Generic;

namespace Korn.Interface 
{
    public static class KornDirectory
    {
        public const string RootDirectory = KornSharedInternal.RootDirectory,
            LogFile = RootDirectory + "\\" + "log.txt";

        public static IEnumerable<string> GetAllDirectories() => DirectoryEnumeration.Enumerate(RootDirectory, ServiceHub.Directories, Bootstrapper.Directories);
    }
}