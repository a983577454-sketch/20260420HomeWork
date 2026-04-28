namespace Number810
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("請輸入數字串（用,隔開）: ");
            string input = Console.ReadLine();

            string[] rawData = input.Split(',');

            List<int> odds = new List<int>();  
            List<int> evens = new List<int>(); 

            foreach (string s in rawData)
            {
                int n = int.Parse(s); 
                if (n % 2 == 0)
                    evens.Add(n);
                else
                    odds.Add(n);
            }


            evens.Sort();
            odds.Sort();

            Console.WriteLine("偶數: " + string.Join(", ", evens));
            Console.WriteLine("奇數: " + string.Join(", ", odds));
        }
    }
}
