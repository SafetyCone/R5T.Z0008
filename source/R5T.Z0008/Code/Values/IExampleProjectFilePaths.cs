using System;
using System.IO;

using R5T.Magyar;

using R5T.T0131;


namespace R5T.Z0008
{
	[ValuesMarker]
	public partial interface IExampleProjectFilePaths : IValuesMarker
	{
        public string ExampleConsole()
        {
            var executableDirectoryPath = this.GetExecutableDirectoryPath();

            var output = executableDirectoryPath + @"\Files\ExampleConsole.csproj";
            return output;
        }

        public string ExampleLibrary()
        {
            var executableDirectoryPath = this.GetExecutableDirectoryPath();

            var output = executableDirectoryPath + @"\Files\ExampleLibrary.csproj";
            return output;
        }

        public string ExampleTest()
        {
            var executableDirectoryPath = this.GetExecutableDirectoryPath();

            var output = executableDirectoryPath + @"\Files\ExampleTest.csproj";
            return output;
        }

        public string GetExecutableDirectoryPath()
        {
            var executableFilePath = ExecutableFilePathHelper.GetExecutableFilePath();

            var output = new FileInfo(executableFilePath).DirectoryName;
            return output;
        }
    }
}