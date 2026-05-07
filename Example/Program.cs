using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Example;

static class Program
{
    static void Main(string[] args)
    {

        var item = new Item() { Id = 100, Name = "みかん", Price = 150 };

        var jsonStr = JsonConvert.SerializeObject(item);
        //インスタンスをもとにJsonの文字列を作る
        Console.WriteLine(jsonStr);

        var item2 = JsonConvert.DeserializeObject<Item>(jsonStr);
        //Json文字列をもとにインスタンスを作る
        Console.WriteLine(item2);

        JObject jsonObj = JObject.Parse(jsonStr);//Jsonの文字列
        Console.WriteLine($"Id:{jsonObj["Id"]}");
        Console.WriteLine($"Name:{jsonObj["Name"]}");
        Console.WriteLine($"Price:{jsonObj["Price"]}");
    }
}