namespace Ex_04_02;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("年を入力してください -> ");
        int year = int.Parse(Console.ReadLine());
        /// <summary>
        /// 引数に指定された年が閏年か判定する(true:閏年、false:閏年でない)
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        if (DateTime.IsLeapYear(year))
        //staticメソッドなのでクラス名.が必要。
        // DateTime構造体なので、クラス名（DateTime）を付ける
        {
            Console.WriteLine($"{year}年は閏年です");//true
        }
        else
        {
            Console.WriteLine($"{year}年は閏年ではありません");//false
        }

    }
}
