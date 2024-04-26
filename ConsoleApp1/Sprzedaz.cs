namespace ConsoleApp1;

public class Sprzedaz
{
    private string p;
    private int a;
    private decimal sP;

    public Sprzedaz(string p, int a, decimal sP)
    {
        this.p = p;
        this.a = a;
        this.sP = sP;
    }

    // uzylem covariant return, zeby zwrocic roznorodne typy
    public (string p, int a, decimal sP) getPozycja()
    {
        return (p, a, sP);
    }
}