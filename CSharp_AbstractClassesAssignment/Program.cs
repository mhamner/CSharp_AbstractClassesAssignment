using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_AbstractClassesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ////This demonstrates the use of abstract classes and inheritance.
            ///     We've created a Ship abstract base class.  It provides implemenation for everything except
            ///     BlowHorn(), which is completely abstract.  Then each ship type's class derives from the Ship class
            ///     and provides implementation for BlowHorn() which overriding the other methods to add their own text
            ///     to, for example, Move() - then they also call the base. version of those so we can get the main
            ///     text from the Ship base class as well.
            ///     
            bool keepGoing = true;
            string shipChoice = "";
            bool needToChooseShip = true;
            while (keepGoing)
            {
                while (needToChooseShip)
                {
                    Console.WriteLine("Please select your ship type.");
                    Console.WriteLine("[1]  Cruse Ship");
                    Console.WriteLine("[2]  Sail Boat");
                    Console.WriteLine("[3]  Ski Boat");

                    shipChoice = Console.ReadLine();

                    if (shipChoice != "1" && shipChoice != "2" && shipChoice != "3")
                    {
                        Console.WriteLine("Invalid Choice.  Please enter 1, 2, or 3.");
                        needToChooseShip = true;
                    }
                    else
                    {
                        needToChooseShip = false;
                    }
                }

                string captainsOrders = "";
                bool needOrders = true;
                while (needOrders)
                {
                    Console.WriteLine("What is your command, Captain?");
                    Console.WriteLine("Please enter Move, Stop, Blow Horn, Change Ship, or End.");

                    captainsOrders = Console.ReadLine();
                    needOrders = false;
                    /*
                    if (captainsOrders.ToLower() != "move" && captainsOrders.ToLower() != "stop" &&
                        captainsOrders.ToLower() != "blow horn" && captainsOrders.ToLower() != "horn" &&
                        captainsOrders.ToLower() != "change ship" && captainsOrders.ToLower() != "change"
                        && captainsOrders.ToLower() != "end")
                    {
                        Console.WriteLine($"Sorry, captain - {captainsOrders} is not a valid order.");
                    }
                    else
                    {
                        needOrders = false;
                    }
                    */
                    if(captainsOrders.ToLower() == "change ship" || captainsOrders.ToLower() == "change")
                    {
                        shipChoice = "change";
                    }
                    if (captainsOrders.ToLower() == "end")
                    {
                        shipChoice = "end";
                    }

                    switch (shipChoice)
                    {
                        case "1":
                            //Cruise Ship
                            CruiseShip cruiseShip = new CruiseShip();
                            switch (captainsOrders.ToLower())
                            {
                                case "move":
                                    cruiseShip.Move();
                                    break;
                                case "stop":
                                    cruiseShip.Stop();
                                    break;
                                case "blow horn":
                                case "horn":
                                    cruiseShip.BlowHorn();
                                    break;
                                default:
                                    Console.WriteLine($"Sorry, Captain, {captainsOrders} is not a valid order.");
                                    needOrders = true;
                                    break;
                            }
                            break;
                        case "2":
                            //Sail Boat
                            SailBoat sailBoat = new SailBoat();
                            switch (captainsOrders.ToLower())
                            {
                                case "move":
                                    sailBoat.Move();
                                    break;
                                case "stop":
                                    sailBoat.Stop();
                                    break;
                                case "blow horn":
                                case "horn":
                                    sailBoat.BlowHorn();
                                    break;
                                default:
                                    Console.WriteLine($"Sorry, Captain, {captainsOrders} is not a valid order.");
                                    needOrders = true;
                                    break;
                            }
                            break;
                        case "3":
                            //Ski Boat
                            SkiBoat skiBoat = new SkiBoat();
                            switch (captainsOrders.ToLower())
                            {
                                case "move":
                                    skiBoat.Move();
                                    break;
                                case "stop":
                                    skiBoat.Stop();
                                    break;
                                case "blow horn":
                                case "horn":
                                    skiBoat.BlowHorn();
                                    break;
                                default:
                                    Console.WriteLine($"Sorry, Captain, {captainsOrders} is not a valid order.");
                                    needOrders = true;
                                    break;
                            }
                            break;
                        case "change":
                            needToChooseShip = true;
                            break;
                        case "end":
                            keepGoing = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Boat Selection.");
                            break;
                    }
                }
            }
            Console.WriteLine("Press any key to end.");
            Console.ReadKey();

        }
    }
}
