namespace Ex_03_13;

public class Circle
{
    ///<summary>
    ///フィールド
    ///</summary>
    public static double PI = 3.14; //円周率
    int radius; //半径
    ///<summary>
    ///コンストラクタ
    ///</summary>
    public Circle(int pradius)
    {
        this.radius = pradius;//フィールドの半径を初期化するコンストラクタ
    }
    ///<summary>
    ///メソッド
    ///</summary>
    public double AreaCalculation()//フィールドの半径の値の円の面積を計算する動的メソッド
    {
        return radius * radius * PI;
    }
    public static double AreaCalculation(int radius) //引数の半径の値の円の面積を計算する静的メソッド
    {
        return radius * radius * PI;
    }
}