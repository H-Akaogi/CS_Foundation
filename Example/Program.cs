using System.IO.Compression;

namespace Example;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("値1を入力してください->");
        string value1 = Console.readLine()!;
        Console.Write("値2を入力してください->");
        int value2 = int.Parse(Console.readLine()!);
    }

}
