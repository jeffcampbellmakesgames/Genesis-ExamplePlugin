using Genesis.Plugin;

namespace HelloWorldPlugin
{
    /// <summary>
    /// An example code generation plugin that creates a single output class file.
    /// </summary>
    public class ExampleCodeGeneratorPlugin : ICodeGenerator
    {
        /// <inheritdoc />
        public string Name => nameof(ExampleCodeGeneratorPlugin);

        /// <inheritdoc />
        public int Priority => 0;

        /// <inheritdoc />
        public bool RunInDryMode => true;

        private string EXAMPLE_FILE_CONTENTS =
@"
public class ExamplePluginOutputClass { }
";

        /// <inheritdoc />
        public CodeGenFile[] Generate(CodeGeneratorData[] data)
        {
            return new CodeGenFile[]
            {
                new CodeGenFile(
                    "ExamplePluginOutputClass.cs",
                    EXAMPLE_FILE_CONTENTS,
                    Name)
            };
        }
    }
}
