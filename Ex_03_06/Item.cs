namespace Ex_03_06; //namespaceは所属場所（Programと揃える）
/// <summary>
/// 商品情報を表すクラス
/// </summary>
public class Item //ファイル名と揃える。クラスの中身は{}でまとめる
{
    //  フィールド一覧
    public int itemNo;      //商品番号(フィールド)
    public string itemName; //商品名(フィールド)
    public int price;       //単価(フィールド)
    public double salesTaxRate = 0.10; // 消費税率(10%)

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public Item()
    {
    }
    public Item(int pitemNo, string pitemName, int pprice)
    //オーバーコンストラクタの確認のため書いているがなくてもOK
    {
        this.itemNo = pitemNo;
        this.itemName = pitemName;
        this.price = pprice;
    }
    public void Print()         //itemNo、itemName、priceフィールドの値を出力する。
    {
        Console.WriteLine($"商品番号 = {this.itemNo}");
        Console.WriteLine($"商品名 = {this.itemName}");
        Console.WriteLine($"単価 = {this.price}");
    }
    public void ChangePrice(int pprice)   //priceフィールドの値を引数の値に変更する
    {
        price = pprice;         //priceをppriceに上書き（priceにppriceを代入）
    }
    public void ChangePrice(string pprice)   //priceフィールドの値を引数の値に変更する
    {
        price = int.Parse(pprice);         //priceをppriceに上書き（priceにppriceを代入）
    }
    public int CalculateTaxAmount()
    {
        double result = price + (price * salesTaxRate);
        return (int)result;
    }

}