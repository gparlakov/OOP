/* Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) 
 * and display characteristics (size and number of colors). 
 * Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it). 
 * Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
Add a method in the GSM class for displaying all information about it. Try to override ToString().
Use properties to encapsulate the data fields inside the GSM, Battery and Display classes. Ensure all fields hold correct data at any given time.
Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
Task 7:Write a class GSMTest to test the GSM class:
 * Create an array of few instances of the GSM class.
 * Display the information about the GSMs in the array.
 * Display the information about the static property IPhone4S.
 Create a class Call to hold a call performed through a GSM. It should contain date, time, dialed phone number and duration (in seconds).
Add a property CallHistory in the GSM class to hold a list of the performed calls. Try to use the system class List<Call>.
Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.
Add a method that calculates the total price of the calls in the call history. Assume the price per minute is fixed and is provided as a parameter.
Task 12:Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
Create an instance of the GSM class.
Add few calls.
Display the information about the calls.
Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
Remove the longest call from the history and calculate the total price again.
Finally clear the call history and print it. 
 */

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
                //test the whole gsm
                GSM my = new GSM();
                my.Manufacturer = "HTC";
                //Console.WriteLine(my.Manufacturer);
                my.Model = "Desire";

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

                //Console.WriteLine(my);
                //Console.WriteLine(myNewGsm);
                //give static property to a new instance
                //Console.WriteLine("\ngive static property GSM.iPhone4S to a new instance\nWho is the owner?:");
                //myNewGsm1.Owner = Console.ReadLine();
                //Console.WriteLine(myNewGsm1);

                //Task 7:
                GSM[] gsmArray = new GSM[5];
                GSM myNewGsm = new GSM("Sony Ericsson", "NEO V", display2, bat3, 400, "Myself");
                GSM myNewGsm1 = GSM.IPhone4S;
                gsmArray[0] = myNewGsm;
                gsmArray[1] = myNewGsm1;
                gsmArray[2] = my;
                gsmArray[3] = new GSM("Nokia", "Asha");
                gsmArray[4] = new GSM("Sony", "Neo V", new Display(1.5f, 10), new Battery("Battery Model 1",BatteryType.Polymer, 25, 7), 1357m, "Academian");

                foreach (var gsm in gsmArray)
                {
                    Console.WriteLine(gsm);
                }
                //directly print to the console the static property iphone
                Console.WriteLine("\nDirectly print  GSM.iPhone4S to console");
                Console.WriteLine(GSM.IPhone4S);

                //Task 12:
                TestCallHistory.StartTest();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception unknownEx)
            {
                Console.WriteLine(unknownEx.Message);
            }

        }
    }
}
