#load nuget:?package=Chocolatey.Docs.Cake.Recipe&version=0.2.0

Environment.SetVariableNames();

BuildParameters.SetParameters(context: Context,
                            projectFilePath: "./Docs.csproj");

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolPreprocessorDirectives();

Build.Run();