using System;

using R5T.F0000;


namespace R5T.Z0008.Construction
{
    public static class Instances
    {
        public static IConsoleOperator ConsoleOperator { get; } = F0000.ConsoleOperator.Instance;
        public static IExampleProjectFilePaths ExampleProjectFilePaths { get; } = Z0008.ExampleProjectFilePaths.Instance;
    }
}