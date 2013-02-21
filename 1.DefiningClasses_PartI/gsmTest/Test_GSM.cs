using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  gsm_project;

namespace gsmTest
{
    class Test_GSM
    {
        static void Main(string[] args)
        {
            
            //test the battery class
            Battery bat = new Battery();
            Console.WriteLine(bat);
            Battery bat1 = new Battery("Sony 1234h");
            Console.WriteLine(bat1);
            Battery bat2 = new Battery("Sony 1234h",28);
            Console.WriteLine(bat2);
            Battery bat3 = new Battery("Sony 1234h", 28,7,BatteryType.Polymer);
            Console.WriteLine(bat3);

            //test the display class
            Display display = new Display();
            Console.WriteLine(display);
            Display display1 = new Display(4);
            Console.WriteLine(display1);
            Display display2 = new Display(4,65535);
            Console.WriteLine(display2);

            //test the whole gsm
            GSM my = new GSM("Sony", "NEO V");
            my.Manufacturer = "Sony";
            Console.WriteLine(my.Manufacturer);
            my.Model = "Vaio";
            Console.WriteLine(my);
            GSM myNewGsm = new GSM("Sony Ericsson", "NEO V", display2, bat3, "My", 400);
            Console.WriteLine(myNewGsm);

        }
    }
}
