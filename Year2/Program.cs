namespace Year2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("西元幾年?");
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                DateTime date = new DateTime(year, 1, 1);

                int sat = 0;
                int sun = 0;

                while (date.Year == year)
                {

                    if (date.DayOfWeek == DayOfWeek.Saturday)
                    {
                        sat++;
                    }
                    else if (date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        sun++;
                    }
                    date = date.AddDays(1);
                }

                Console.WriteLine($"{year} 年共有：");
                Console.WriteLine($"星期六: {sat} 天");
                Console.WriteLine($"星期日: {sun} 天");
            }
            }
    }
}
