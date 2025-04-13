using System.Collections.Generic;

class DirectoryEnumeration
{
    public static IEnumerable<string> Enumerate(params string[][] directories)
    {
        foreach (var entry in directories)
            foreach (var directory in entry)
                yield return directory;
    }

    public static IEnumerable<string> Enumerate(string rootDirectory, params string[][] directories)
    {
        yield return rootDirectory;
        foreach (var entry in directories)
            foreach (var directory in entry)
                yield return directory;
    }
}