namespace Ex_03_12;

public class DVDPlayer : Player
{
    public DVDPlayer(string Media) : base(Media)
    {
        //Playerクラスのコンストラクタを呼び出す
    }
    public override void Play()
    {
        Console.WriteLine($"DVD:{Media}を再生しています");
    }
    public override void Stop()
    {
        Console.WriteLine($"DVD:{Media}の再生を停止しました");
    }

}