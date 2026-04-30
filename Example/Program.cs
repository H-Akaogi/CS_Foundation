using System.IO.Compression;

namespace Example;

static class Program
{
    static void Main(string[] args)
    {
        Warrior warrior = new("ユータ", 15);//引数ありのコンストラクタ
        Console.WriteLine(warrior.name);
        Console.WriteLine(warrior.hp);

        Warrior warrior2 = new();
        warrior2.name = "ユースケ";
        warrior2.hp = 8;
        Console.WriteLine(warrior2.name + warrior2.hp);

        Warrior warrior3 = new("あいう");
        warrior3.hp = 1;
        Console.WriteLine(warrior3.name);
        Console.WriteLine(warrior3.hp);
    }
}
