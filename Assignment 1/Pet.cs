using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    // Pet class - to write out information about a user's favorite pet
    internal class Pet
    {
        private string _name;
        private int _age;
        private bool _isFemale;
        // The class's Start method calls the different helper methods in an orderly manner
        public void Start()
        {
            //Introduction
            Console.Title = "My Favorite Pet";
            Console.WriteLine();
            Console.WriteLine("Welcome to the Pet class");
            Console.WriteLine();
            // We create a pet and display its information
            CreatePet();
            DisplayInformation();
        }
        private void CreatePet()
        {
            // Here we write out questions and collect user entries
            Console.WriteLine("What is the name of your pet?");
            _name = Console.ReadLine();
            Console.WriteLine($"What is {_name}'s age?");
            _age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Is {_name} a female (y/n)?");
            _isFemale = Console.ReadLine() == "y" ? true : false;
        }
        private void DisplayInformation()
        {
            // Here we create an output to display for the user
            string output = $"Name: {_name}, Age: {_age}";

            output = output + "\n" + 
                (_isFemale == true ? "She's " : "He's ") + 
                "such a wonderful" +
                (0 < _age && _age < 3 ? " little" : " big") +
                (_isFemale == true ? " girl!" : " boy!")
                ;
            Console.WriteLine(output);
        }
    }

}
