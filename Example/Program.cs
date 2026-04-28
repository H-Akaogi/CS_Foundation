using System.IO.Compression;

namespace Example;

static class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 6; i++)
        {
            if (i == 2)
            {
                continue;
            }
            Console.WriteLine($"i = {i}");
        }
        Console.WriteLine("終了");
    }
}
