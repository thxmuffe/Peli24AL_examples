namespace Door
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Days badDay = (Days)random.Next(0, 7);

            Console.WriteLine($"A bad day has been chosen: {badDay}");
            Console.WriteLine("Try to find and select the bad day!\n");

            Days selectedDay = Days.Monday;
            bool found = false;

            while (!found)
            {
                Console.WriteLine("Please input a day: ");
                string input = Console.ReadLine()?.Trim() ?? string.Empty;

                if (!Enum.TryParse<Days>(input, ignoreCase: true, out selectedDay))
                {
                    Console.WriteLine("Invalid day. Please try again.\n");
                    continue;
                }

                if (selectedDay == badDay)
                {
                    Console.WriteLine($"You found it! {badDay} is the bad day!\n");
                    PlayVictoryEffect();
                    found = true;
                }
                else
                {
                    Console.WriteLine($"Wrong! {selectedDay} is not the bad day. Try again.\n");
                }
            }
        }

        static void PlayVictoryEffect()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Beep(1000, 200);
                System.Threading.Thread.Sleep(100);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine("★ YOU WIN! ★");
                System.Threading.Thread.Sleep(100);
                Console.Clear();
                System.Threading.Thread.Sleep(100);
            }

            Console.WriteLine("★ YOU WIN! ★");
        }
    }
}
