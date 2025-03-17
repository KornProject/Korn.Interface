using Korn.Interface.ServiceModule;
using Korn.Shared.Internal;
using System.Collections.Generic;

namespace Korn.Interface 
{
    public static class KornDirectory
    {
        public const string RootDirectory = KornSharedInternal.RootDirectory,
            LogFile = RootDirectory + "\\" + "log.txt";

        public static IEnumerable<string> GetAllDirectories()
        {
            var entries = new string[][]
            {
                Service.Diretories,
                AutorunService.Diretories,
                Bootstrapper.Diretories,
            };

            yield return RootDirectory;
            foreach (var entry in entries)
                foreach (var directory in entry)
                    yield return directory;
        }
    }
}