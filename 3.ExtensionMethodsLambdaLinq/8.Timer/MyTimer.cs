using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    delegate void Executer<T> (T param);
    
    public static class MyTimer
    {
        public static int Delay{get;set;}
        

        public static void RunThis(int delay)
        {            
            Thread.Sleep(delay*1000);

        }
    }
}
