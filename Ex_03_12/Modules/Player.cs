namespace Ex_03_12;

public abstract class Player
{
    public string? Media { get; set; } // 再生するメディアを表す自動プロパティ
    public Player(string Media)
    {
        this.Media = Media;//引数の値でMediaプロパティを初期化する
    }
    ///抽象メソッド
    public abstract void Play();    //メディアを再生中であることを出力する
    public abstract void Stop();    //メディアの再生を停止したことを出力する
    public void UseMachine()//Play()、Stop()メソッドを呼び出す
    {
        Play();
        Stop();
    }
}