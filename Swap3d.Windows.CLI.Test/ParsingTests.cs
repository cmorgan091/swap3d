using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Swap3d.Windows.CLI.CmdLineParsing;
using System.Reflection;
using System.IO;

namespace Swap3d.Windows.CLI.Test
{
    [TestClass]
    public class ParsingTests
    {
        private string TestFilesPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        [TestMethod]
        public void ParsingTest_Validation()
        {
            var options = new Options()
            {
                InputFile = Path.Combine(TestFilesPath, "GCodeFiles", "threeColourTest.gcode")
            };

            bool result = Validation.ValidateOptions(options);

            Assert.IsTrue(result);

        }
    }
}
