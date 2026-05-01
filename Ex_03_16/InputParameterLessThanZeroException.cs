namespace Ex_03_16;

public class InputParameterLessThanZeroException : Exception
{
    public InputParameterLessThanZeroException(int param)
    : base($"xに{param}が入力されました。正の値を入力してください。")
    {

    }
    //baseキーワードを利用してExceptionクラスのコンストラクタに
    // $"xに{param}が入力されました。正の値を入力してください。"
    // の文字列を渡す
}