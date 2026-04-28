namespace Ex_03;

static class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("数値を入力してください -> ");
        int num = int.Parse(Console.ReadLine());
        System.Console.WriteLine($"5を加算した結果は {num+5} です");
        System.Console.WriteLine($"5を減算した結果は {num-5} です");
    }
}
