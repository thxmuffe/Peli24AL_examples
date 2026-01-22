namespace Door
{
    internal class GameManager
    {
        private Days badDay;
        private Random random;

        public GameManager()
        {
            random = new Random();
            badDay = (Days)random.Next(0, 7);
        }

        public void Play()
        {
            Console.WriteLine("Guess the bad day!\n");

            while (true)
            {
                Console.WriteLine("Please input a day: ");
                string input = Console.ReadLine()?.Trim() ?? string.Empty;

                if (!Enum.TryParse<Days>(input, ignoreCase: true, out Days selectedDay))
                {
                    Console.WriteLine("Invalid day. Please try again.\n");
                    continue;
                }

                if (selectedDay == badDay)
                {
                    PlayVictoryEffect();
                    break;
                }
                else
                {
                    Console.WriteLine($"Wrong! Try again.\n");
                }
            }
        }

        private void PlayVictoryEffect()
        {
            Console.WriteLine("\n");
            
            for (int i = 0; i < 8; i++)
            {
                Console.Beep(800 + (i * 100), 150);
                System.Threading.Thread.Sleep(50);
            }

            for (int i = 0; i < 20; i++)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\n\n★★★ YOU FOUND IT! ★★★\n");
                System.Threading.Thread.Sleep(80);
                Console.ResetColor();
                Console.Clear();
                System.Threading.Thread.Sleep(80);
            }

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("\n\n★★★ YOU WON! ★★★\n");
            Console.ResetColor();
        }
    }
}
