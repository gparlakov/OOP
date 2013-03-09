using System;
using System.Linq;
using System.Threading;

namespace MyEventHandler
{   
    public class TimerEventArgs : EventArgs
    {
         private int timeToPass;  

         public int TimerToPass
         {
             get
             {
                 return this.timeToPass;
             }
             set
             {
                 if (value > 0)
                 {
                     this.timeToPass = value;
                 }
             }
         }

         public TimerEventArgs(int timeToPass)
         {
             this.TimerToPass = timeToPass;            
         }
       
    }
}
