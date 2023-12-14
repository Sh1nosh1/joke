using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T13_1
{
    class Program
    { 
        static void Main(string[] args)
        {
            
            try
            {
                
                Phone phone1 = new Phone();
                phone1.manufacturer = "Apple";
                phone1.model = "Iphone 14 Pro Max";
                phone1.price = 1700;
                WriteLine($"{phone1.ToString()}");
                Phone phone2 = new Phone("Samsung","Galaxy S22 Ultra",1550);
                WriteLine($"{phone2.ToString()}");
                Write("Введите прозводителя: ");
                string manufacturer = ReadLine();
                Write("Введите модель: ");
                string model = ReadLine();
                Write("Введите стоимость: ");
                double price = Convert.ToDouble(ReadLine());
                Phone phone3 = new Phone(manufacturer,model,price);
                WriteLine($"\n{phone3.ToString()}");


            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
