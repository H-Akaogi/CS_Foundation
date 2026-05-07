using System;
namespace Ex_04_01_Lib;

public class Item
{
    /// <summary>
    /// プロパティ
    /// </summary>
    public int ItemNo { get; set; }
    //商品番号を表すプロパティ
    public string? ItemName { get; set; }
    //商品名を表すプロパティ
    public int Price { get; set; }
    //単価を表すプロパティ
}