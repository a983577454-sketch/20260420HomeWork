namespace Number246
{
    internal class Program
    {
        static void Main(string[]args)
        {
            Console.Write("請輸入一個整數：");

            int num = int.Parse(Console.ReadLine());
            {

                if (num % 2 == 0)
                {
                    Console.WriteLine($"{num} 是偶數");
                }
                else
                {
                    Console.WriteLine($"{num} 是奇數");
                }
            }
            
        }
    }
}
