namespace Training2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coinCase = new CoinCase();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("コインの種類");
                int kinds = int.Parse(Console.ReadLine());
                Console.WriteLine("コインの枚数");
                int coinAmount = int.Parse(Console.ReadLine());

                coinCase.AddCoins(kinds, coinAmount);
            }

            Console.WriteLine($"500円は{coinCase.GetCount(500)}枚、総額{coinCase.GetAmount(500)}円");
            Console.WriteLine($"100円は{coinCase.GetCount(100)}枚、総額{coinCase.GetAmount(100)}円");
            Console.WriteLine($"50円は{coinCase.GetCount(50)}枚、総額{coinCase.GetAmount(50)} 円");
            Console.WriteLine($"10円は{coinCase.GetCount(10)}枚、総額{coinCase.GetAmount(10)} 円");
            Console.WriteLine($"5円は{coinCase.GetCount(5)}枚、総額{coinCase.GetAmount(5)}  円");
            Console.WriteLine($"1円は{coinCase.GetCount(1)}枚、総額{coinCase.GetAmount(1)} 円");
            Console.WriteLine($"合計は{coinCase.GetAmount()}円");
            Console.WriteLine($"硬貨の総数は{coinCase.GetCount()}");

        }
    }
}
