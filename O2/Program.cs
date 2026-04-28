namespace O2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個整數：");
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i--)
            {
                int count = n - i + 1;
                for (int j = 0; j < count; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
