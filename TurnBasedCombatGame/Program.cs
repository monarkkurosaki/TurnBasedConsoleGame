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

            char.ToLower(playerDecision);
            
            if (playerDecision.Equals('a'))
            {
                Random random = new Random();

                playerAtck = random.Next(1, 70);
                compHp -= playerAtck;
                Console.WriteLine($"Player did a total damage of {playerAtck}");
                Console.WriteLine("Now it is computer turn");
                
                System.Threading.Thread.Sleep(2000);

                comptAtck = random.Next(1, 70);
                playerHp -= comptAtck;
                Console.WriteLine($"Computer did a total of damage of {comptAtck}");
            }

            if (playerDecision.Equals('h'))
            {
                Random random = new Random();
                int playerHeal = random.Next(1, 51);
                Console.WriteLine($"The player has healed the amount of {playerHeal}");
                playerHp += playerHeal;
                Console.WriteLine($"Now player hp is {playerHp}");

                int compHeal = random.Next(1, 51);
                Console.WriteLine($"The computer now heals the amount of {compHeal}");
                compHp += compHeal;
                Console.WriteLine($"Now the comp hp is {compHp}");
            }
        }
        
        
    }
}