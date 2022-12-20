using System;

using R5T.T0131;


namespace R5T.Z0008
{
	[ValuesMarker]
	public partial interface IExampleSolutionFilePaths : IValuesMarker
	{
        public string ExampleSolution => FilePathOperator.Instance.GetFilesDirectoryFilePath("ExampleSolution.sln");
        public string ExampleWithEmptyNestedProjetsGlobalSection => FilePathOperator.Instance.GetFilesDirectoryFilePath("Example-Empty NestedProjects GlobalSection.sln");
        public string ExampleWithSolutionItemsProject => FilePathOperator.Instance.GetFilesDirectoryFilePath("Example-SolutionItems Project.sln");
    }
}