using Korn.Interface.ServiceModule;
using Korn.Shared.Internal;
using System.Collections.Generic;

namespace Korn.Interface 
{
    public static class KornDirectory
    {
        public static readonly string RootDirectory = KornSharedInternal.RootDirectory;

        public static IEnumerable<string> GetAllDirectories()
        {
            var entries = new string[][]
            {
                AutorunService.Diretories,
                Bootstrapper.Diretories,
                Service.Diretories,
                SharedData.Directories
            };

            yield return RootDirectory;
            foreach (var entry in entries)
                foreach (var directory in entry)
                    yield return directory;
        }
    }
}