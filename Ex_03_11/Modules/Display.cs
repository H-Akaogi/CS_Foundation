namespace Ex_03_11;

public class Display : IUSB
{
    public void SendData()//	NotImplementedExceptionをスローする
    {
        Console.WriteLine("NotImplementedExceptionをスローする");
    }

    public void ReciveData()//	期待結果4行目のように装置にデータを送ることを表すメッセージを出力する 
    {
        Console.WriteLine("ディスプレイに表示する情報を受信しました");
    }
}