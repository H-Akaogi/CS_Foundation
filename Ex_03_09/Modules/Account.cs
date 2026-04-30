namespace Ex_03_09
{

    public class Account
    {
        /// <summary>
        /// 各プロパティを初期化
        /// </summary>
        public string AccountNo;
        public string AccountName;
        public int Balance;

        public string? AccountNo { get; set; }  //口座番号を表すプロパティ
        public string? AccountName { get; set; }    //口座名義を表すプロパティ
        public int Balance { get; set; }    //残高を表すプロパティ
        public Account(string AccountNo, string AccountName, int Balance)
        {
            this.AccountNo = AccountNo;
            this.AccountName = AccountName;
            this.Balance = Balance;
        }

        public virtual void Print()
        {
            Console.Write($"口座番号:{AccountNo} ");
            Console.Write($"口座名義:{AccountName} ");
            Console.Write($"残高:{Balance} ");
            Console.WriteLine($"ポイント:{Point}");
        }
        /// <summary>
        /// objectクラスのToString()メソッドをオーバーライドし、プロパティの値の文字列を返却するメソッド
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Account[AccountNo={AccountNo},AccountName={AccountName},Balance ={Balance}]";
        }

    }

}