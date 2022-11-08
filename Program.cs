using System;
using System.Collections.Generic;


namespace MetalappsAutomation
{
    class Program
    {

        public static List<int> salesId = new List<int>();
        public static List<string> customerName = new List<string>();
        public static List<int> noOfUnits = new List<int>();
        public static List<double> netAmount = new List<double>();

        static void Main(string[] args)
        {
            salesId.Add(1010);
            salesId.Add(1011);
            salesId.Add(1012);
            customerName.Add("Zeemog Traders");
            customerName.Add("Amelia Traders");
            customerName.Add("P Traders");
            noOfUnits.Add(15);
            noOfUnits.Add(20);
            noOfUnits.Add(8);
            netAmount.Add(1073737.5);
            netAmount.Add(1386440);
            netAmount.Add(590744);
            Console.WriteLine("The DataBase");
            Console.WriteLine($"*************************");
            Console.WriteLine($"");
            for (int i = 0; i < salesId.Count; i++)
            {
                Console.WriteLine($"Sales ID:{salesId[i]}");
                Console.WriteLine($"Customer Name:{customerName[i]}");
                Console.WriteLine($"No of Units:{noOfUnits[i]}");
                Console.WriteLine($"Net Amount:{netAmount[i]}");

                Console.WriteLine($"");
                Console.WriteLine($"");
            }
            SalesDetails obj = new SalesDetails();
            int id = obj.Sales();
            string name = obj.Name();
            int units = obj.Units();

            MetalApps o = new MetalApps();
            double amt = o.CalculateNetAmount(units);


            Console.WriteLine($"");
            Console.WriteLine($"");
            Console.WriteLine("Sales Bill ");
            Console.WriteLine("***********");
            Console.WriteLine("Sales Id : " + id);
            Console.WriteLine("Customer Name : " + name);
            Console.WriteLine("Number of Units Sold : " + units);
            Console.WriteLine("Net Amount : " + amt);
            salesId.Add(id);
            customerName.Add(name);
            noOfUnits.Add(units);
            netAmount.Add(amt);
            Console.WriteLine($"");
            Console.WriteLine($"");
            Console.WriteLine("The DataBase");
            Console.WriteLine($"*************************");
            Console.WriteLine($"");
            for (int i = 0; i < salesId.Count; i++)
            {
                Console.WriteLine($"Sales ID:{salesId[i]}");
                Console.WriteLine($"Customer Name:{customerName[i]}");
                Console.WriteLine($"No of Units:{noOfUnits[i]}");
                Console.WriteLine($"Net Amount:{netAmount[i]}");


                Console.WriteLine($"");
                Console.WriteLine($"");
            }











        }
    }
}
