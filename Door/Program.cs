namespace Door
{
    internal class Program
    {
        
        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please input day: ");
            string day = Console.ReadLine().Trim();

            if (day.Equals(Days.Monday.ToString(), StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("It's Monday!");
            }
            else
            {
                Console.WriteLine("It's not Monday.");
            }

        }
    }
}
