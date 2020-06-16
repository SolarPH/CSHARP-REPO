using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reservation Calculator Sample - Console Edition");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Reservation Type? (Type a code)");
            Console.WriteLine("A - First Class");
            Console.WriteLine("B - Second Class");
            Console.WriteLine("C - Third Class");
            Console.WriteLine("D - Family Room");
            Console.WriteLine("E - VIP Class");
            Console.WriteLine("F - Package Deal");
            Console.Write(">>> ");
            string type = Console.ReadLine();
            Console.WriteLine("----------------------------------------");
            Boolean exclusiveType = false;
            string resType = "";
            switch (type)
            {
                case "A":
                    resType = "FIRST CLASS";
                    break;
                case "B":
                    resType = "SECOND CLASS";
                    break;
                case "C":
                    resType = "THIRD CLASS";
                    break;
                case "D":
                    resType = "FAMILY ROOM";
                    break;
                case "E":
                    resType = "VIP CLASS";
                    break;
                case "F":
                    resType = "PACKAGE";
                    exclusiveType = true;
                    break;
            }


            int packageVer = 0;
            int roomNum = 0;
            int days = 0;

            // Cycle 1 / Package or By-Room
            switch (exclusiveType)
            {
                case true:
                    Console.WriteLine("Enter Package Number (1-4)");
                    Console.Write(">>> ");
                    packageVer = Convert.ToInt32(Console.ReadLine());
                    break;
                case false:
                    Console.WriteLine("Enter Room Number (1-3)");
                    Console.Write(">>> ");
                    roomNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("How many days is the reservation?");
                    Console.Write(">>> ");
                    days = Convert.ToInt32(Console.ReadLine());
                    break;
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");
            switch (exclusiveType)
            {
                case true:
                    Console.WriteLine("RESERVATION TYPE = " + resType + " #" + Convert.ToString(packageVer));
                    break;
                case false:
                    Console.WriteLine("RESERVATION TYPE = " + resType + " #" + Convert.ToString(roomNum));
                    Console.WriteLine("DAYS OF STAY - " + Convert.ToString(days));
                    break;
            }

            /* CALCULATION CLASS FILE
             * COPY-PASTE THIS PART OF THE CODE DEPENDING ON USAGE
             * SYNTAX VERSIONS:
             *  (this.)ReservationCalc().getPayment(string resType, int roomNum, int days)
             *  (this.)ReservationCalc().getPayment(int packageNum)
             *  resType, accepts A to E
             *  roomNum, accepts 1 to 3
             *  days = days of stay
             *  packageNum = accepts 1 to 4
             *  return type: double
            */
            switch (exclusiveType)
            {
                case true: // if resType is set to F
                    Console.Write("Payment Total: ");
                    Console.WriteLine(new ReservationCalc().getPayment(packageVer));
                    break;
                case false: // if resType is set to any from A to E
                    Console.Write("Payment Total: ");
                    Console.WriteLine(new ReservationCalc().getPayment(type, roomNum, days));
                    break;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
