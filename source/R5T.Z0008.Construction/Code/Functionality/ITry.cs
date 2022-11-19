using System;

using R5T.T0132;


namespace R5T.Z0008.Construction
{
	[FunctionalityMarker]
	public partial interface ITry : IFunctionalityMarker
	{
        public void ExampleConsoleProjectFilePath()
        {
            Instances.ConsoleOperator.WriteLine(
                Instances.ExampleProjectFilePaths.Console);
        }

        public void ExampleLibraryProjectFilePath()
        {
            Instances.ConsoleOperator.WriteLine(
                Instances.ExampleProjectFilePaths.Library);
        }

        public void ExampleTestProjectFilePath()
        {
            Instances.ConsoleOperator.WriteLine(
                Instances.ExampleProjectFilePaths.Test);
        }
    }
}