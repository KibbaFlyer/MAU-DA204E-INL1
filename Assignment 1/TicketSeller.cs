using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class TicketSeller
    {
        private string _name;
        private double _price = new Random().Next(15,35);
        private double _childDiscount = 0.25;
        private int _numOfAdults;
        private int _numOfChilren;

        private double _amountToPay;

        public void Start()
        {
            Console.Title = "Ticketseller";
            Console.WriteLine();
            Console.WriteLine("Welcome to the Kid's Fair!\nWhere kids always gets 75 % discount!");
            Console.WriteLine();
            ReadInput();
            CalculateAmountToPay();
            ShowResults();
        }
        private void ReadInput()
        {
            Console.WriteLine("What is the name of the booking?");
            _name = Console.ReadLine();
            Console.WriteLine("What is the number of adults?");
            _numOfAdults = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("What is the number of children?");
            _numOfChilren = Convert.ToInt16(Console.ReadLine());
        }
        private void CalculateAmountToPay()
        {
            _amountToPay = _price * _numOfAdults + _price * _childDiscount * _numOfChilren;
        }
        private void ShowResults()
        {
            Console.WriteLine(
                $"***** Your Receipt *****" +
                $"\n***** Amount to pay: {_amountToPay} SEK" +
                $"\n***** Price per ticket: {_price}" +
                $"\n***** Thank you {_name}, and please come back! *****");
        }

    }
}
