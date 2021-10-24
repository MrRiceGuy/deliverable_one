using System;

namespace D1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userInterested = true;

            while (userInterested)
            {
                double fidgetSpinnerValue;
                double memesValue;
                double inchesValue;
                double feetValue;
                Console.WriteLine("Now please enter a unit of measurement.");

                string unitType = Console.ReadLine();

                Console.WriteLine("Hello, Please enter a number.");

                double inputNumber = Convert.ToDouble(Console.ReadLine());



                switch (unitType)
                {
                    case "inches":
                    case "inch":
                        fidgetSpinnerValue = inputNumber * 3.5;
                        Console.WriteLine("That's " + fidgetSpinnerValue + ", fidget spinners!");
                        break;
                    case "foot":
                    case "feet":
                        memesValue = inputNumber * 5;
                        Console.WriteLine("That's " + memesValue + " memes!");
                        break;
                    case "memes":
                    case "meme":
                        inchesValue = inputNumber / 5;
                        Console.WriteLine("That's " + inchesValue + " inches!");
                        break;
                    case "fidget spinners":
                    case "fidget spinner":
                        feetValue = inputNumber / 3.5;
                        Console.WriteLine("That's " + feetValue + ", feet!");
                        break;
                }
                Console.WriteLine("Would you like to try again? \"Y\" or \"N\" ?");
                string continueQuerry = Console.ReadLine();

                if (continueQuerry == "N")
                {
                    userInterested = false;
                }


                /*

                if (unitType == "inch" || unitType == "inches")
                {
                    fidgetSpinnerValue = inputNumber * 3.5;
                    Console.WriteLine("That's " + fidgetSpinnerValue + ", fidget spinners!");
                }
                else if (unitType == "foot" || unitType == "feet")
                {
                    memesValue = inputNumber * 5;
                    Console.WriteLine("That's " + memesValue + " memes!");
                }

                Console.WriteLine("Would you like to try again? \"Y\" or \"N\" ?");

                string continueQuerry = Console.ReadLine();

                if (continueQuerry == "N")
                {
                    userInterested = false;
                }
            */
            }



        }
    }
}
