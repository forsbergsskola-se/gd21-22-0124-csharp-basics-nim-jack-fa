using System;

namespace Nim
{
    class Program
    {
        static void Main()
        {
            int current = 0;
            int matches = 24;
            Random random = new Random();

            Console.WriteLine("Hello! Welcome to Nim!\n");
            while (current < matches)
            {

                Console.Write("|");
                current++;

            }

            Console.Write(" (" + current + ")\n");
            Console.WriteLine();

            while (matches > 1)
            {
                Draw();
                PlayerWins();
                ResetCounter();
                ShowMatches();
                AI();
                AIWins();
                ResetCounter();
                ShowMatches();
            }

            void AIWins()
            {
                if (matches <= 1)
                {
                    matches = 0;
                    Console.WriteLine("You lose trashcan");
                    Thread.Sleep(600);
                    Console.WriteLine("Would you like to play again? If you win, you unlock hard mode >:)");
                    Thread.Sleep(600);
                    Console.WriteLine("Please type 'yes' to play again, 'no' to exit the game.");
                    string playerChoice = Console.ReadLine();
                    bool playAgain = playerChoice == "yes";
                    bool exitGame = playerChoice == "no";

                    if (playAgain)
                    {

                        Console.WriteLine("Again huh? Alright, let's go!");
                        Thread.Sleep(1000);
                        matches = 24;
                        current = 0;
                        Main();

                    }
                    else if (exitGame)
                    {
                        Console.WriteLine("Oh no, I had so much fun. Please come back some time!");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                    }
                    else
                    {

                        Console.WriteLine(
                            "You are awful at following instructions. For that, I'll exit the game for you. BYE");
                        Environment.Exit(0);

                    }
                }
            }

            void Draw()
            {

                Console.WriteLine("Type in how many matches you want to draw. (1, 2 or 3)");
                int drawn = Convert.ToInt32(Console.ReadLine());
                bool draw1 = drawn == 1;
                bool draw2 = drawn == 2;
                bool draw3 = drawn == 3;

                if (draw1 == true)
                {

                    matches--;

                }
                else if (draw2 == true)
                {

                    matches -= 2;

                }
                else if (draw3 == true)
                {

                    matches -= 3;

                }
                else
                {
                    Console.WriteLine("You may only draw 1, 2 or 3 matches! Try again.");
                    Thread.Sleep(800);
                    Draw();
                }
            }

            void ResetCounter()
            {
                current = 0;
            }

            void AI()
            {
                PlayerWins();

                Thread.Sleep(800);

                int aiDraw = random.Next(1, 4);
                bool aiDraw1 = aiDraw == 1;
                bool aiDraw2 = aiDraw == 2;
                bool aiDraw3 = aiDraw == 3;

                if (matches == 4)
                {

                    matches -= 3;
                    Console.WriteLine("The AI draws 3 matches");

                }
                else if (matches == 3)
                {

                    matches -= 2;
                    Console.WriteLine("The AI draws 2 matches");
                }
                else if (matches == 2)
                {

                    matches--;
                    Console.WriteLine("The AI draws one match");
                }
                else if (aiDraw1)
                {
                    matches--;
                    Console.WriteLine("The AI draws 1 match");
                }
                else if (aiDraw2)
                {
                    matches -= 2;
                    Console.WriteLine("The AI draws 2 matches");
                }
                else if (aiDraw3)
                {
                    matches -= 3;
                    Console.WriteLine("The AI draws 3 matches");
                }

            }

            void AIHardDraw()
            {

                Thread.Sleep(800);

                int aiDraw = random.Next(1, 4);
                bool aiDraw1 = aiDraw == 1;
                bool aiDraw2 = aiDraw == 2;
                bool aiDraw3 = aiDraw == 3;

                if (matches == 8)
                {
                    matches -= 3;
                    Console.WriteLine("The AI draws 3 matches");
                }
                else if (matches == 7)
                {
                    matches -= 2;
                    Console.WriteLine("The AI draws 2 matches");
                }
                else if (matches == 6)
                {
                    matches--;
                    Console.WriteLine("The AI draws one match");
                }
                else if (matches == 4)
                {

                    matches -= 3;
                    Console.WriteLine("The AI draws 3 matches");

                }
                else if (matches == 3)
                {

                    matches -= 2;
                    Console.WriteLine("The AI draws 2 matches");
                }
                else if (matches == 2)
                {

                    matches--;
                    Console.WriteLine("The AI draws one match");
                }
                else if (aiDraw1)
                {
                    matches--;
                    if (matches % 2 != 0)
                    {
                        matches++;
                        AIHardDraw();
                    }
                    else
                    {
                        Console.WriteLine("The AI draws one match");
                    }
                }
                else if (aiDraw2)
                {
                    matches -= 2;
                    if (matches % 2 != 0)
                    {
                        matches += 2;
                        AIHardDraw();
                    }
                    else
                    {
                        Console.WriteLine("The AI draws 2 matches");
                    }
                }
                else if (aiDraw3)
                {
                    matches -= 3;
                    if (matches % 2 != 0)
                    {
                        matches += 3;
                        AIHardDraw();
                    }
                    else
                    {
                        Console.WriteLine("The AI draws 3 matches");
                    }
                }

            }

            void ShowMatches()
            {
                while (current < matches)
                {

                    Console.Write("|");
                    current++;

                }

                Console.Write(" (" + current + ")\n");
                Console.WriteLine();
            }

            void PlayerWins()
            {

                if (matches <= 1)
                {
                    matches = 0;
                    Console.WriteLine("You win!");
                    Thread.Sleep(600);
                    Console.WriteLine(
                        "Would you like to play again? You could also try a harder version if you'd like!");
                    Thread.Sleep(600);
                    Console.WriteLine(
                        "Please type 'yes' to play again, 'no' to exit the game and 'hard' if you want a real challenge");
                    string playerChoice = Console.ReadLine();
                    bool playAgain = playerChoice == "yes";
                    bool exitGame = playerChoice == "no";
                    bool hardMode = playerChoice == "hard";

                    if (playAgain)
                    {

                        Console.WriteLine("Again huh? Alright, let's go!");
                        Thread.Sleep(1000);
                        matches = 24;
                        current = 0;
                        Main();

                    }
                    else if (exitGame)
                    {
                        Console.WriteLine("Oh no, I had so much fun. Please come back some time!");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                    }
                    else if (hardMode)
                    {
                        Console.WriteLine("Setting up hardmode...");
                        Thread.Sleep(1000);
                        HardMode();
                    }
                    else
                    {
                        Console.WriteLine(
                            "You are awful at following instructions. For that, I'll exit the game for you. BYE");
                        Environment.Exit(0);
                    }
                }
            }



        }

