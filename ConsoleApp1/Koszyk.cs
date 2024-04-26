namespace ConsoleApp1;

public class Koszyk
{
    private List<Produkt> koszyk = new List<Produkt>();
    

    public void dodajDoKoszyka(Produkt produkt)
    {
        koszyk.Add(produkt);
    }

    public void pokazKoszyk()
    {
        Console.WriteLine($"W koszyku jest obecnie {koszyk.Count} produktów.");
        double sumaCen = 0;
        foreach (var produkt in koszyk)
        {
            sumaCen += produkt.wypiszCene();
        }

        Console.WriteLine($"Do zapłacenia {sumaCen}");
    }
    
}