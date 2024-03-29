﻿using System;
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

        // The Start Method is the entry for the class.
        // Here it writes out a welcome message and then calls the class methods in order to collect and output data
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
        // This method first asks questions and then reads input from the user 
        private void ReadInput()
        {
            Console.WriteLine("What is the name of the booking?");
            _name = Console.ReadLine();
            Console.WriteLine("What is the number of adults?");
            _numOfAdults = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("What is the number of children?");
            _numOfChilren = Convert.ToInt16(Console.ReadLine());
        }
        // A calculation method to combine parameters into a single double
        private void CalculateAmountToPay()
        {
            _amountToPay = _price * _numOfAdults + _price * _childDiscount * _numOfChilren;
        }
        // This method organises the inputs and the calculated output and displays it for the user
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
