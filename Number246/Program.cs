namespace Number246
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("請輸入一個整數：");

            int number = int.Parse(Console.ReadLine());
            {

                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} 是偶數");
                }
                else
                {
                    Console.WriteLine($"{number} 是奇數");
                }
            }
            
        }
    }
}
