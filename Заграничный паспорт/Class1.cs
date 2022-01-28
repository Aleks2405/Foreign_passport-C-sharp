using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passport
{
    class Foreign_passport
    {
        private string FIO;
        private int series;
        private string date_of_issue;
       public Foreign_passport(string FIO,int series,string date_of_issue) 
        {
            this.FIO = FIO;
            this.series = series;
            this.date_of_issue = date_of_issue;
        }
         public void Print()
        {
            Console.WriteLine($"ФИО: {FIO}, серия паспорта: {series},дата выдачи: {date_of_issue}");
        }
    }
}
