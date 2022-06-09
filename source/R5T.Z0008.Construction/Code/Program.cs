using System;


namespace R5T.Z0008.Construction
{
    static class Program
    {
        static void Main()
        {
            //Program.ExampleConsoleProjectFilePath();
            //Program.ExampleLibraryProjectFilePath();
            Program.ExampleTestProjectFilePath();
        }

#pragma warning disable IDE0051 // Remove unused private members

        static void ExampleConsoleProjectFilePath()
        {
            var projectFilePath = Instances.ExampleProjectFilePaths.ExampleConsole();

            Console.WriteLine(projectFilePath);
        }

        static void ExampleLibraryProjectFilePath()
        {
            var projectFilePath = Instances.ExampleProjectFilePaths.ExampleLibrary();

            Console.WriteLine(projectFilePath);
        }

        static void ExampleTestProjectFilePath()
        {
            var projectFilePath = Instances.ExampleProjectFilePaths.ExampleTest();

            Console.WriteLine(projectFilePath);
        }
    }
}