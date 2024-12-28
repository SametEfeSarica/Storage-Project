namespace Storage_Project
{
    using System;

    class Program
    {
        static void Main()
        {

            double bakiye = 1000.0;


            double elmaFiyatAl = 7.0, elmaFiyatSat = 14.0;
            double muzFiyatAl = 15.0, muzFiyatSat = 37.0;
            double portakalFiyatAl = 6.0, portakalFiyatSat = 15.0;
            double uzumFiyatAl = 14.0, uzumFiyatSat = 25.0;


            int elmaAdet = 0, muzAdet = 0, portakalAdet = 0, uzumAdet = 0;

            while (true)
            {
                Console.WriteLine("\nHoşgelginiz");
                Console.WriteLine("1. Ürün Al");
                Console.WriteLine("2. Ürün Sat");
                Console.WriteLine("3. Bakiye Görüntüle");
                Console.WriteLine("4. Çıkış");
                Console.Write("Seçiminizi yapınız: ");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.WriteLine("\nAlmak istediğiniz ürünü seçin:");
                        Console.WriteLine("1. Elma - 7 TL");
                        Console.WriteLine("2. Muz - 15 TL");
                        Console.WriteLine("3. Portakal - 6 TL");
                        Console.WriteLine("4. Üzüm - 14 TL");
                        Console.Write("Seçim: ");
                        string urunAl = Console.ReadLine();

                        Console.Write("Kaç adet almak istiyorsunuz? ");
                        int adetAl = int.Parse(Console.ReadLine());

                        double toplamFiyat = 0;
                        switch (urunAl)
                        {
                            case "1":
                                toplamFiyat = adetAl * elmaFiyatAl;
                                if (toplamFiyat <= bakiye)
                                {
                                    bakiye -= toplamFiyat;
                                    elmaAdet += adetAl;
                                    Console.WriteLine($"{adetAl} adet elma alındı.");
                                }
                                else Console.WriteLine("Yetersiz bakiye!");
                                break;

                            case "2":
                                toplamFiyat = adetAl * muzFiyatAl;
                                if (toplamFiyat <= bakiye)
                                {
                                    bakiye -= toplamFiyat;
                                    muzAdet += adetAl;
                                    Console.WriteLine($"{adetAl} adet muz alındı.");
                                }
                                else Console.WriteLine("Yetersiz bakiye!");
                                break;

                            case "3":
                                toplamFiyat = adetAl * portakalFiyatAl;
                                if (toplamFiyat <= bakiye)
                                {
                                    bakiye -= toplamFiyat;
                                    portakalAdet += adetAl;
                                    Console.WriteLine($"{adetAl} adet portakal alındı.");
                                }
                                else Console.WriteLine("Yetersiz bakiye!");
                                break;

                            case "4":
                                toplamFiyat = adetAl * uzumFiyatAl;
                                if (toplamFiyat <= bakiye)
                                {
                                    bakiye -= toplamFiyat;
                                    uzumAdet += adetAl;
                                    Console.WriteLine($"{adetAl} adet üzüm alındı.");
                                }
                                else Console.WriteLine("Yetersiz bakiye!");
                                break;

                            default:
                                Console.WriteLine("Geçersiz seçim!");
                                break;
                        }
                        break;

                    case "2":
                        Console.WriteLine("\nSatmak istediğiniz ürünü seçin:");
                        Console.WriteLine($"1. Elma - {elmaAdet} adet - 14 TL");
                        Console.WriteLine($"2. Muz - {muzAdet} adet - 37 TL");
                        Console.WriteLine($"3. Portakal - {portakalAdet} adet - 15 TL");
                        Console.WriteLine($"4. Üzüm - {uzumAdet} adet - 25 TL");
                        Console.Write("Seçim: ");
                        string urunSat = Console.ReadLine();

                        Console.Write("Kaç adet satmak istiyorsunuz? ");
                        int adetSat = int.Parse(Console.ReadLine());

                        double toplamKazanc = 0;
                        switch (urunSat)
                        {
                            case "1":
                                if (adetSat <= elmaAdet)
                                {
                                    toplamKazanc = adetSat * elmaFiyatSat;
                                    bakiye += toplamKazanc;
                                    elmaAdet -= adetSat;
                                    Console.WriteLine($"{adetSat} adet elma satıldı.");
                                }
                                else Console.WriteLine("Yeterli ürün yok!");
                                break;

                            case "2":
                                if (adetSat <= muzAdet)
                                {
                                    toplamKazanc = adetSat * muzFiyatSat;
                                    bakiye += toplamKazanc;
                                    muzAdet -= adetSat;
                                    Console.WriteLine($"{adetSat} adet muz satıldı.");
                                }
                                else Console.WriteLine("Yeterli ürün yok!");
                                break;

                            case "3":
                                if (adetSat <= portakalAdet)
                                {
                                    toplamKazanc = adetSat * portakalFiyatSat;
                                    bakiye += toplamKazanc;
                                    portakalAdet -= adetSat;
                                    Console.WriteLine($"{adetSat} adet portakal satıldı.");
                                }
                                else Console.WriteLine("Yeterli ürün yok!");
                                break;

                            case "4":
                                if (adetSat <= uzumAdet)
                                {
                                    toplamKazanc = adetSat * uzumFiyatSat;
                                    bakiye += toplamKazanc;
                                    uzumAdet -= adetSat;
                                    Console.WriteLine($"{adetSat} adet üzüm satıldı.");
                                }
                                else Console.WriteLine("Yeterli ürün yok!");
                                break;

                            default:
                                Console.WriteLine("Geçersiz seçim!");
                                break;
                        }
                        break;

                    case "3":
                        Console.WriteLine($"Mevcut bakiye: {bakiye} TL");
                        break;

                    case "4":
                        Console.WriteLine("Programdan çıkılıyor. İyi günler!");
                        return;

                    default:
                        Console.WriteLine("Geçersiz seçim! Lütfen tekrar deneyin.");
                        break;
                }
            }
        }
    }

}
