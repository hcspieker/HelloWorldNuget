using System.Reflection;

namespace SimpleClassLibrary
{
    public class ExampleClass
    {
        public static string Version => Assembly.GetExecutingAssembly().GetName().Version!.ToString();
    }
}
