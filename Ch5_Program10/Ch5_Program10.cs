using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonTasksDLL;

namespace Ch5_Program10
{
    class Ch5_Program10
    {
        static void Main(string[] args)
        {
            CT.Header(out CT.LengthOfTopLine, "Ch. 5 Program 10", " to convert "
                + "letters and numbers to a phone number");

            CT.Color("");
            /*Here I assigned the intial values for each digit
            The reason why I had to use its own ask user for string is because
            I needed to add the check to see if it isnt a special charachter or 
            more than one charachter at a time inside the method*/  
            string num1 = AskUserForString2("Digit 1");
            string num2 = AskUserForString2("Digit 2");
            string num3 = AskUserForString2("Digit 3");
            string num4 = AskUserForString2("Digit 4");
            string num5 = AskUserForString2("Digit 5");
            string num6 = AskUserForString2("Digit 6");
            string num7 = AskUserForString2("Digit 7");
            string num8 = AskUserForString2("Digit 8");
            string num9 = AskUserForString2("Digit 9");
            string num10 = AskUserForString2("Digit 10");

            //I displayed the orignal number here in a horizontal manner
            Console.WriteLine("\n\nThe original phone number:");
            CT.Color("magenta");
            Console.WriteLine("({0} {1} {2}) {3} {4} {5} - {6} {7} {8} {9}",
            num1, num2, num3, num4, num5, num6, num7, num8, num9, num10);
            CT.Color("");

            //Here I reassigned the values
            num1 = ConvertToNum(num1);
            num2 = ConvertToNum(num2);
            num3 = ConvertToNum(num3);
            num4 = ConvertToNum(num4);
            num5 = ConvertToNum(num5);
            num6 = ConvertToNum(num6);
            num7 = ConvertToNum(num7);
            num8 = ConvertToNum(num8);
            num9 = ConvertToNum(num9);
            num10 = ConvertToNum(num10);

            //Using the same means as above, I displayed the new number
            Console.WriteLine("\n\nThe useable phone number:");
            CT.Color("magenta");
            Console.WriteLine("({0} {1} {2}) {3} {4} {5} - {6} {7} {8} {9}",
            num1, num2, num3, num4, num5, num6, num7, num8, num9, num10);

            
            CT.Footer();
        }

        public static string AskUserForString2(string x)
        {
            Console.Write("\nPlease enter {0} ", x);
            CT.Color("Green");
            string input = Console.ReadLine();
            CT.Color("");
            input = CheckNum(input);
            return input;
        }

        public static string CheckNum(string x)
        {
            //This used to check if the ipnut is anything other the desired charachters and numberseverything other than 
            switch (x.ToLower())
            {
                case "1":
                case "a":
                case "b":
                case "c":
                case "2":
                case "d":
                case "e":
                case "f":
                case "3":
                case "g":
                case "h":
                case "i":
                case "4":
                case "j":
                case "k":
                case "l":
                case "5":
                case "m":
                case "n":
                case "o":
                case "6":
                case "p":
                case "q":
                case "r":
                case "s":
                case "7":
                case "t":
                case "u":
                case "v":
                case "8":
                case "w":
                case "x":
                case "y":
                case "z":
                case "9":
                case "0":
                    break;
                default:
                    x = AskUserForString2("only one digit at a time for the digit above");
                    break;
                    
            }
            return x;
        }

        public static string ConvertToNum (string x)
        {
            switch(x.ToLower())
            {
                case "1":
                    x = "1";
                    break;
                case "a":
                case "b":
                case "c":
                case "2":
                    x = "2";
                    break;
                case "d":
                case "e":
                case "f":
                case "3":
                    x = "3";
                    break;
                case "g":
                case "h":
                case "i":
                case "4":
                    x = "4";
                    break;
                case "j":
                case "k":
                case "l":
                case "5":
                    x = "5";
                    break;
                case "m":
                case "n":
                case "o":
                case "6":
                    x = "6";
                    break;
                case "p":
                case "q":
                case "r":
                case "s":
                case "7":
                    x = "7";
                    break;
                case "t":
                case "u":
                case "v":
                case "8":
                    x = "8";
                    break;
                case "w":
                case "x":
                case "y":
                case "z":
                case "9":
                    x = "9";
                    break;
                case "0":
                    x = "0";
                    break;

            }


            return x;
        }
    }
}
