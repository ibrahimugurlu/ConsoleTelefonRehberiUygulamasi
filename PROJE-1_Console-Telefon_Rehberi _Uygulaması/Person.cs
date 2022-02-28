using System;
using System.Collections.Generic;
using System.Text;

namespace PROJE_1_Console_Telefon_Rehberi__Uygulaması
{
    public class Person
    {

        string name;
        string surname;
        string phone;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Phone { get => phone; set => phone = value; }

        public Person(string isim,string soyisim,string numara)
        {
            this.Name = isim;
            this.Surname = soyisim;
            this.Phone = numara;
        }
       


    }
}
