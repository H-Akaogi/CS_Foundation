using System.Collections.Generic;
using System.Net.Sockets;
using Ex_04_03.Modules;
namespace Ex_04_03;

static class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();//<Employee>リストの作成
        //List<型> 配列 = new List<型>()
        while (true)//falseになるまで繰り返す
        {
            Console.Write("社員番号を入力してください -> ");
            string id = Console.ReadLine();//文字列で入力
            if (id == "End")//Endが入力されたら終了する(false)
            {
                break;//終了
            }
            Console.Write("社員名を入力してください -> ");
            string? name = Console.ReadLine();
            if (name == "End")
            {
                break;
            }
            Console.Write("住所を入力してください -> ");
            string? address = Console.ReadLine();
            if (address == "End")
            {
                break;
            }
            Employee employee = new Employee(int.Parse(id), name, address); //コンストラクト
            employees.Add(employee);//Listに追加
        }
        foreach (Employee employee in employees)//(型 変数名 in 配列)
        //employeesにあるそれぞれのemployeeについて記述(ObjectクラスToStringメソッド)
        {
            Console.WriteLine(employee);
            //文字列で帰ってきたものをコンソールに出力
        }
    }
}
