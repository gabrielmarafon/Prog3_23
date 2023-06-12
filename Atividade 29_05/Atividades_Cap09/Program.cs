using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

namespace WorkingWithFileSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            // Seu códiSectionTitle("* Handling cross-platform environments and
            filesystems");
            WriteLine("{0,-33} {1}", arg0: "Path.PathSeparator",
            arg1: PathSeparator);
            WriteLine("{0,-33} {1}", arg0: "Path.DirectorySeparatorChar",
            arg1: DirectorySeparatorChar);
            WriteLine("{0,-33} {1}", arg0: "Directory.GetCurrentDirectory()",
            arg1: GetCurrentDirectory());
            WriteLine("{0,-33} {1}", arg0: "Environment.CurrentDirectory",
            arg1: CurrentDirectory);
            WriteLine("{0,-33} {1}", arg0: "Environment.SystemDirectory",
            arg1: SystemDirectory);
            WriteLine("{0,-33} {1}", arg0: "Path.GetTempPath()",
            arg1: GetTempPath());
            WriteLine("GetFolderPath(SpecialFolder");
            WriteLine("{0,-33} {1}", arg0: " .System)",
            arg1: GetFolderPath(SpecialFolder.System));
            WriteLine("{0,-33} {1}", arg0: " .ApplicationData)",
            Chapter 9 397
            arg1: GetFolderPath(SpecialFolder.ApplicationData));
            WriteLine("{0,-33} {1}", arg0: " .MyDocuments)",
            arg1: GetFolderPath(SpecialFolder.MyDocuments));
            WriteLine("{0,-33} {1}", arg0: " .Personal)",
            arg1: GetFolderPath(SpecialFolder.Personal)); go aqui
        }
    }

    // Arquivo de classe Program.Helpers.cs
    public static class Helpers
    {
        // Métodos e funcionalidades auxiliares podem ser definidos aqui
    }
}