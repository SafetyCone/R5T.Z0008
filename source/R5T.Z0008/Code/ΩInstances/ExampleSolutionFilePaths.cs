using System;


namespace R5T.Z0008
{
	public class ExampleSolutionFilePaths : IExampleSolutionFilePaths
	{
		#region Infrastructure

	    public static IExampleSolutionFilePaths Instance { get; } = new ExampleSolutionFilePaths();

	    private ExampleSolutionFilePaths()
	    {
        }

	    #endregion
	}
}