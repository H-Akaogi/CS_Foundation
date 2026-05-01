namespace Ex_03_10;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("DVDのタイトルを入力してください-> ");
        var dvd = new DVDPlayer(Console.ReadLine());
        dvd.Play();//インスタンスが挿入された変数名.メソッド()
        dvd.Stop();

        Console.Write("blurayのタイトルを入力してください-> ");
        var bluray = new BlurayPlayer(Console.ReadLine());
        bluray.Play();
        bluray.Stop();
    }
}
