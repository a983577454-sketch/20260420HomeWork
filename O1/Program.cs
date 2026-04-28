namespace O1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入,分隔的字串: ");
            string input = Console.ReadLine();

            string[] items = input.Split(',');

            Console.Write("反向結果: ");

            for (int i = items.Length - 1; i >= 0; i--)
            {
                Console.Write(items[i]);

                if (i > 0)
                {
                    Console.Write(",");
                }
            }
        }
    }
}
