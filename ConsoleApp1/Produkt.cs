namespace ConsoleApp1;

public class Produkt
{
    private string nazwaProduktu, jednostkaMiary;
    private double cenaProduktu, marzaZysku;
    private int stawkaVAT;
    private DateTime dataZakupu;
    
    public Produkt(string nazwaProduktu, double cenaProduktu, string jednostkaMiary, double marzaZysku, int stawkaVAT)
    {
        this.nazwaProduktu = nazwaProduktu;
        this.cenaProduktu = cenaProduktu;
        this.jednostkaMiary = jednostkaMiary;
        this.stawkaVAT = stawkaVAT;
        this.marzaZysku = marzaZysku;
        this.dataZakupu = DateTime.Today;
    }
    
    public Produkt()
    {
        this.nazwaProduktu = Console.ReadLine();
        Console.WriteLine("Jaka ma byc cena produktu?");
        this.cenaProduktu = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Jaka ma byc jednostka miary?");
        this.jednostkaMiary = Console.ReadLine();
        Console.WriteLine("Jaka ma byc stawka VAT?");
        this.stawkaVAT = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Jaka ma byc marza zysku?");
        this.marzaZysku = Convert.ToDouble(Console.ReadLine());
        this.dataZakupu = DateTime.Today;
    }

    public void wypiszDaneProduktu()
    {
        Console.WriteLine($"Produkt o nazwie {nazwaProduktu}, \n cena : {cenaProduktu}, \n jednostki: {jednostkaMiary}, \n ze stawka VAT: {stawkaVAT}, \n ze sprzedazy mamy marze {marzaZysku}, \n produkt zakupiony do magazynu {dataZakupu}");
    }

    public double wypiszCene()
    {
        return cenaProduktu;
    }

    public string wypiszNazwe()
    {
        return nazwaProduktu;
    }
    
}