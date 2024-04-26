namespace ConsoleApp1;

public class Sprzedaz
{
    private String p;
    private Int32 a;
    private Decimal sP;

    public Sprzedaz(string p, int a, decimal sP)
    {
        this.p = p;
        this.a = a;
        this.sP = sP;
    }

    public void getPozycja<t>() where t : String, Int32, Decimal
    {
        return p, a, sP;
    }
}