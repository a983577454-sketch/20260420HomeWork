namespace Number810
{
    internal class Program
    {
        static void Main(string[]args)
        {
            Console.Write("請輸入數字串（用,隔開）: ");
            string input = Console.ReadLine();

            string[] rawData = input.Split(',');

            List<int> odd = new List<int>();  
            List<int> even = new List<int>(); 

            foreach (string s in rawData)
            {
                int n = int.Parse(s); 
                if (n % 2 == 0)
                    even.Add(n);
                else
                    odd.Add(n);
            }


            even.Sort();
            odd.Sort();

            Console.WriteLine("偶數: " + string.Join(", ", even));
            Console.WriteLine("奇數: " + string.Join(", ", odd));
        }
    }
}
