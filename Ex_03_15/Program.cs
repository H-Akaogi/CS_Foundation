
namespace Ex_03_15;

static class Program
{
    static void Main(string[] args)
    {
        var caluclator = new Calculator();
        Console.Write("値1を入力してください-> ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("値2を入力してください-> ");
        int b = int.Parse(Console.ReadLine());
        try
        {
            Console.WriteLine($"値1 / 値2 = {caluclator.Div(a, b)}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"例外:{e.Message}");
        }
    }
}
