using System;

public class Game
{
    public static void Main()
    {
        Console.WriteLine("What's your name?");
        string userName = Console.ReadLine();
        int moneyDefault = 100;
        int energyDefault = 5;
        int scoreDefault = 0;

        int chickenPursePrice = 20;
        string chickenPurseName = "Chicken Purse";
        int candleLattePrice = 30;
        string candleLatteName = "Candle Latte";


        Console.WriteLine("Starting resources: ");
        Console.WriteLine("--------------------");
        Console.WriteLine("Money: " + moneyDefault);
        Console.WriteLine("Energy: " + energyDefault);
        Console.WriteLine("Score: " + scoreDefault);
        Console.WriteLine("");
        string userSearchChoice = "y";


        while (userSearchChoice == "y")
        {

            Console.WriteLine("Where would you like to search?");
            Console.WriteLine("[a] Vintage Store");
            Console.WriteLine("[b] Garage Sale");
            Console.WriteLine("");
            string userShopChoice = Console.ReadLine();


            if (userShopChoice == "a")
            {
                Console.WriteLine("Welcome to the Vintage Store, " + userName + "!");            
                Console.WriteLine("You have found a " + chickenPurseName + " for $" + chickenPursePrice + "! and you look so stylish with it!");
                
                moneyDefault -= chickenPursePrice;
                scoreDefault += 20;
                Console.WriteLine("");
                Console.WriteLine("Money: " + "$" + moneyDefault);
                Console.WriteLine("Energy: ++ " + energyDefault + " ++");
                Console.WriteLine("Score: " + scoreDefault);

                Console.WriteLine("Keep searching? (y/n)");
                userSearchChoice = Console.ReadLine();
            }

            else if (userShopChoice == "b")
            {
                Console.WriteLine("Welcome to the Garage Sale, " + userName + "!");
                Console.WriteLine("You have found a " + candleLatteName + " for $" + candleLattePrice + "! and it smells SOOOO GOOOOOOD!!!");
                
                moneyDefault -= candleLattePrice;
                scoreDefault += 30;
                Console.WriteLine("Here is your candle!");
                Console.WriteLine("");

                Console.WriteLine("Money: " + "$" + moneyDefault);
                Console.WriteLine("Energy: ++ " + energyDefault + " ++");
                Console.WriteLine("Score: " + scoreDefault);

                Console.WriteLine("Keep searching? (y/n)");
                userSearchChoice = Console.ReadLine();
            }
            
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        Console.WriteLine("Game Over!");
        Console.WriteLine("");
        Console.WriteLine("Final Score: " + scoreDefault);
        Console.WriteLine("Treasure Hunt Rank: Lucky Finder");
    }
}