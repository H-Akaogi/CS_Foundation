namespace Ex_03_11;

public interface IUSB
{
    /// 抽象メソッド

    /*    void SendData();    //繋がっている装置にデータを送る機能の抽象メソッド
        void ReciveData();  //繋がっている装置からデータを受け取る機能の抽象メソッド
        */
    public void SendData();    //期待結果3行目のように装置にデータを送ることを表すメッセージを出力する
    public void ReciveData();	//NotImplementedExceptionをスローする
}