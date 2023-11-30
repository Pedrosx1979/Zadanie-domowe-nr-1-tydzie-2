using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Zadanie_domowe_nr_1_tydzień_2
{
    internal class Program
    {
         static void Main(string[] args)
       {
            Console.WriteLine("Zadnie:");
            Console.WriteLine("Deklarcja Danych personalnych pracownika ");
            Console.WriteLine("Imienia, Naziska ,Wieku ,Płci,Numeru PESEL oraz nueru pracownika");

            Console.WriteLine("Oto jest rozwiązanie zadania nr 1");

            string name = "Pioterek";
            Console.WriteLine(name);
            string surname = "Szydlak";
            Console.WriteLine(surname);
            int age = 44;
            Console.WriteLine(age);
            string personalNumber = "78233211990";
            Console.WriteLine(personalNumber);
            char sex = 'M';
            Console.WriteLine(sex);
            string workerNumber = "234";
            Console.WriteLine(workerNumber);
        }
    }
}
