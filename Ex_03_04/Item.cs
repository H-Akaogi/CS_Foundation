namespace Ex_03_04; //namespaceは所属場所（Programと揃える）
/// <summary>
/// 商品情報を表すクラス
/// </summary>
public class Item //ファイル名と揃える。クラスの中身は{}でまとめる
{
    //  フィールド一覧
    public int itemNo;      //商品番号(フィールド)
    public string itemName; //商品名(フィールド)
    public int price;	    //単価(フィールド)
    public int pprice;      //新しい単価
    public double salesTaxRate = 0.10;  //消費税率

    //メソッド一覧
    public void ChangePrice()   //priceフィールドの値を引数の値に変更する
    {
        price = pprice;         //priceをppriceに上書き（priceにppriceを代入）
    }
    public void Print()         //itemNo、itemName、priceフィールドの値を出力する。
    {
        Console.WriteLine("結果");
        Console.WriteLine($"商品番号 = {itemNo}");
        Console.WriteLine($"商品名 = {itemName}");
        Console.WriteLine($"単価 = {price}");
    }
    public int CalculateTaxAmount() //出力した時の型名も書いておく
    {
        return (int)(price + (price * salesTaxRate));
        //double型とint型の型をそろえる。(int型に変換)(処理式)
    }
}

