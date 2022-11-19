using System;

using R5T.F0000;
using R5T.T0132;


namespace R5T.Z0008
{
	[FunctionalityMarker]
	public partial interface IFilePathOperator : IFunctionalityMarker
	{
		/// <summary>
		/// For files copied to the output directory, that are in the /Files directory, given a file name, get the file path.
		/// </summary>
		public string GetFilesDirectoryFilePath(string fileName)
        {
			var executableDirectoryPath = ExecutablePathOperator.Instance.GetExecutableDirectoryPath();

			var fileExecutableDirectoryRelativeFilePath = $@"\Files\{fileName}";

			var filePath = PathOperator.Instance.GetFilePath(
				executableDirectoryPath,
				fileExecutableDirectoryRelativeFilePath);

			return filePath;
        }
	}
}