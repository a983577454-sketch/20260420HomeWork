namespace Year4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入民國年份 ");
            int year = int.Parse(Console.ReadLine()) + 1911;

            int sat = 52, sun = 52;

            DayOfWeek firstDay = new DateTime(year, 1, 1).DayOfWeek;

            if (firstDay == DayOfWeek.Saturday) sat = 53;
            if (firstDay == DayOfWeek.Sunday) sun = 53;

            if (DateTime.IsLeapYear(year))
            {
                DayOfWeek secondDay = (DayOfWeek)(((int)firstDay + 1) % 7);

                if (secondDay == DayOfWeek.Saturday) sat = 53;
                if (secondDay == DayOfWeek.Sunday) sun = 53;
            }
            Console.WriteLine($"星期六: {sat} 天, 星期日: {sun} 天");
        }
    }
}
