namespace Ex_02_05;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("値を入力してください -> ");
        int value = int.Parse(Console.ReadLine());

        if (value % 2 == 1)
        {
            Console.WriteLine($"結果：{value}");
        }
        else
        {
            Console.WriteLine($"結果：{value * 10}");
        }
        /*より簡単
        Console.Write("値を入力してください -> ");
        int value = int.Parse(Console.ReadLine());

        if (value%2 == 0)
        {
           value *= 10
        }
        Console.WriteLine($"結果：{value}");
        */
    }
}
