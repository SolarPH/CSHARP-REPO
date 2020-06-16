using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp
{
    class ReservationCalc
    {
        public double getPayment(string resType, int roomNum, int days)
        {
            double[] roomPrice = new double[] {};
            switch (resType)
            {
                case "A": // First Class
                    roomPrice  = new double[]{ 1600 , 2400 , 3800 };
                    break;
                case "B": // Second Class
                    roomPrice = new double[]{ 1350 , 2200 , 3400 };
                    break;
                case "C": // Third Class
                    roomPrice = new double[]{ 1500, 2300, 3500 };
                    break;
                case "D": // Family Room
                    roomPrice = new double[]{ 1600, 2400, 3500 };
                    break;
                case "E": // VIP Class
                    roomPrice = new double[]{ 2000, 3200, 4100 };
                    break;
            }
            return roomPrice[roomNum-1] * days;
        }

        public double getPayment(int packageNum)
        {
            double price = 0.00;
            switch (packageNum)
            {
                case 1:
                    price = 1200;
                    break;
                case 2:
                    price = 1600;
                    break;
                case 3:
                    price = 1800;
                    break;
                case 4:
                    price = 2100;
                    break;
            }
            return price;
        }
    }
}
