using System.ComponentModel.DataAnnotations;

namespace Ex_03_11;

static class Program
{
    static void Main(string[] args)
    {
        IUSB usb1 = new FlashMemory();
        usb1.SendData();
        usb1.ReciveData();
        IUSB usb2 = new Mouse();
        usb2.SendData();
        IUSB usb3 = new Display();
        usb3.ReciveData();
    }
}
