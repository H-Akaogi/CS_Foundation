namespace Ex_03_16;

public class Calculator
{
    // 引数指定された値を除算して返す。
    // 引数xの値が0以下の場合、例外InputParameterLessThanZeroExceptionをスロー
    public string InputParameterLessThanZeroException(int param)
    {
        Console.WriteLine($"xに{param}が入力されました。正の値を入力してください。");
    }
    public int Div(int x, int y)
    {

        if (x <= 0)
        {
            throw new InputParameterLessThanZeroException(x);
        }

        return x / y;
    }
}