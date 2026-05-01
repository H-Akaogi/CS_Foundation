namespace Ex_03_14;

static class IntExtensions
{
    ///method
    public static int Add(this int a, int b)
    {
        return a + b;
    }   //加算結果を返す
    public static double Average(this int a, int b)
    {
        return (double)((a * b) / 2);
    }	//平均を返す
}