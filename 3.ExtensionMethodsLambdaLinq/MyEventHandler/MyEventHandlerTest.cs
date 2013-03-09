using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEventHandler
{
    class MyEventHandlerTest
    {
        delegate void MethodStarter(string methoArgs);

        static void Main()
        {                       
            Timer fiveSecondTimer = new Timer(5);
            fiveSecondTimer.Tick += TickerMethod;            
            fiveSecondTimer.TimerStart();            
        }

        
        /// <summary>
        /// Generates a tick event every given ammount of seconds 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventHandler"></param>
        static void TickerMethod(object sender, TimerEventArgs eventHandler)
        {
            MethodStarter mStarter = MetodToBeStarted;
            string argument = string.Format("Param for the method\nRepeats every {0}seconds\nPress any key to stop the events", eventHandler.TimerToPass);
            mStarter(argument);
        }

        //this is the method that will be started after the elapsed time passes
        static void MetodToBeStarted(string paramToBePrinted)
        {
            Console.WriteLine("This is the param {0}",paramToBePrinted);
        }

    }
}
