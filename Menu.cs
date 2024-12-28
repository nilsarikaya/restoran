using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Menu
    {
        public static List<Yemek> Corba = new List<Yemek>()
        {
            new Yemek() { No = 1, Ad = "Mercimek", Fiyat = 45},
            new Yemek() { No = 2, Ad = "Tavuk Suyu", Fiyat = 60.50},
            new Yemek() { No = 3, Ad = "Domates", Fiyat = 50 }
        };
        public static List<Yemek> Salata = new List<Yemek>(){


            new Yemek() { No = 1, Ad = "Çoban Salata", Fiyat = 30 },
            new Yemek() { No = 2, Ad = "Mevsim Salata", Fiyat = 35 },
            
        };
        public static List<Yemek> Makarna = new List<Yemek>()
        {
            new Yemek() { No = 1, Ad = "Fettucini", Fiyat = 180 },
            new Yemek() { No = 2, Ad = "Penne", Fiyat = 130 },
            new Yemek() { No = 3, Ad = "Mantı", Fiyat = 150 },
        };
        public static List<Yemek> Kebap= new List<Yemek>()
        {
            new Yemek() { No = 1, Ad = "Beyti", Fiyat = 250 },
            new Yemek() { No = 2, Ad = "Adana Kebap", Fiyat = 125 },
            new Yemek() { No = 3, Ad = "Tavuk Şiş", Fiyat = 100 }
        };
        public static List<Yemek> Tatlı = new List<Yemek>()
        {
            new Yemek() { No = 1, Ad = "Künefe", Fiyat = 180 },
            new Yemek() { No = 2, Ad = "Katmer", Fiyat = 200 },
            new Yemek() { No = 3, Ad = "Baklava", Fiyat = 150 }
        };
        public static List<Yemek> Icecek = new List<Yemek>()
        {
            new Yemek() { No = 1, Ad = "Gazlı İçecekler", Fiyat = 90 },
            new Yemek() { No = 2, Ad = "Ayran", Fiyat = 50},
            new Yemek() { No = 3, Ad = "Çay", Fiyat = 20 }
        };



        public static Yemek siparis()
        {
            ArrayList menuler = new ArrayList() { Corba,Salata, Makarna, Kebap, Tatlı, Icecek};
            Console.WriteLine("1-Çorba\n2-Salata\n3-Makarna\n4-Kebap\n5-Tatlı\n6-İçecek\nSeçim:");
            int menuSecim = Convert.ToInt32(Console.ReadLine());
            if (menuSecim > 0 && menuSecim < 7)
            {
                foreach (Yemek menu in (List<Yemek>)menuler[menuSecim - 1])
                {
                    Console.WriteLine(menu.No + "-" + menu.Ad + ":" + menu.Fiyat);
                }
                Console.WriteLine("Seçiminiz:");
                int secimYemek = Convert.ToInt32(Console.ReadLine());
                var yemek = ((List<Yemek>)menuler[menuSecim - 1])[secimYemek - 1];
                if (yemek == null)
                {
                    Console.WriteLine("Geçerli seçim yapınız");
                    return null;
                }
                return yemek;
            }
            else
            {
                Console.WriteLine("Hatalı Menü Seçildi!!");
            }

            return null;



        }
    }
}
