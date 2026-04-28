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

                int satCount = 0;
                int sunCount = 0;

                while (date.Year == year)
                {

                    if (date.DayOfWeek == DayOfWeek.Saturday)
                    {
                        satCount++;
                    }
                    else if (date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        sunCount++;
                    }
                    date = date.AddDays(1);
                }

                Console.WriteLine($"{year} 年共有：");
                Console.WriteLine($"星期六: {satCount} 天");
                Console.WriteLine($"星期日: {sunCount} 天");
            }
            }
    }
}
