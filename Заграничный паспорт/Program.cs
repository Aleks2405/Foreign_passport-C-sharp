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
            int leng = 10;
            Console.WriteLine("Введите ФИО:");
            FIO = Console.ReadLine();
            Console.WriteLine("Введите серию:");
            serial = Int32.Parse(Console.ReadLine()); 
            Console.WriteLine("Введите дату выдачи:");
            date = Console.ReadLine();

            Foreign_passport name = new Foreign_passport(FIO,serial,date);
            try
            {
                if (date.Length > leng)
                {
                    throw new Exception("Длина больше 8 символов"); 
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Вели не корректную дату выдачи");
            }
            //finally
            //{
            //    Console.WriteLine("Повторите попытку ввода");  несовсем понял как работает и зачем нужен 
               
            //}
           
            name.Print();
            

        }
    }
}
