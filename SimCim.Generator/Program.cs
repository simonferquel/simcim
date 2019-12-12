using CaseExtensions;
using Microsoft.Extensions.CommandLineUtils;
using Microsoft.Management.Infrastructure;
using System;
using System.Linq;

namespace SimCim.Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new CommandLineApplication()
            {
                Name = "SimCim-Generator",
                FullName = "SimCim-Geneterator",
                Description = "Generate typed Cim models",
            };
            app.HelpOption("-h|--help");
            app.VersionOption("-v|--version", "0.1.0");
            app.OnExecute(() => {
                app.ShowHint();
                return 1;
            });
            app.Command("generate", GenerateCommand);
            app.Execute(args);
        }

        private static void GenerateCommand(CommandLineApplication command)
        {
            command.Name = "generate";
            command.HelpOption("-h|--help");
            command.Description = "Generate a cim model";
            var cimNamespaceArg = command.Argument("cim namespace", "CIM namespace to generate the model from");
            var csNamespaceOption = command.Option("--cs-namespace|-n", "C# namespace", CommandOptionType.SingleValue);
            var outDirOption = command.Option("--out|-o", "Output directory", CommandOptionType.SingleValue);
            command.OnExecute(() =>
            {
                if(cimNamespaceArg.Value == null)
                {
                    command.Error.WriteLine("cim namespace is not specified");
                    return 1;
                }
                var cimNamespace = cimNamespaceArg.Value;
                var options = new ModelBuildingOptions
                {
                    CSharpNamespace = csNamespaceOption.Value() ?? ToCSNamespace(cimNamespace),
                    OutputDir = outDirOption.Value() ?? Environment.CurrentDirectory,
                    Out = command.Out,
                    Error = command.Error,
                    CimNamespace = cimNamespace,
                };
                using (var cimSession = CimSession.Create(null)) {
                    var modelBuilder = new ModelBuilder(cimSession, cimNamespace, options);
                    modelBuilder.Build();
                }

                return 0;
            });
        }

        private static string ToCSNamespace(string cimNamespace) => string.Join(".", cimNamespace.Split("/").Select(v => v.ToPascalCase()));
    }
}
