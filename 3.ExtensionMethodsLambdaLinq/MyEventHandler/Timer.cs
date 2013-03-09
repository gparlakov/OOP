using System;
using System.Linq;
using System.Threading;

namespace MyEventHandler
{  
    public class Timer
    {
        public event TimerEventHandler Tick;
        protected TimerEventArgs timerArgs;

        public Timer(int time)
        {
            this.timerArgs = new TimerEventArgs(time);            
        }

        public void TimerStart()
        {
            do
            {
                Thread.Sleep(this.timerArgs.TimerToPass * 1000);
                Tick(this, this.timerArgs);
                if (Console.KeyAvailable)
                {
                    Console.Clear();
                    return;
                }
            } while (true);
        }
    }
}
