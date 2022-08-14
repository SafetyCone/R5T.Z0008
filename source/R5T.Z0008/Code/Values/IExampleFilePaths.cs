using System;
using System.IO;

using R5T.Magyar;

using R5T.T0131;


namespace R5T.Z0008
{
	[ValuesMarker]
	public partial interface IExampleFilePaths : IValuesMarker
	{
        public string ExampleConsole
        {
            get
            {
                var executableDirectoryPath = this.GetExecutableDirectoryPath;

                var output = executableDirectoryPath + @"\Files\ExampleConsole.csproj";
                return output;
            }
        }

        public string ExampleConsole_WithF0020ProjectReference
        {
            get
            {
                var executableDirectoryPath = this.GetExecutableDirectoryPath;

                var output = executableDirectoryPath + @"\Files\ExampleConsole-With Z0008.csproj";
                return output;
            }
        }

        public string ExampleLibrary
        {
            get
            {
                var executableDirectoryPath = this.GetExecutableDirectoryPath;

                var output = executableDirectoryPath + @"\Files\ExampleLibrary.csproj";
                return output;
            }
        }

        public string ExampleSolution
        {
            get
            {
                var executableDirectoryPath = this.GetExecutableDirectoryPath;

                var output = executableDirectoryPath + @"\Files\ExampleSolution.sln";
                return output;
            }
        }

        public string ExampleTest
        {
            get
            {
                var executableDirectoryPath = this.GetExecutableDirectoryPath;

                var output = executableDirectoryPath + @"\Files\ExampleTest.csproj";
                return output;
            }
        }

        public string GetExecutableDirectoryPath
        {
            get
            {
                var executableFilePath = ExecutableFilePathHelper.GetExecutableFilePath();

                var output = new FileInfo(executableFilePath).DirectoryName;
                return output;
            }
        }
    }
}