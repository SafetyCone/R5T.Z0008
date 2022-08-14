using System;


namespace R5T.Z0008
{
	public class ExampleFilePaths : IExampleFilePaths
	{
		#region Infrastructure

	    public static ExampleFilePaths Instance { get; } = new();

	    private ExampleFilePaths()
	    {
        }

	    #endregion
	}
}