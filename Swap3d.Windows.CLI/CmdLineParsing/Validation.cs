using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NLog;

namespace Swap3d.Windows.CLI.CmdLineParsing
{
    public static class Validation
    {
        private static Logger _Logger = LogManager.GetCurrentClassLogger();

        public static bool ValidateOptions(Options Options)
        {
            if (!string.IsNullOrWhiteSpace(Options.InputFile))
            {
                if (File.Exists(Options.InputFile))
                {
                    // so the file exists, any other tests?
                }
                else
                {
                    // file doesn't exist
                    _Logger.Error("The input file '{0}' does not exist", Options.InputFile);
                    return false;
                }
            }
            else
            {
                // No file path is specified
                _Logger.Error("No input file path was specified");
                return false;
            }

            return true;
        }
    }
}
