using System.IO;
namespace Korn.Interface
{
    public static class Bootstrapper
    {
        public static readonly string
            RootDirectory = Path.Combine(KornDirectory.RootDirectory, "Bootstapper"),
                LogFile = Path.Combine(RootDirectory, "log.txt"),
                BinDirectory = Path.Combine(RootDirectory, "bin"),
                    BinNet8Directory = Path.Combine(BinDirectory, "net8"),
                    BinNet472Directory = Path.Combine(BinDirectory, "net472");

        public static readonly string[] Diretories = new string[] { RootDirectory, BinDirectory, BinNet8Directory, BinNet472Directory };
    }
}