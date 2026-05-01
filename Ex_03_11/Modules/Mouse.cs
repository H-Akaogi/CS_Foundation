namespace Ex_03_11;

public class Mouse : IUSB
{
    public void SendData()//期待結果3行目のように装置にデータを送ることを表すメッセージを出力する
    {
        Console.WriteLine("PCにマウスの移動情報を送信しました");
    }
    public void ReciveData()//NotImplementedExceptionをスローする
    {
        Console.WriteLine("NotImplementedExceptionをスローする");
    }

}