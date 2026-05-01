using System.Runtime.CompilerServices;

namespace Ex_03_09
{
    /// <summary>
    /// Accountを継承したNetAccountを作成
    /// </summary>
    public class NetAccount : Account
    {
        /// <summary>
        /// ポイントを表すプロパティ
        /// </summary>
        public int Point { get; set; }
        /// <summary>
        /// Pointを追加した親クラス（Account）インスタンス
        /// </summary>
        public NetAccount(string AccountNo, string AccountName, int Balance, int Point)
        : base(AccountNo, AccountName, Balance)
        {
            this.Point = Point;
        }
        public override void Print()    //AccountクラスのPrintメソッドを継承・Point記入を追加
        {
            base.Print();
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