using System;


namespace R5T.Z0008
{
	public class ExampleProjectFilePaths : IExampleProjectFilePaths
	{
		#region Infrastructure

	    public static ExampleProjectFilePaths Instance { get; } = new();

	    private ExampleProjectFilePaths()
	    {
        }

	    #endregion
	}
}