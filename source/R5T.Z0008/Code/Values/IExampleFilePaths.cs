using System;

using R5T.T0131;


namespace R5T.Z0008
{
	[ValuesMarker]
	public partial interface IExampleFilePaths : IValuesMarker
	{
        public string ExampleConsoleProject => FilePathOperator.Instance.GetFilesDirectoryFilePath("ExampleConsole.csproj");
        public string ExampleConsoleProject_WithZ0008ProjectReference => FilePathOperator.Instance.GetFilesDirectoryFilePath("ExampleConsole-With Z0008.csproj");
        public string ExampleLibraryProject => FilePathOperator.Instance.GetFilesDirectoryFilePath("ExampleLibrary.csproj");
        public string ExampleOldStyleConsoleProject => FilePathOperator.Instance.GetFilesDirectoryFilePath("ExampleOldStyle.csproj");
        public string ExampleSolution => FilePathOperator.Instance.GetFilesDirectoryFilePath("ExampleSolution.sln");
        /// <summary>
        /// Contains two package references.
        /// </summary>
        public string ExampleTestProject => FilePathOperator.Instance.GetFilesDirectoryFilePath("ExampleTest.csproj");
        public string ExampleWithCOMReferenceProject => FilePathOperator.Instance.GetFilesDirectoryFilePath("ExampleCOMReference.csproj");
    }
}