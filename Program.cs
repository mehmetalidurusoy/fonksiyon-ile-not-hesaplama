bilgileriAl();

void bilgileriAl()
{
    Console.Write("Adınızı ve Soyadınızı Girin => ");
    string adsoyad = Console.ReadLine();

    Console.Write("Dersi Girin => ");
    string ders = Console.ReadLine();

    double not1 = sGir(1, "Notu Girin");
    double not2 = sGir(2, "Notu Girin");
    double not3 = sGir(3, "Notu Girin");


    ekranaBas(adsoyad,ders,not1, not2, not3);
}

void mesaj(string mesaj, ConsoleColor onrek = ConsoleColor.Gray)
{
    Console.ForegroundColor = onrek;
    Console.WriteLine($"{mesaj}");
    Console.ForegroundColor = ConsoleColor.Gray;
}

double sGir(int sayi = 0, string metin = "")
{
    Console.Write((sayi == 0 ? "" : sayi + ". "));
    Console.Write((metin == string.Empty ? "Alanı Girin" : metin));
    Console.Write(" => ");

    return Convert.ToInt32(Console.ReadLine());
}

void ekranaBas(string adsoyad,string ders,double not1, double not2, double not3)
{
    double ortalama = (not1 + not2 + not3) / 3;

    Console.Write("Ad ve Soyad: ");
    mesaj(adsoyad, ConsoleColor.Magenta);

    Console.Write("Ders: ");
    mesaj(ders, ConsoleColor.Cyan);

    Console.Write("Ortalama: ");
    mesaj(Convert.ToString(ortalama), ConsoleColor.Magenta);
    
    Console.Write("Durum: ");
    if(ortalama >= 50) { mesaj("Geçtiniz", ConsoleColor.Green); }
    else { mesaj("Kaldınız", ConsoleColor.Red); }
}