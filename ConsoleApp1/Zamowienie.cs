namespace ConsoleApp1;

public class Zamowienie
{
    private DateTime dataRealizacji;
    private string nazwaKlienta;
    private List<Sprzedaz> zamowienia;

    public Zamowienie(DateTime dataRealizacji, string nazwaKlienta, int i)
    {
        this.nazwaKlienta = this.nazwaKlienta;
        this.dataRealizacji = this.dataRealizacji;
        this.zamowienia = new List<Sprzedaz>(i);
    }

    public void dodajPozycje(Sprzedaz pozycja)
    {
        zamowienia.Add(pozycja);
    }

    public void dodajPozycje(string p, int a, decimal sP)
    {
        zamowienia.Add(new Sprzedaz(p, a, sP));
    }

    public string pokazZamowienie()
    {
        foreach (var i in zamowienia)
        {
            return 
        }
    }
    
}