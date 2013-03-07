using System;
using System.Linq;

namespace Timer
{
    class TimerTest
    {
        delegate void OneParamDelagate<T>(T param);

        static void Print(string mes)
        {
            Console.WriteLine(mes);
        }
        
        static void Main(string[] args)
        {
            OneParamDelagate<string> myDelegate = Print;
            myDelegate += delegate(string param)
                {
                    Console.WriteLine("this is a time delay");
                };
            MyTimer<string>.RunThis(2, myDelegate,"Nakov");
        }
    }
}
