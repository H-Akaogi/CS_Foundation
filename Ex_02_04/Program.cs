namespace Ex_02_04;

static class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("数値1を入力してください -> ");
        int a = int.Parse(System.Console.ReadLine());
        System.Console.Write("数値2を入力してください -> ");
        int b = int.Parse(System.Console.ReadLine());
        System.Console.Write("数値3を入力してください -> ");
        int c = int.Parse(System.Console.ReadLine());

        System.Console.WriteLine("入力結果");
        System.Console.WriteLine($"数値1:{a}");
        System.Console.WriteLine($"数値2:{b}");
        System.Console.WriteLine($"数値3:{c}");
    }
}
