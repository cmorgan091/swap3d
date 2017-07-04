using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NLog;

namespace Swap3d.Windows.CLI.Manipulation
{
    public class GCodeManipulator
    {
        protected Logger _Logger = LogManager.GetCurrentClassLogger();

        public GCodeManipulator(string InputFilePath)
        {
            this.InputFilePath = InputFilePath;
        }

        public string InputFilePath { get; set; }
        public string OutputFilePath { get; set; }

        // configuration for this run

        /// <summary>
        /// This is the amount to be purged when a tool change is needed
        /// </summary>
        public float PurgeAmount { get; set; } = 3.5f;


        // standard gcode constants

        /// <summary>
        /// string to look for to detect start of gcodes proper. This should be the last line of slicer start gcode
        /// </summary>
        const string BeginText = "begin";

        /// <summary>
        /// string to look for to detect end of gcodes proper. This shuould be the first line of slicer start gcode
        /// </summary>
        const string EndText = "end";

        /// <summary>
        /// String to look for to detect a tool command (which is why we need to restrict the search to between "begin" and "end", Tool number counld be anything after the "T" so we can't can't search for "Tnn" explicitly
        /// </summary>
        const string ToolText = "T";

        // Now we can list the flags that we will use during the processing
        /// <summary>
        /// flag to detect if the word "begin" is present
        /// </summary>
        private bool BeginFlag { get; set; } = false;

        /// <summary>
        /// flag to detect if the word "end" is present
        /// </summary>
        private bool EndFlag { get; set; } = false;

        /// <summary>
        /// flag to detect that tool changes are present
        /// </summary>
        private bool ToolFlag { get; set; } = false;

        // some private counters

        /// <summary>
        /// number of tool changes done
        /// </summary>
        private int ToolChanges = 0;

        // some private variables


        /// <summary>
        /// The current tool at this point, default to T0
        /// </summary>
        private string CurrentTool { get; set; } = "T0";

        /// <summary>
        /// The first tool used, default to T0
        /// </summary>
        private string FirstTool { get; set; } = "T0";

        public void CreateSwappedFile()
        {
            _Logger.Info("Starting the creation of the swapped file");
            _Logger.Info("Input Path: {0}", InputFilePath);

            if (File.Exists(InputFilePath))
            {
                FileInfo inputfileinfo = new FileInfo(InputFilePath);

                _Logger.Info("Input file size: {0:0.00}MB", inputfileinfo.Length / 1024d / 1024d);

                string inputline;
                StreamReader inputsr = new StreamReader(InputFilePath);
                while ((inputline = inputsr.ReadLine()) != null)
                {
                    // here we will actually process the file and do something...
                    
                }
            }


        }



        /*
        
     


#There is nothing to check that begin is indeed before end - maybe do this check too.

        
lineText="" # text read in from file

startLineNo=0 # the line number in the file imediately after the word "begin"

toolChangeLineNo=0 # the line number in the file where a tool change occurs

firstToolPos=0 # the line where the first tool command (after the "begin") is found

newToolPos=0 # the position where the tool command will be inserted

filePointer =0 # Where we are at now

lastLine = 0 # the position of the last line in the temp file

lineToRead=0 # pointer to which line to read in the temp file

estart=0 # position in the line after the letter "E" which denotes the position of the start of digits for

extrusion

estring="" # the string of 7 digits following the letter E

EAmount=0.0 # estring converted to a number

totEAmount=0.0 # the sum of all EAmounts

EAmountNeeded=0 # the purge amount less the totEAmount

notEnoughFlag=0 # flag to set if the the totEAmount is less than needed for a full purge between

tool changes

xStartPrev=0 # the position in the previous line where X is

xPrevString="" # read the 7 characters after "X"

xPrevNum=0.00 # convert to number - First X value

xStartHere=0 # the position in this line where X is

xHereString="" # read the 7 characters after "X"

xHereNum=0.0 # convert to number - Second X value

xMove=0 #xHereNum-xPrevNum

yStartPrev=0 # the position in the previous line where Y is

yPrevString="" # read the 7 characters after "Y"

yPrevNum=0.0 # convert to number - First Y value

yStartHere=0 # the position in this line where Y is

yHereString="" # read the 7 characters after "Y"

yHereNum=0.0 # convert to number - Second Y value

yMove=0 # yHereNum-yPrevNum

E1 = 0 # EAmount-EAmountNeeded

E2 = 0 # EAmountNeeded

X2 =0 # xHereNum

X1 =0 # PrevNum +(xMove/eAmount*E2)

Y2 =0 # yHereNum

Y1 =0 # yPrevNum +(yMove/eAmount*E2)

E1string="" # used to build insertString1 - 1st E amount

E2string="" # used to build insertString2 - 2nd E amount

X1string="" # as above but X values

X2string=""

Y1string="" # as above but Y values

Y2string=""

insertCheck=0 # used in loop to check lines are valid for inserting text

firstInsert=0 # modified from newToolPos if that position contains something other than a normal

XYE move

secondInsert=0# as above

insertString1="" # 1st (new) move string prior to tool change i.e. "G1 Xnnn.nnn Ynnn.nnn

En.nnnnn"

insertString2="" # then the tool change

insertString3="" # then the second move string

changesDone=0 #number of tool chnages done

         */
    }
}
