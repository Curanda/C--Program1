namespace ConsoleApp1;

public class Zamowienie
{
    private DateTime dataRealizacji;
    private string nazwaKlienta;
    private List<Sprzedaz> zamowienia;

    public Zamowienie(DateTime dataRealizacji, string nazwaKlienta, int i)
    {
        this.nazwaKlienta = nazwaKlienta;
        this.dataRealizacji = dataRealizacji.AddDays(3);
        zamowienia = new List<Sprzedaz>(i);
    }

    public void dodajPozycje(Sprzedaz pozycja)
    {
        zamowienia.Add(pozycja);
    }

    public void dodajPozycje(string p, int a, decimal sP)
    {
        zamowienia.Add(new Sprzedaz(p, a, sP));
    }

    public void pokazZamowienie()
    {
        string dataRealizacjiString = dataRealizacji.ToString();
        Console.WriteLine($"Zamowienie dla {nazwaKlienta}, do realizacji {dataRealizacjiString.Remove(dataRealizacjiString.Length-9)}. Liczba pozycji na zamowieniu {zamowienia.Count}. Pozycje:");
        int licznik = 0;
        foreach (var i in zamowienia)
        {
            licznik += 1;
            Console.WriteLine($"{licznik}. " + i.getPozycja().ToString().Trim('(',')'));
        }
    }
    
}