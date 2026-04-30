namespace Ex_03_07_Item.Models
{
    /// <summary>
    /// 商品情報を表すクラス
    /// </summary>
    public class Item //ファイル名と揃える。クラスの中身は{}でまとめる
    {
        public int ItemNo { get; set; }         //商品番号を表すプロパティ
        public string ItemName { get; set; }    //商品名を表すプロパティ
        public int Price { get; set; }          //単価を表すプロパティ
        public void Print()                     //itemNo、itemName、priceフィールドの値を出力する。
        {
            Console.WriteLine($"商品番号 = {ItemNo}");
            Console.WriteLine($"商品名 = {ItemName}");
            Console.WriteLine($"単価 = {Price}");
        }
    }
}