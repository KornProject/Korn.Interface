using System.IO;

namespace Korn.Interface
{
    public static class SharedData
    {
        public static readonly string 
            RootDirectory = Path.Combine(KornDirectory.RootDirectory, "SharedData"),
            LogFile = Path.Combine(RootDirectory, "log.txt");

        public static readonly string[] Directories = new string[] { RootDirectory };
    }
}