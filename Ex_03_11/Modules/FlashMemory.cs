namespace Ex_03_11;

public class FlashMemory : IUSB
{
    public void SendData()//	期待結果1行目のように装置にデータを送ることを表すメッセージを出力する
    {
        Console.WriteLine("フラッシュメモリに記録してあるデータをPCに送りました");
    }
    public void ReciveData()//	期待結果2行目のように装置にデータを送ることを表すメッセージを出力する
    {
        Console.WriteLine("PCのデータをフラッシュメモリに記録しました");
    }
}