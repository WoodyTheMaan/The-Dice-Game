using Making_A_Die_Class;
using System.Net.Security;

namespace The_Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)

        {
            double bankAccount = 100.00, bet;
            string userInputMenu = "";
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine($"Hello, you have ${bankAccount} dollars what do you want to bet?");
                Console.WriteLine("You can bet...");
                Console.WriteLine("1 .. Doubles (win double what you bet)");
                Console.WriteLine("2 .. Not double (win half your bet)");
                Console.WriteLine("3 .. Even sum (win your bet, you bet 3 you get 3)");
                Console.WriteLine("4 .. Odd sum (Same as even sum just odd)");
                Console.WriteLine("Please type numbers not words.");
                userInputMenu = Console.ReadLine();
                if (userInputMenu == "1")
                {
                    Console.WriteLine("You picked 1, please place a bet");
                    repeat = false;
                    bet = Convert.ToInt32(Console.ReadLine());
                    if (bet > bankAccount)
                    {
                        bet = bankAccount;
                    }
                    if (bet < 0)
                    {
                        bet = 0;
                    }

                    Console.ReadLine();
                    Die die1 = new Die();
                    Die die2 = new Die(3);

                    Console.WriteLine($"You rolled a {die1}");
                    die1.DrawDie();


                    die1.RollDie();
                    die1.DrawDie();
                    Console.WriteLine($"You rolled a {die1}");
                    if (die1.Roll == die2.Roll)
                    {
                        bankAccount = bankAccount + bet * 2;
                        Console.WriteLine("YOU WON!!");
                        Console.WriteLine($"You now have ${bankAccount}!");
                    }
                    else if (die1.Roll != die2.Roll)
                    {
                        if (bankAccount < bet * 2)
                        {
                            bankAccount = 0;
                        }
                        else if (bankAccount > bet * 2)
                        {
                            bankAccount = bankAccount - bet * 2;
                        }


                        Console.WriteLine("YOU LOST...");
                        Console.WriteLine($"You now have ${bankAccount}!");
                        Console.ReadLine();
                    }
                }
                else if (userInputMenu == "2")
                {
                    Console.WriteLine("You picked 2, please place a bet");
                    repeat = false;
                    bet = Convert.ToInt32(Console.ReadLine());
                    if (bet > bankAccount)
                    {
                        bet = bankAccount;
                    }
                    if (bet < 0)
                    {
                        bet = 0;
                    }

                    Console.ReadLine();
                    Die die1 = new Die();
                    Die die2 = new Die(3);
                    Console.WriteLine($"You rolled a {die1}");
                    die1.DrawDie();


                    die1.RollDie();
                    die1.DrawDie();
                    Console.WriteLine($"You rolled a {die1}");

                    if (die1.Roll == die2.Roll)
                    {
                        bankAccount = bankAccount - bet / 2;


                        Console.WriteLine("YOU LOST...");
                        Console.WriteLine($"You now have ${bankAccount}!");
                        Console.ReadLine();
                    }
                    else if (die1 != die2)
                    {
                        bankAccount = bankAccount + bet / 2;
                        Console.WriteLine("YOU WON!!");
                        Console.WriteLine($"You now have ${bankAccount}!");
                        Console.ReadLine();
                    }
                }
                else if (userInputMenu == "3")
                {
                    Console.WriteLine("You picked 3, please place a bet");
                    repeat = false;
                    bet = Convert.ToInt32(Console.ReadLine());
                    if (bet > bankAccount)
                    {
                        bet = bankAccount;
                    }
                    if (bet < 0)
                    {
                        bet = 0;
                    }
                    Console.ReadLine();
                    Die die1 = new Die();
                    Die die2 = new Die(3);
                    Console.WriteLine($"You rolled a {die1}");
                    die1.DrawDie();


                    die1.RollDie();
                    die1.DrawDie();
                    Console.WriteLine($"You rolled a {die1}");
                    if (die1.Roll + die2.Roll == 2)
                    {
                        bankAccount = bankAccount + bet;
                        Console.WriteLine("YOU WON!!");
                        Console.WriteLine($"You now have ${bankAccount}!");
                        Console.ReadLine();
                    }
                    else if (die1.Roll + die2.Roll == 4)
                    {
                        bankAccount = bankAccount + bet;
                        Console.WriteLine("YOU WON!!");
                        Console.WriteLine($"You now have ${bankAccount}!");
                        Console.ReadLine();
                    }
                    else if (die1.Roll + die2.Roll == 6)
                    {
                        bankAccount = bankAccount + bet;
                        Console.WriteLine("YOU WON!!");
                        Console.WriteLine($"You now have ${bankAccount}!");
                        Console.ReadLine();
                    }
                    else if (die1.Roll + die2.Roll == 8)
                    {
                        bankAccount = bankAccount + bet;
                        Console.WriteLine("YOU WON!!");
                        Console.WriteLine($"You now have ${bankAccount}!");
                        Console.ReadLine();
                    }
                    else  if (die1.Roll + die2.Roll == 10)
                    {
                        bankAccount = bankAccount + bet;
                        Console.WriteLine("YOU WON!!");
                        Console.WriteLine($"You now have ${bankAccount}!");
                        Console.ReadLine();
                    }
                    else  if (die1.Roll + die2.Roll == 12)
                    {
                        bankAccount = bankAccount + bet;
                        Console.WriteLine("YOU WON!!");
                        Console.WriteLine($"You now have ${bankAccount}!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("YOU LOST...");
                        Console.WriteLine($"You now have ${bankAccount}!");
                        Console.ReadLine();
                    }

                }
                else if (userInputMenu == "4")
                {
                    Console.WriteLine("You picked 4, please place a bet");
                    repeat = false;
                    bet = Convert.ToInt32(Console.ReadLine());
                    if (bet > bankAccount)
                    {
                        bet = bankAccount;
                    }
                    if (bet < 0)
                    {
                        bet = 0;
                    }
                    Console.ReadLine();
                    Die die1 = new Die();
                    Die die2 = new Die(3);
                    Console.WriteLine($"You rolled a {die1}");
                    die1.DrawDie();


                    die1.RollDie();
                    die1.DrawDie();
                    Console.WriteLine($"You rolled a {die1}");
                    if (die1.Roll + die2.Roll == 1)
                    {
                        bankAccount = bankAccount + bet;
                        Console.WriteLine("YOU WON!!");
                        Console.WriteLine($"You now have ${bankAccount}!");
                        Console.ReadLine();
                    }
                    else if (die1.Roll + die2.Roll == 3)
                    {
                        bankAccount = bankAccount + bet;
                        Console.WriteLine("YOU WON!!");
                        Console.WriteLine($"You now have ${bankAccount}!");
                        Console.ReadLine();
                    }
                    else if (die1.Roll + die2.Roll == 5)
                    {
                        bankAccount = bankAccount + bet;
                        Console.WriteLine("YOU WON!!");
                        Console.WriteLine($"You now have ${bankAccount}!");
                        Console.ReadLine();
                    }
                    else if (die1.Roll + die2.Roll == 7)
                    {
                        bankAccount = bankAccount + bet;
                        Console.WriteLine("YOU WON!!");
                        Console.WriteLine($"You now have ${bankAccount}!");
                        Console.ReadLine();
                    }
                    else if (die1.Roll + die2.Roll == 9)
                    {
                        bankAccount = bankAccount + bet;
                        Console.WriteLine("YOU WON!!");
                        Console.WriteLine($"You now have ${bankAccount}!");
                        Console.ReadLine();
                    }
                    else if (die1.Roll + die2.Roll == 11)
                    {
                        bankAccount = bankAccount + bet;
                        Console.WriteLine("YOU WON!!");
                        Console.WriteLine($"You now have ${bankAccount}!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("YOU LOST...");
                        Console.WriteLine($"You now have ${bankAccount}!");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}