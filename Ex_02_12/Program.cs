namespace Ex_02_12;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("値を入力して下さい -> ");
        var num = int.Parse(Console.ReadLine());

        int Mul3() //関数の作成
        {
            return num * 3; //3倍にして返す
        }

        int answer = Mul3(); //返した値をanswerに
        Console.WriteLine(answer);

        /*
        Console.Write("値を入力してください -> ");
        int inputNum = int.Parse(Console.ReadLine());
        Console.WriteLine(Mul3(inputNum));

        int Mul3(int num)
        {
        return num * 3;
        }
        */
    }
}
