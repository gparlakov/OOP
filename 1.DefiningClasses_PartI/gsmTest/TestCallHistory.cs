using System;
using GsmProject;

namespace GsmTest
{
    public static class TestCallHistory
    {
        public static void StartTest()
        {
            GSM testGsm = new GSM("HTC", "one");
            Call firstCall = new Call("0899", 989);
            //testing the Call class
            Call newCall = new Call("112", 30);
            Call newCall1 = new Call("0887766551", 159);
            //Console.WriteLine(newCall);
            //Console.WriteLine(newCall1);

            testGsm.AddCallToHistory = new Call("0889474746", 219);
            testGsm.AddCallToHistory = newCall;
            testGsm.AddCallToHistory = newCall1;
            testGsm.AddCallToHistory = firstCall;
            testGsm.AddCallToHistory = new Call("0889474746", 218);
            testGsm.AddCallToHistory = newCall;
            testGsm.AddCallToHistory = newCall1;

            testGsm.CallHistoryPrint(10);
            Console.WriteLine("Price is {0:f2} lv", testGsm.CallsPrice(0.37f));

            testGsm.RemoveLongestCall();
            //testGsm.RemoveCall(4);
            testGsm.CallHistoryPrint(10);
            Console.WriteLine("Price is {0:f2} lv", testGsm.CallsPrice(0.37f));
            testGsm.ClearCallHistory();
            testGsm.CallHistoryPrint();
        }
    }
}
