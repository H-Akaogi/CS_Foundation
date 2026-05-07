//using System.Runtime.CompilerServices;

namespace Ex_03_16;

static class Program
{
    static void Main(string[] args)
    {
        try
        {
            var calc = new Calculator();
            Console.Write("値1を入力してください-> ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("値2を入力してください-> ");
            int b = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"値1 / 値2 = {calc.Div(a, b)}");
        }
        catch (InputParameterLessThanZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("必ず実行");
        }
        Console.WriteLine("プログラム正常終了");
    }
}
