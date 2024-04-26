using System;
using System.Collections;
using ConsoleApp1;

class Program
{
    public static List<Produkt> produkty = new List<Produkt>();
    
    public static int Main(string[] args)
    {
        
        // utworzProdukt();
        // utworzProdukt();
        // wypiszProdukty();

        // Zespolone liczby = new Zespolone();
        // liczby.dodajZespolone();
        // liczby.odejmijZespolone();
        // liczby.pomnozZespolone();
        // liczby.podzielZespolone();

        // Zamowienie zamowienie1 = new Zamowienie( DateTime.Now, "Pan Benek", 5 );
        // zamowienie1.dodajPozycje(new Sprzedaz("Mleko",3,10));
        // zamowienie1.dodajPozycje("Chleb",2,5);
        // zamowienie1.pokazZamowienie();
        
        return 0;
    }
    
    public static void utworzProdukt()
    {
        Console.WriteLine("Stworzymy produkt. \n Wprowadz dane produktu to dodania.\n Podaj nazwe produktu: ");
        Produkt produkt = new Produkt();
        produkty.Add(produkt);
        Console.WriteLine("\n Produkt utworzony");
    }
    
    public static void wypiszProdukty()
    {
        Console.WriteLine("W magazynie mamy nastepujace produkty : \n");
        foreach (var produkt in produkty)
        {
            Console.WriteLine("****************");
            produkt.wypiszDaneProduktu();
            Console.WriteLine("****************");
        }
    }
}

