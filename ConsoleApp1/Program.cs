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

        RandomUtility randomizer = new RandomUtility();
        randomizer.randomInt(2,54);
        randomizer.randomDouble(2.33,76.77);
        randomizer.randomDecimal(1.99m, 7.85m);
        randomizer.randomString(6);
        int[] tablica = new[] {1,5,7,2,8,0,4,5,2,43,67,53454,657,345,7657,3433,56,4};
        randomizer.randomFromArray(6, tablica, true);
        
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

