namespace Example;
/// <summary>
/// 人物を表すクラス
/// </summary>
public class Human : Character
{
    public int Hp { get; private set; }

    public override void Greet()
    {
        Console.WriteLine($"{Name}:やあ!");
    }

    public void Defence(int damage)
    {
        Hp -= damage;
    }
}