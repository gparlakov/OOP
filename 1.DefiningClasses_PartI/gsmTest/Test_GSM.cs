using System;
using System.Linq;
using GsmProject;

namespace GsmTest
{
    class Test_GSM
    {
        //TODO: Property for setting Battery and Display after initialization
        static void Main(string[] args)
        {
            try
            {
                GSM[] gsmArray = new GSM[4];


                //test the battery class
                Battery bat = new Battery();
                //Console.WriteLine(bat);
                Battery bat1 = new Battery("Sony 1234h", BatteryType.Polymer);
                //Console.WriteLine(bat1);
                Battery bat2 = new Battery("Sony 1234h", BatteryType.Polymer, 28);
                //Console.WriteLine(bat2);
                Battery bat3 = new Battery("Sony 1234h", BatteryType.Polymer, 28, 7);
                //Console.WriteLine(bat3);

                //test the display class
                Display display = new Display();
                //Console.WriteLine(display);
                Display display1 = new Display(4);
                //Console.WriteLine(display1);
                Display display2 = new Display(5, 65535);
                //Console.WriteLine(display2);

                //test the whole gsm
                GSM my = new GSM();
                my.Manufacturer = "HTC";
                //Console.WriteLine(my.Manufacturer);
                my.Model = "Desire";
                //Console.WriteLine(my);
                

                GSM myNewGsm = new GSM("Sony Ericsson", "NEO V", display2, bat3, 400, "Myself");
                GSM myNewGsm1 = GSM.IPhone4S;
                gsmArray[0] = myNewGsm;
                gsmArray[1] = myNewGsm1;
                gsmArray[2] = my;
                gsmArray[3] = new GSM("Nokia", "Asha");

                foreach (var gsm in gsmArray)
                {
                    Console.WriteLine(gsm);
                }               

                //Console.WriteLine(myNewGsm);

                //give static property to a new instance
                //Console.WriteLine("\ngive static property GSM.iPhone4S to a new instance\nWho is the owner?:");

                //myNewGsm1.Owner = Console.ReadLine();
                //Console.WriteLine(myNewGsm1);

                //directly print to the console the static property iphone
                //Console.WriteLine("\nDirectly print  GSM.iPhone4S to console");
                //Console.WriteLine(GSM.IPhone4S);


                //testing the Call class
                //Call newCall = new Call("112",30);
                //Call newCall1 = new Call("0887766551", 159);           
                //Console.WriteLine(newCall);
                //Console.WriteLine(newCall1);

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
