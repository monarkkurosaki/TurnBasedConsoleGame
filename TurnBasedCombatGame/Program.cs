namespace TurnBasedCombatGame;

class Program
{
    static void Main(string[] args)
    {
        //hp
        int playerHp = 200;
        int compHp = 200;
        
        //attack
        int playerAtck;
        int comptAtck;

        Console.WriteLine("Welcome to turn based player game");
        
        while (playerHp > 0 || compHp > 0)
        {
            Console.WriteLine("Enter 'a' if you want to attack or 'h' if you want to heal");
            char playerDecision = Convert.ToChar(Console.ReadLine());

            playerDecision = char.ToLower(playerDecision);
            
            if (playerDecision.Equals('a'))
            {
                Random random = new Random();

                playerAtck = random.Next(1, 70);
                compHp -= playerAtck;
                Console.WriteLine($"Player did a total damage of {playerAtck} now computer hp is {compHp}");
                Console.WriteLine();
                Console.WriteLine("Now it is computer turn");
                
                
                System.Threading.Thread.Sleep(2000);

                comptAtck = random.Next(1, 70);
                playerHp -= comptAtck;
                Console.WriteLine($"Computer did a total of damage of {comptAtck} now player hp is {playerHp}");
                Console.WriteLine();
            }

            if (playerDecision.Equals('h'))
            {
                Random random = new Random();
                int playerHeal = random.Next(1, 51);
                Console.WriteLine($"The player has healed the amount of {playerHeal}");
                playerHp += playerHeal;
                Console.WriteLine($"Now player hp is {playerHp}");
                Console.WriteLine();
                
                System.Threading.Thread.Sleep(2000);
                
                int compHeal = random.Next(1, 51);
                Console.WriteLine($"The computer now heals the amount of {compHeal}");
                compHp += compHeal;
                Console.WriteLine($"Now the comp hp is {compHp}");
                Console.WriteLine();
            }
            
            if (compHp <=0 || playerHp <=0)
            {
                Console.WriteLine("Press any key to clear the screen and view the final results");
                Console.ReadKey();
                
                if (compHp <= 0 && playerHp > compHp)
                {
                    Console.WriteLine("Congratulations!! You win");
                    Environment.Exit(0);
                }
                else if (playerHp <= 0 && compHp > playerHp)
                {
                    Console.WriteLine("The computer wins");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("It was a draw");
                    Environment.Exit(0);
                }
            }
        }
    }
}