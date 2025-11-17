using System.Reflection;

namespace SimpleClassLibrary
{
    public class ExampleClass
    {
        public static string Version => 
            Assembly.GetExecutingAssembly().GetName().Version!.ToString();

        public static string FileVersion => 
            Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version ?? "UNKOWN";

        public static string InformationalVersion => 
            Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion ?? "UNKOWN";

        public static string AllVersions => 
            $"Version: {Version}, File Version: {FileVersion}, Informational Version: {InformationalVersion}";
    }
}