        static void HardMode()
        {
            int current = 0;
            int matches = 24;
            Random random = new Random();

            Console.WriteLine("Hello! Welcome to Nim Hardmode! Here, the AI starts\n");
            while (current < matches)
            {

                Console.Write("|");
                current++;

            }

            Console.Write(" (" + current + ")\n");
            Console.WriteLine();

            while (matches > 1)
            {
                AIHardDraw();
                AIWins();
                ResetCounter();
                ShowMatches();
                Draw();
                PlayerWins();
                ResetCounter();
                ShowMatches();
            }

            void AIWins()
            {
                if (matches <= 1)
                {
                    matches = 0;
                    Console.WriteLine("You lose trashcan");
                    Thread.Sleep(600);
                    Console.WriteLine("Would you like to play again? If you win, you unlock hard mode >:)");
                    Thread.Sleep(600);
                    Console.WriteLine("Please type 'yes' to play again, 'no' to exit the game.");
                    string playerChoice = Console.ReadLine();
                    bool playAgain = playerChoice == "yes";
                    bool exitGame = playerChoice == "no";

                    if (playAgain)
                    {

                        Console.WriteLine("Again huh? Alright, let's go!");
                        Thread.Sleep(1000);
                        matches = 24;
                        current = 0;
                        Main();

                    }
                    else if (exitGame)
                    {
                        Console.WriteLine("Oh no, I had so much fun. Please come back some time!");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                    }
                    else
                    {

                        Console.WriteLine(
                            "You are awful at following instructions. For that, I'll exit the game for you. BYE");
                        Environment.Exit(0);

                    }
                }
            }

            void Draw()
            {

                Console.WriteLine("Type in how many matches you want to draw. (1, 2 or 3)");
                int drawn = Convert.ToInt32(Console.ReadLine());
                bool draw1 = drawn == 1;
                bool draw2 = drawn == 2;
                bool draw3 = drawn == 3;

                if (draw1 == true)
                {

                    matches--;

                }
                else if (draw2 == true)
                {

                    matches -= 2;

                }
                else if (draw3 == true)
                {

                    matches -= 3;

                }
                else
                {
                    Console.WriteLine("You may only draw 1, 2 or 3 matches! Try again.");
                    Thread.Sleep(800);
                    Draw();
                }
            }

            void ResetCounter()
            {
                current = 0;
            }

            void AI()
            {
                PlayerWins();

                Thread.Sleep(800);

                int aiDraw = random.Next(1, 4);
                bool aiDraw1 = aiDraw == 1;
                bool aiDraw2 = aiDraw == 2;
                bool aiDraw3 = aiDraw == 3;

                if (matches == 4)
                {

                    matches -= 3;
                    Console.WriteLine("The AI draws 3 matches");

                }
                else if (matches == 3)
                {

                    matches -= 2;
                    Console.WriteLine("The AI draws 2 matches");
                }
                else if (matches == 2)
                {

                    matches--;
                    Console.WriteLine("The AI draws one match");
                }
                else if (aiDraw1)
                {
                    matches--;
                    Console.WriteLine("The AI draws 1 match");
                }
                else if (aiDraw2)
                {
                    matches -= 2;
                    Console.WriteLine("The AI draws 2 matches");
                }
                else if (aiDraw3)
                {
                    matches -= 3;
                    Console.WriteLine("The AI draws 3 matches");
                }

            }

            void AIHardDraw()
            {

                Thread.Sleep(800);

                int aiDraw = random.Next(1, 4);
                bool aiDraw1 = aiDraw == 1;
                bool aiDraw2 = aiDraw == 2;
                bool aiDraw3 = aiDraw == 3;

                if (matches == 8)
                {
                    matches -= 3;
                    Console.WriteLine("The AI draws 3 matches");
                }
                else if (matches == 11)
                {
                    matches -= 2;
                    Console.WriteLine("The AI draws 2 matches");
                }
                else if (matches == 10)
                {
                    matches--;
                    Console.WriteLine("The AI draws one match");
                }
                else if (matches == 12)
                {
                    matches -= 3;
                    Console.WriteLine("The AI draws 3 matches");
                }
                else if (matches == 7)
                {
                    matches -= 2;
                    Console.WriteLine("The AI draws 2 matches");
                }
                else if (matches == 6)
                {
                    matches--;
                    Console.WriteLine("The AI draws one match");
                }
                else if (matches == 4)
                {

                    matches -= 3;
                    Console.WriteLine("The AI draws 3 matches");

                }
                else if (matches == 3)
                {

                    matches -= 2;
                    Console.WriteLine("The AI draws 2 matches");
                }
                else if (matches == 2)
                {

                    matches--;
                    Console.WriteLine("The AI draws one match");
                }
                else if (aiDraw1)
                {
                    matches--;
                    if (matches % 2 != 0)
                    {
                        matches++;
                        AIHardDraw();
                    }
                    else
                    {
                        Console.WriteLine("The AI draws one match");
                    }
                }
                else if (aiDraw2)
                {
                    matches -= 2;
                    if (matches % 2 != 0)
                    {
                        matches += 2;
                        AIHardDraw();
                    }
                    else
                    {
                        Console.WriteLine("The AI draws 2 matches");
                    }
                }
                else if (aiDraw3)
                {
                    matches -= 3;
                    if (matches % 2 != 0)
                    {
                        matches += 3;
                        AIHardDraw();
                    }
                    else
                    {
                        Console.WriteLine("The AI draws 3 matches");
                    }
                }

            }

            void ShowMatches()
            {
                while (current < matches)
                {

                    Console.Write("|");
                    current++;

                }

                Console.Write(" (" + current + ")\n");
                Console.WriteLine();
            }

            void PlayerWins()
            {

                if (matches <= 1)
                {
                    matches = 0;
                    Console.WriteLine("You win!");
                    Thread.Sleep(600);
                    Console.WriteLine("Would you like to play hardmode again?");
                    Thread.Sleep(600);
                    Console.WriteLine(
                        "Please type 'yes' to play easier mode again, 'no' to exit the game and 'hard' if you want the hard version again.");
                    string playerChoice = Console.ReadLine();
                    bool playAgain = playerChoice == "yes";
                    bool exitGame = playerChoice == "no";
                    bool hardMode = playerChoice == "hard";

                    if (playAgain)
                    {

                        Console.WriteLine("Again huh? Alright, let's go!");
                        Thread.Sleep(1000);
                        matches = 24;
                        current = 0;
                        Main();

                    }
                    else if (exitGame)
                    {
                        Console.WriteLine("Oh no, I had so much fun. Please come back some time!");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                    }
                    else if (hardMode)
                    {
                        Console.WriteLine("Restarting Hard Mode.");
                        Thread.Sleep(1000);
                        HardMode();
                    }
                    else
                    {
                        Console.WriteLine(
                            "You are awful at following instructions. For that, I'll exit the game for you. BYE");
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}