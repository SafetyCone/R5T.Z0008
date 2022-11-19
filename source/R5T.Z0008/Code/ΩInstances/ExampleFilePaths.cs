using System;


namespace R5T.Z0008
{
	public class ExampleFilePaths : IExampleFilePaths
	{
		#region Infrastructure

	    public static IExampleFilePaths Instance { get; } = new ExampleFilePaths();

	    private ExampleFilePaths()
	    {
        }

	    #endregion
	}
}