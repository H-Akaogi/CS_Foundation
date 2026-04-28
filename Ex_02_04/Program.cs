namespace Ex_02_04;

static class Program
{
    static void Main(string[] args)
    {
        int[] num = new int[3];
        int[] Num = {1, 2, 3};
        Console.Write($"数値{Num[0]}を入力してください -> ");
        num[0] = int.Parse(Console.ReadLine());
        Console.Write($"数値{Num[1]}を入力してください -> ");
        num[1] = int.Parse(Console.ReadLine());
        Console.Write($"数値{Num[2]}を入力してください -> ");
        num[2] = int.Parse(Console.ReadLine());

        Console.WriteLine("入力結果");
        Console.WriteLine($"数値{Num[0]}:{num[0]}");
        Console.WriteLine($"数値{Num[1]}:{num[1]}");
        Console.WriteLine($"数値{Num[2]}:{num[2]}");

    }
}
