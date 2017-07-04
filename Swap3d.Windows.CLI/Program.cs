using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swap3d.Windows.CLI.Manipulation;

namespace Swap3d.Windows.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Swap 3D");
            Console.WriteLine("-------");

            var options = new CmdLineParsing.Options();
            if (!CommandLine.Parser.Default.ParseArguments(args, options))
            {
                if (System.Diagnostics.Debugger.IsAttached)
                {
                    Console.WriteLine("Exiting due to error parsing command line");
                    Console.WriteLine("----Press Return To Exit----");
                    Console.ReadLine();
                }
                Environment.Exit(CommandLine.Parser.DefaultExitCodeFail);
            }

            // get a gcode manipulator

            GCodeManipulator manipulator = new GCodeManipulator(options.InputFile);

            manipulator.OutputFilePath = options.OutputFile;

            // run the manipulator
            manipulator.CreateSwappedFile();








            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("----Press Return To Exit----");
                Console.ReadLine();
            }
        }
    }
}
