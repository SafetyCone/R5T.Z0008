using System;


namespace R5T.Z0008
{
	public class ExampleProjectFilePaths : IExampleProjectFilePaths
	{
		#region Infrastructure

	    public static IExampleProjectFilePaths Instance { get; } = new ExampleProjectFilePaths();

	    private ExampleProjectFilePaths()
	    {
        }

	    #endregion
	}
}