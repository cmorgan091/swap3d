using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using CommandLine.Text;

namespace Swap3d.Windows.CLI.CmdLineParsing
{
    public class Options
    {
        [Option('i', "inputfile", Required = true, HelpText = "The path to the input file")]
        public string InputFile { get; set; }

        [Option('o', "outputfile", Required = false, HelpText = "The path to the output file")]
        public string OutputFile { get; set; }


        [ParserState]
        public IParserState LastParserState { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this,
              (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }


        
    }
}
