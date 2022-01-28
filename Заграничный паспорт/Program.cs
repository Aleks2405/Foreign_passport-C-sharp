using System;
using Passport;
/*Создайте класс «Заграничный паспорт». Вам необходимо
хранить информацию о номере паспорта, ФИО владельца,
дате выдачи и т.д. Предусмотреть механизмы для инициализации полей класса. Если значение для инициализации
неверное, генерируйте исключение.*/
namespace Заграничный_паспорт
{
    class Program
    {
        static void Main(string[] args)
        {
            string FIO, date;
            int serial = 0;
            Console.WriteLine("Введите ФИО:");
            FIO = Console.ReadLine();
            Console.WriteLine("Введите серию:");
            serial = Int32.Parse(Console.ReadLine()); 
            Console.WriteLine("Введите дату выдачи:");
            date = Console.ReadLine();

            Foreign_passport name = new Foreign_passport(FIO,serial,date);
            try
            {
                //serial = Int32.Parse(Console.ReadLine());
                serial = 0;
            }
            catch 
            {
                Console.WriteLine("Вы не правильно ввели серию паспорта");
            }
           
            name.Print();
            

        }
    }
}
