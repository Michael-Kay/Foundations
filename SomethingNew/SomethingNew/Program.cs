// File: Switch.cs
using System;

class TestSwitch
{
    static void Main()
    {

        /*
        Console.WriteLine("Please enter a number.");
        String input = Console.ReadLine();

        int x = int.Parse(input);

        int result = (int)((3 * x * x * x) - (5 * x * x) + 6);
            Console.WriteLine("The answer is: " + result);
            Console.ReadLine();
            */

        // write a program to give you the ASCII value of a given character by the user.  hint: input a string, takae the firstcharacter and convert it to integer.
        /*
                Console.WriteLine("Please enter your name.");
                String input = Console.ReadLine();

                char ch = input[0];
                int ascii = (int)ch;

                Console.WriteLine("ASCII = {0}", ascii);
                Console.ReadLine();
        */

        //Write a Program that determines the # of days for a month using a switch statement. The program should accept the number of the month in question.

        /* Console.WriteLine("Which month number (1-12)");
         string month = Console.ReadLine();

         string month;
         int days;

         switch (chooseMonth)
         {
             case "1":
                 month = "January";
                 days = 30;
                 break;
             case "2":
                 month = "Febuary";
                 days = 28;
                 break;
             case "3":
                 month = "March";
                 days = 31;
                 break;
              default:
                 Console.WriteLine("Opps, I dont know how many days are in that.");
                 break;
         } 
         Console.WriteLine("There are {0} days in {1}"), month, days);
         Console.ReadLine();
         */

        //write a program that taks a person's name and determine if the last name is "smith". 
        //The user will be asked to enter a person's name as one string (in upper of lower case or both) 
        //and the program will determine if the last name that was entered was Smtih.

        Console.WriteLine("What is your first and last name?");
        string name = Console.ReadLine();

        name = name.ToLower();

        if (name.EndsWith(" smith"))
        {
            Console.WriteLine("Your last name is Smith");
        } else
        {
            Console.WriteLine("Your last name is not Smith");
        }
        Console.ReadLine();
    }
}