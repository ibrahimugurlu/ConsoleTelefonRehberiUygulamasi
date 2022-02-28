using System;
using System.Collections;
using System.Collections.Generic;
namespace PROJE_1_Console_Telefon_Rehberi__Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            Operations operation = new Operations();
            operation.getArayuz();
            
            try
            {
                int entry = int.Parse(Console.ReadLine());
                while (operation.control(entry))
                {
                    if (entry == 1)
                    {
                        operation.addPerson();
                    }
                    if (entry == 2)
                    {
                        operation.deleteNumber();
                    }
                    if (entry == 3)
                    {
                        operation.updateNumber();
                    }
                    if (entry == 4)
                    {
                        operation.listDictionary();
                    }
                    if (entry == 5)
                    {
                        operation.searchDirection();
                    }

                    Console.Clear();
                    operation.getArayuz();
                    entry = int.Parse(Console.ReadLine());

                }
            }
            catch (Exception)
            {

                Console.WriteLine("Çıkış yapılıyor.....");
            }


            Console.Read();
        }
    }
}

