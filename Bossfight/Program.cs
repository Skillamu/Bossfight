namespace Bossfight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var hero = new GameCharacter("Hero", 100, 20, 40);
            var boss = new GameCharacter("Boss", 400, 20, 10);

            while (hero.Health > 0 && boss.Health > 0)
            {
                switch (hero.Stamina)
                {
                    case <= 0:
                        hero.Recharge(40);
                        break;
                    default:
                        hero.Fight(boss);
                        break;
                }

                switch (boss.Stamina)
                {
                    case <= 0:
                        boss.Recharge(10);
                        break;
                    default:
                        boss.Fight(hero);
                        break;
                }
            }

            if (hero.Health > 0)
            {
                WinnerOfTheGame(hero);
            }
            else
            {
                WinnerOfTheGame(boss);
            }

            Console.WriteLine("\nPress any key to close the window...");
            Console.ReadKey();
        }

        public static void WinnerOfTheGame(GameCharacter character)
        {
            Console.WriteLine($"\n{character.Name} is the winner!");
        }
    }
}