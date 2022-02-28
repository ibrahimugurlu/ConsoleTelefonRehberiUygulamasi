using System;
using System.Collections.Generic;
using System.Text;

namespace PROJE_1_Console_Telefon_Rehberi__Uygulaması
{
    public class Operations
    {
        List<Person> personList = new List<Person>();

        public void Exit()
        {
            Console.WriteLine("Menüye Dönmek İçin 1'E Basın!! :)");
            int cikis = int.Parse(Console.ReadLine());
        }

        public Operations()
        {
            personList.Add(new Person("Hakan", "Uçar", "147258"));
            personList.Add(new Person("Beren", "Saat", "333333"));
            personList.Add(new Person("Müzeyyen", "Tutkulu", "124536"));
            personList.Add(new Person("Yağmur", "Uçar", "469823"));
            personList.Add(new Person("Ceren", "Civciv", "753684"));
            personList.Add(new Person("Cansun", "Gemi", "777777"));
            personList.Add(new Person("ibo", "owo", "333333"));
        }

        public bool control(int entry)
        {
            if (entry > 0)
                return true;
            else
                return false;
        }
        public void getArayuz()
        {

            Console.Write(
                "Lütfen yapmak istediğiniz işlemi seçiniz :) " +
                "\n********************************************" +
                "\n(1) Yeni Numara Kaydetmek" +
                "\n(2) Varolan Numarayı Silmek" +
                "\n(3) Varolan Numarayı Güncelleme" +
                "\n(4) Rehberi Listelemek" +
                "\n(5) Rehberde Arama Yapmak" +
                "\n(*)Çıkmak Herhangi Bir Tuşa Basabilirsiniz" +
                "\nSeçiminiz : ");

        }
        public void addPerson()
        {
            Console.WriteLine("******* Kisi Ekleme *******");
            Console.Write("Lütfen isim giriniz            :");
            string name = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz         :");
            string lastname = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz:");
            string phone = Console.ReadLine();
            personList.Add(new Person(name, lastname, phone));
            Console.WriteLine("Ekleme işlemi başarılı :)");
            Exit();


        }
        public void deleteNumber()
        {
            int cikis = 0;
            Console.WriteLine("******* Kisi Silme *******");

            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string search = Console.ReadLine();
            int counter = 0;


            for (int i = 0; i < personList.Count && counter == 0; i++)
            {

                if (search.ToUpper() == personList[i].Name.ToUpper() || search.ToUpper() == personList[i].Surname.ToUpper())
                {
                    counter++;

                    Console.WriteLine("{0}-{1} rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", Convert.ToString(personList[i].Name.ToUpper()), Convert.ToString(personList[i].Surname.ToUpper()));
                    char answer = Convert.ToChar(Console.ReadLine());
                    if (answer == 'y')
                    {

                        personList.RemoveAt(i);
                        Console.WriteLine("Silme işlemi başarıyla gerçekleşti..");


                    }
                }
            }


            if (counter == 0)
            {
                Console.WriteLine(
                      "Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız." +
                      "\n*Silmeyi sonlandırmak için : (1)" +
                      "\n*Yeniden denemek için      : (2)" +
                      "\nSeçiminiz ");
                cikis = int.Parse(Console.ReadLine());
                if (cikis == 2)
                    deleteNumber();
                else
                    Exit();

            }
            else
                Exit();
        }
        public void updateNumber()
        {
            int cikis = 0;
            Console.WriteLine(
                "****** Numara Güncelleme ******");

            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string search = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < personList.Count && count == 0; i++)
            {
                if (search.ToUpper() == personList[i].Name.ToUpper() || search.ToUpper() == personList[i].Surname.ToUpper())
                {
                    count++;
                    Console.WriteLine("{0} {1} İsmli kişi rehberde bulundu lütfen numarasını Güncelleyiniz", personList[i].Name.ToUpper(), personList[i].Surname.ToUpper());
                    Console.Write("İsim :");
                    personList[i].Name = Console.ReadLine();
                    Console.Write("Soyisim :");
                    personList[i].Surname = Console.ReadLine();
                    Console.Write("Telefon Numarası :");
                    personList[i].Phone = Console.ReadLine();


                    Console.WriteLine("Güncelleme işlemi başarılı :))");

                }

            }
            if (count == 0)
            {
                Console.WriteLine(
                        "Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız." +
                        "\n*Güncellemeyi sonlandırmak için : (1)" +
                        "\n*Yeniden denemek için           : (2)" +
                        "\nSeçiminiz :");
                cikis = int.Parse(Console.ReadLine());
                if (cikis == 2)
                    updateNumber();
                else
                    Exit();
            }
            else
                Exit();

        }
        public void listDictionary()
        {
            Console.WriteLine(
                "\nTelefon Rehberi" +
                "\n*****************************************");
            foreach (var item in personList)
            {
                Console.WriteLine(
                    "İsim :{0}" +
                    "\n " +
                    "\nSoyisim :{1}" +
                    "\n " +
                    "\nTelefon Numarası :{2}" +
                    "\n " +
                    "\n***************************" +
                    "\n", item.Name, item.Surname, item.Phone);

            }
            Exit();
        }
        public void searchDirection()
        {
            int count = 0;
            int answer;
            string search;
            Console.Write(
                "Arama yapmak istediğiniz tipi seçiniz." +
                "\n**********************************************" +
                "\nİsim veya soyisime göre arama yapmak için: (1)" +
                "\nTelefon numarasına göre arama yapmak için: (2)" +
                "\nSeçiminiz :");
            answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                Console.Write("Lütfen Bulmak İstediğiniz Kişinin İsmini veya Soyismini Giriniz :");
                search = Console.ReadLine();
                Console.Write(
                    "Arama Sonuçlarınız :" +
                    "\n**********************************************" +
                    "\n");
                for (int i = 0; i < personList.Count; i++)
                {
                    if (search.ToUpper() == personList[i].Name.ToUpper() || search.ToUpper() == personList[i].Surname.ToUpper())
                    {
                        count++;

                        Console.WriteLine(
                   "İsim :{0}" +
                   "\n " +
                   "\nSoyisim :{1}" +
                   "\n " +
                   "\nTelefon Numarası :{2}" +
                   "\n " +
                   "\n***************************" +
                   "\n" +
                   "\n", personList[i].Name, personList[i].Surname, personList[i].Phone);

                    }

                }
            }
            if (answer == 2)
            {
                Console.Write("Lütfen Bulmak İstediğiniz Kişinin Telefon Numarasını Giriniz :");
                search = Console.ReadLine();
                for (int i = 0; i < personList.Count; i++)
                {
                    if (search == personList[i].Phone)
                    {
                        count++;
                        Console.WriteLine(
                      "İsim :{0}" +
                      "\n " +
                      "\nSoyisim :{1}" +
                      "\n " +
                      "\nTelefon Numarası :{2}" +
                      "\n " +
                      "\n***************************" +
                      "\n", personList[i].Name, personList[i].Surname, personList[i].Phone);
                    }

                }

            }
            if (count == 0)
            {
                Console.WriteLine(
                  "Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız." +
                  "\n*Aramayı sonlandırmak için : (1)" +
                  "\n*Yeniden denemek için      : (2)");
                int cikis = int.Parse(Console.ReadLine());
                if (cikis == 2)
                    searchDirection();
                else
                    Exit();
            }
            else
                Exit();
        }
    }
}






