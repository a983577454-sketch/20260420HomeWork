namespace Year1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("中華民國幾年呢?");
            int year = int.Parse(Console.ReadLine()) + 1911;

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("閏年");
            }
            else
            {
                Console.WriteLine("平年");
            }
        }
    }
}
