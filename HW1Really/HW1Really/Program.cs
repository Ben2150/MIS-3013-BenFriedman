using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1Really
{
    class Program
    {

        static void Main(string[] args)
        {
            const double SalesTax = .085;//8.5%
            string itemname;
            int quant;
            double pri;

            Console.WriteLine("Please choose item you are purchasing");
            itemname = Console.ReadLine();

            Console.WriteLine("How many " + itemname + " do you want to buy?");
            quant = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the price for each " + itemname + "?");
            pri = double.Parse(Console.ReadLine());

            double subtotal = pri * quant;
            double salestax = SalesTax * subtotal;
            double salestotal = subtotal + salestax;

            Console.WriteLine("Your subtotal for your bill is " + subtotal.ToString("C") + "\nYour sales tax for your bill is" + salestax.ToString("C") + "\nYour total for your bill is" + salestotal.ToString("C"));

            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();
        }
        
    }
}
