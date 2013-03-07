using System;
using System.Threading;
using System.Linq;


namespace Timer
{   
    public static class MyTimer<T>
    {
        
        /// <summary>
        /// Runs functions in delegate with a delay of seconds
        /// </summary>
        /// <param name="delay">seconds</param>
        /// <param name="deleg">Delagete</param>
        /// <param name="paramsForDelegate"></param>
        public static void RunThis(int delay,Delegate deleg,T paramsForDelegate)
        {               
            deleg.DynamicInvoke(paramsForDelegate);
            Console.WriteLine("timer repeats every {0} seconds", delay);
            Console.WriteLine("--Press any key to exit--");

            Thread.Sleep(delay * 1000);    
            
            if (Console.KeyAvailable)
            {    
                return;                
            }
            MyTimer<T>.RunThis(delay, deleg,paramsForDelegate);
        }
    }
}
