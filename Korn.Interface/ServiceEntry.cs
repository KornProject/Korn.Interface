namespace Korn.Interface 
{
    public class ServiceEntry
    {
        public ServiceEntry(string executableFilePath, string processName) => (ExecutableFilePath, ProcessName) = (executableFilePath, processName);

        public readonly string ExecutableFilePath, ProcessName;
    }
}