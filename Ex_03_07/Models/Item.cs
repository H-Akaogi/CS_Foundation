namespace Ex_03_07_Item.Models
{
    /// <summary>
    /// 商品情報を表すクラス
    /// </summary>
    public class Item //ファイル名と揃える。クラスの中身は{}でまとめる
    {
        /// <field>
        /// フィールド(小文字)
        /// </field>
        private int item; //フィールドは小文字
        private string itemname;//フィールドは小文字
        private int price;//フィールドは小文字

        /// <property>
        /// プロパティ(大文字)＊初期値は無いため"=(値);"は不要
        /// </property>
        public int ItemNo { get; set; }         //商品番号を表すプロパティ、プロパティは大文字
        public string ItemName { get; set; }    //商品名を表すプロパティ、プロパティは大文字
        public int Price { get; set; }          //単価を表すプロパティ、プロパティは大文字

        /// <method>
        /// メソッド(プロパティで記述)
        /// </method>
        public void Print()                     //itemNo、itemName、priceフィールドの値を出力する。
        {
            Console.WriteLine($"商品番号 = {ItemNo}");  //アクセスさせるときは大文字
            Console.WriteLine($"商品名 = {ItemName}");  //アクセスさせるときは大文字
            Console.WriteLine($"単価 = {Price}");       //アクセスさせるときは大文字
        }
    }
}