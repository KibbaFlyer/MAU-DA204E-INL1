using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Shopping_Basket
{
    internal class Product
    {
        private string name;
        private double price;
        private int quantity;
        private double cost;
        public void ReadInput()
        {
            Console.WriteLine("What name does the product have?");
            name = Console.ReadLine();
            Console.WriteLine("Thanks, you entered: "+ name);
            Console.WriteLine("What price does the product have?");
            price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Thanks, you entered: " + price);
            Console.WriteLine("What quantity of the product do you wish to buy?");
            quantity = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Thanks, you entered: " + quantity);
        }
        public void CalculateCost()
        {
            cost = price * quantity;
        }
        public void ShowReceipt()
        {
            Console.WriteLine(
                "*****  Receipt  *****\n\n" +
                "Product        :   " + name + "\n" +
                "Unit Price     :   " + price + "\n" +
                "Quantity       :   " + quantity + "\n\n" +
                "Amount to pay  :   " + cost + "\n\n"+
                "***** Welcome Back! *****"
                );
        }
    }

}
