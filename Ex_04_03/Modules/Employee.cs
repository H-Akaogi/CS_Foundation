namespace Ex_04_03.Modules;

public class Employee
{
    /// <summary>
    /// プロパティ
    /// </summary>
    public int Id { get; set; }
    //社員番号を表すプロパティ
    public string? Name { get; set; }
    //名前を表すプロパティ
    public string? Address { get; set; }
    //住所を表すプロパティ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="address"></param>
    public Employee(int id, string name, string address)
    //引数の値をプロパティに設定
    {
        this.Id = id;//this.プロパティ=引数
        this.Name = name;
        this.Address = address;
    }
    /// <summary>
    /// ObjectクラスのToStringメソッド
    /// </summary>
    /// <returns></returns>
    public override string ToString()//Objectクラスを継承
    //インスタンスが保持するフィールドの値を文字列形式で返す
    {
        return $"Employee[ id={Id} , name={Name} , address={Address}]";
    }
}