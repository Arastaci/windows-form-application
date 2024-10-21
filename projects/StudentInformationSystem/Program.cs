using System;

class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci = new Ogrenci(12345, "John", "Doe", 60, 65, 80, ".. Üniversitesi");

        bool devam = true;
        while (devam)
        {
            Console.WriteLine("\nLütfen bir seçenek seçin:");
            Console.WriteLine("1- Öğrenci Bilgilerini Göster");
            Console.WriteLine("2- Öğrenci Ortalamasını Göster");
            Console.WriteLine("3- Öğrencinin Okulunu Göster");
            Console.WriteLine("4- Çıkış Yap");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    ogrenci.OgrenciBilgileriniGoster();
                    break;
                case "2":
                    double ortalama = ogrenci.OgrenciOrtalamasiBul();
                    Console.WriteLine($"Öğrencinin Ortalaması: {ortalama}");
                    break;
                case "3":
                    string okul = ogrenci.OkulGetir();
                    Console.WriteLine($"Öğrencinin Okulu: {okul}");
                    break;
                case "4":
                    devam = false;
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                    break;
            }
        }
    }
}
