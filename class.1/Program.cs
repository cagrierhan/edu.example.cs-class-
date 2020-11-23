using System;

namespace Class
{
    class evHalkı
    {
        public string Name;
        public int DogYil;
        public string EyeColor;
        public string Job;
        public void Bilgi()
        {
            Console.WriteLine("İsim-Soyisim : {0}", Name);
            Console.WriteLine("Doğum Yılı: {0}", DogYil);
            Console.WriteLine("Yaşı : {0}", Age());
            Console.WriteLine("İşiniz : {0}", Job);
            Console.WriteLine("Göz Renginiz : {0}", EyeColor);
            Console.WriteLine("===================================");
        }
        public int Age()
        {
            return 2020 - DogYil;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            evHalkı annem = new evHalkı();
            {
                annem.Name = "Arzu Erinmez";
                annem.DogYil = 1980;
                annem.Job = "Ticaret";
                annem.EyeColor = "Kahverengi";
                annem.Age();

                annem.Bilgi();
            }
            evHalkı kardesim = new evHalkı();
            {
                kardesim.Name = "Çağla Yade Erhan";
                kardesim.DogYil = 2000;
                kardesim.Job = "Öğrenci";
                kardesim.EyeColor = "Kahverengi";
                kardesim.Age();
                kardesim.Bilgi();
            }
            evHalkı ben = new evHalkı();
            {
                ben.Name = "Çağrı Erhan";
                ben.DogYil = 1999;
                ben.Job = "Öğrenci";
                ben.EyeColor = "Kahverengi";
                ben.Age();

                ben.Bilgi();
            }

        }

    }
}



