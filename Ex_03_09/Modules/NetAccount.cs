namespace Ex_03_09
{
    public class NetAccount : Account
    {
        public int Point { get; set; }  //ポイントを表すプロパティ

        public NetAccount(string AccountNo, string AccountName, int Balance, int Point) : base(AccountNo, AccountName, Balance)
        {
            this.Point = Point;
        }
        override public int Print()
        {
            Console.WriteLine($"ポイント:{Point}");
        }
        /// <summary>
        /// AccountクラスのToString()メソッドの結果とポイントを表すプロパティも含んだ文字列を返却
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"[NetAccount {base.ToString()},Point={Point}]";
        }
    }
}