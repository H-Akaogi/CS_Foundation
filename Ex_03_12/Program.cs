namespace Ex_03_12;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("DVDのタイトルを入力してください-> ");
        string dvdMedia = Console.ReadLine();
        Player dvdplayer = new DVDPlayer(dvdMedia);
        dvdplayer.UseMachine();

        Console.Write("blurayのタイトルを入力してください-> ");
        string blurayMedia = Console.ReadLine();
        Player blurayplayer = new BlurayPlayer(blurayMedia);
        blurayplayer.UseMachine();
        /*
                dvdplayer.Media = dvdMedia;
                blurayplayer.Media = blurayMedia;

                IPlayer[] players = new IPlayer[2];
                players[0] = dvdplayer;
                players[1] = blurayplayer;
                foreach (IPlayer player in players)
                {
                    player.UseMachine(Media);//それぞれの実装クラスのメソッドが実行される
                }
                */
    }
}
