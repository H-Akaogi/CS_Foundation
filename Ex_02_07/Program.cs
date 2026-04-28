namespace Ex_02_07;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("数値を入力してください -> ");
        int value = int.Parse(Console.ReadLine());

        if (value > 0)
        {
            Console.WriteLine("正の値です。");
        }
        else if (value < 0)
        {
            Console.WriteLine("負の値です。");
        }
        else
        {
            Console.WriteLine("0です。");
        }

        /*
            [switch文の場合]

            Console.Write("数値を入力してください -> ");
            int value = int.Parse(Console.ReadLine());

            switch (value)
            {
            case int n when value > 0:
                Console.WriteLine("正の値です。");
                break;
            case int n when value < 0:
                Console.WriteLine("負の値です。");
                break;
            case int n when value == 0:
                Console.WriteLine("0です。");
                break;
            }
        */
    }
}
