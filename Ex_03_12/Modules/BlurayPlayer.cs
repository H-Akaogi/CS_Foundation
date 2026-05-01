namespace Ex_03_12;

public class BlurayPlayer : Player
{
    public BlurayPlayer(string Media) : base(Media)
    {
        //Playerクラスのコンストラクタを呼び出す
    }

    public override void Play()
    {
        Console.WriteLine($"Blu-ray:{Media}を再生しています");
    }
    public override void Stop()
    {
        Console.WriteLine($"Blu-ray:{Media}の再生を停止しました");
    }

}