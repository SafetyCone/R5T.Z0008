using System;

using R5T.T0131;


namespace R5T.Z0008
{
	[ValuesMarker]
	public partial interface IExampleProjectFilePaths : IValuesMarker
	{
		public string Console => ExampleFilePaths.Instance.ExampleConsoleProject;
		public string Library => ExampleFilePaths.Instance.ExampleLibraryProject;
		public string OldStyleConsole => ExampleFilePaths.Instance.ExampleOldStyleConsoleProject;
		public string Test => ExampleFilePaths.Instance.ExampleTestProject;
		public string WithCOMReference => ExampleFilePaths.Instance.ExampleWithCOMReferenceProject;
		public string WithoutCOMReference => this.Console;
	}
}