namespace Year3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("西元幾年");
            int year = int.Parse(Console.ReadLine());

            DateTime firstDay = new DateTime(year, 1, 1);
            DateTime lastDay = new DateTime(year, 12, 31);

            int totalDays = (lastDay - firstDay).Days + 1;

            int weeks = totalDays / 7;
            int satCount = weeks;
            int sunCount = weeks;

            int remainingDays = totalDays % 7;

            for (int i = 0; i < remainingDays; i++)
            {
                DayOfWeek day = firstDay.AddDays(i).DayOfWeek;
                if (day == DayOfWeek.Saturday) satCount++;
                if (day == DayOfWeek.Sunday)
                {
                    sunCount++;
                }
            }

            Console.WriteLine($"{year} 年有 {satCount} 個星期六，{sunCount} 個星期日。");
        }
    }
}
