namespace ConsoleApp1;

public class Wektor
{
    private int[] wektor = new int[4];

    public Wektor(int[] wektor)
    {
        this.wektor = wektor;
    }

    public void show()
    {
        Console.WriteLine($"Wektor o wspolrzednych : x1={wektor[0]}, y1={wektor[1]}, x2={wektor[2]}, y2={wektor[3]}");
    }

    public void addCoords()
    {
        int suma = 0;
        foreach (var item in wektor)
        {
            suma += item;
        }
        Console.WriteLine($"Suma wspolrzednych wektora bazowego: {suma}");
    }

    public void addVectors(int[] wektor2)
    {
        int[] zsumowanyWektor = new int[wektor2.Length];
        for (int i = 0; i < wektor2.Length; i++)
        {
            zsumowanyWektor[i] = wektor2[i] + wektor[i];
        }
        string zsumowanyWektorText2 = string.Join(" , ", zsumowanyWektor.Select(i => i.ToString()));

        Console.WriteLine($"Suma podanego wektora oraz wektora bazowego to: {zsumowanyWektorText2}");
    }
    
}