using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace text_file_analyser
{
    class RunPowershellScript
    {
        public RunPowershellScript() { }
        public void RunScript(String scriptLocation, String arg1, String arg2, String arg3)
        {
            RunspaceConfiguration runspaceConfiguration = RunspaceConfiguration.Create();
            Runspace runspace = RunspaceFactory.CreateRunspace(runspaceConfiguration);
            runspace.Open();
            RunspaceInvoke scriptInvoker = new RunspaceInvoke(runspace);
            Pipeline pipeline = runspace.CreatePipeline();
            Command scriptCommand = new Command(scriptLocation);
            Collection<CommandParameter> commandParameters = new Collection<CommandParameter>();

            CommandParameter commandParmOne = new CommandParameter(null, arg1);
            commandParameters.Add(commandParmOne);

            CommandParameter commandParmTwo = new CommandParameter(null, arg2);
            commandParameters.Add(commandParmTwo);

            CommandParameter commandParmThree = new CommandParameter(null, arg3);
            commandParameters.Add(commandParmThree);

            scriptCommand.Parameters.Add(commandParmOne);
            scriptCommand.Parameters.Add(commandParmTwo);
            scriptCommand.Parameters.Add(commandParmThree);

            pipeline.Commands.Add(scriptCommand);
            Collection<PSObject> psObjects;
            psObjects = pipeline.Invoke();

            // Same thing different approach //

            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.FileName = @"powershell.exe";
            //startInfo.Arguments = "-File" + " " + scriptLocation + " " + arg1 + " " + arg2 + " " + arg3;
            //startInfo.RedirectStandardOutput = true;
            //startInfo.RedirectStandardError = true;
            //startInfo.UseShellExecute = false;
            //startInfo.CreateNoWindow = false;
            //Process process = new Process();
            //process.StartInfo = startInfo;
            //process.Start();
        }
    }
}
