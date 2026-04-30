namespace Ex_03_08
{
    public class NetAccount : Account
    {
        public int Point { get; set; }  //ポイントを表すプロパティ
        public void Print()
        {
            Console.Write($"口座番号:{AccountNo} ");
            Console.Write($"口座名義:{AccountName} ");
            Console.Write($"残高:{Balance} ");
            Console.WriteLine($"ポイント:{Point}");
        }
    }
}