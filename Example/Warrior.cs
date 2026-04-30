namespace Example;
/// <summary>
/// 戦士を表すクラス
/// </summary>
public class Warrior
{
    public string name;     // 名前を表すフィールド
    public int hp = 10;     // 体力を表すフィールド
    public int ap = 5;      // 攻撃力を表すフィールド
    public int dp;          // 防御力を表すフィールド
    /// <summary>
    /// デフォルトコンストラクトを追加
    /// </summary>
    public Warrior()
    {
        name = "名無し";
        hp = 1;
    }
    ///
    /// 
    /// 
    public Warrior(string name)
    {
        this.name = name;
        hp = 15;
    }
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="pname">nameフィールドに設定する値</param>
    /// <param name="php">hpフィールドに設定する値</param>
    public Warrior(string name, int hp)
    {
        this.name = name;
        this.hp = hp;
    }
}