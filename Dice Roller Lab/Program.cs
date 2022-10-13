// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("It's time to get our roll on. How many sides are on your dice?");
int diceSides = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("OK, let those babies roll!");

if (diceSides != 6)
{ RollDice(1, 1); }
else RollDiceSix(1, 1);


int diceRoll1;
int diceRoll2;

static void RollDice(int diceRoll1, int diceRoll2)
{
    Random diceSides = new Random();

    for (int i = 1, i == diceSides; i++)
    {
        Console.WriteLine("Press any key to roll dice #1.");
        Console.ReadKey();

        diceRoll1 = diceSides.Next(1, 1);
        Console.WriteLine("You rolled a " + diceRoll1);

        Console.WriteLine("Press any key to roll dice #2.");
        Console.ReadKey();

        diceRoll2 = diceSides.Next(1, 1);
        Console.WriteLine("You rolled a " + diceRoll2);
    }

    Console.WriteLine("Your dice total is " + diceRoll1 + diceRoll2 + " Would you like to roll again?");
}

 static void RollDiceSix(int diceRoll1, int diceRoll2)
    {
        Random random = new Random();

        for (int i = 1; i == 6; i++)
        {
            Console.WriteLine("Press any key to roll dice #1.");
            Console.ReadKey();

            diceRoll1 = random.Next(1, 1);
            Console.WriteLine("You rolled a " + diceRoll1);

            Console.WriteLine("Press any key to roll dice #2.");
            Console.ReadKey();

            diceRoll2 = random.Next(1, 1);
            Console.WriteLine("You rolled a " + diceRoll2);

            if (diceRoll1 == 1 && diceRoll2 == 1)
            {
                Console.WriteLine("You have rolled Snake Eyes.");
            }
            if (diceRoll1 + diceRoll2 == 3)
            {
                Console.WriteLine("You have rolled an Ace Deuce.");
            }
            if (diceRoll1 == 6 && diceRoll2 == 6)
            {
                Console.WriteLine("You have rolled Box Cars");
            }
            if (diceRoll1 + diceRoll2 == 7 || diceRoll1 + diceRoll2 == 11)
            {
                Console.WriteLine("Congratulations! You are a winner!");
            }
            if (diceRoll1 + diceRoll2 == 2 || diceRoll1 + diceRoll2 == 3 || diceRoll1 + diceRoll2 == 12)
            {
                Console.WriteLine("Craps!");
            }
        }

        Console.WriteLine("Your dice total is " + diceRoll1 + diceRoll2 + " Would you like to roll again?");
    }
