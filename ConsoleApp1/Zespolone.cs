using System.Numerics;
using static System.Numerics.Complex;
using System.Text.RegularExpressions;

namespace ConsoleApp1;

// Troche nad tym posiedzialem i wydaje mi sie ze jest calkiem spoko. Uzylem regex do
// wyciagania wartosci z inputu i przypisywania ich do pol.
// Nastepnie uzylem biblipoteki .net do liczb zespolonych zeby ladnie zrobic operacje na tych liczbach.

public class Zespolone
{
    private string liczba1, liczba2;
    private static double cr1, cr2, cu1, cu2;
    
    
    public Zespolone()
    {
        Console.WriteLine("Podaj pierwszą liczbe zespoloną w formacie x,y:");
        liczba1 = Console.ReadLine();
        Console.WriteLine("Podaj pierwszą druga zespoloną w formacie x,y:");
        liczba2 = Console.ReadLine();
        Console.WriteLine($"Pierwsza liczba zespolona to {liczba1}i, druga liczba zespolona to {liczba2}i");
        konwersjaDanych(liczba1, liczba2);
    }

    private void konwersjaDanych(string liczba1, string liczba2)
    {
        string pattern = @"(-?\d{1,3}),(-?\d{1,3})";
        Match match1 = Regex.Match(liczba1, pattern);
        Match match2 = Regex.Match(liczba2, pattern);
        try
        {
            if (match1.Success) cr1 = Convert.ToDouble(match1.Groups[1].Value);
            if (match1.Success) cu1 = Convert.ToDouble(match1.Groups[2].Value);
            if (match2.Success) cr2 = Convert.ToDouble(match2.Groups[1].Value);
            if (match2.Success) cu2 = Convert.ToDouble(match2.Groups[2].Value);
        }
        catch (FormatException e)
        {
            
            // Tutaj przydalby sie panski komentarz/poprawka - cyfry/liczby sie konwertuja poprawnie,
            // ale za slabo znam regex zeby ujac wiecej warunkow, w tym przypadku wprowadzenie zlego formatu danych
            // wcale nie wyrzuca bledu, ale redefiniuje mi zmienne na 0,0. Jesli ma pan jakis pomysl to bylbym wdzieczny.
            Console.WriteLine("Zlt format danych" + e);
        }
    }

    public void dodajZespolone()
    { 
        Complex c1 = new Complex(cr1,cu1); 
        Complex c2 = new Complex(cr2,cu2);
        Console.WriteLine($"Liczby zespolone {liczba1}i oraz {liczba2}i dodane do siebie daja: ");
        Console.WriteLine(Add(c1, c2).ToString().Trim('<','>')+"i");
    }

    public void odejmijZespolone()
    {
        Complex c1 = new Complex(cr1,cu1); 
        Complex c2 = new Complex(cr2,cu2);
        Console.WriteLine($"Liczby zespolone {liczba1}i oraz {liczba2} odjete od siebie daja: ");
        Console.WriteLine(Subtract(c1, c2).ToString().Trim('<','>')+"i");
    }

    public void pomnozZespolone()
    {
        Complex c1 = new Complex(cr1,cu1); 
        Complex c2 = new Complex(cr2,cu2);
        Console.WriteLine($"Liczby zespolone {liczba1}i oraz {liczba2}i pomnozone przez siebie daja: ");
        Console.WriteLine(Multiply(c1, c2).ToString().Trim('<','>')+"i^2");
    }

    public void podzielZespolone()
    {
        Complex c1 = new Complex(cr1,cu1); 
        Complex c2 = new Complex(cr2,cu2);
        Console.WriteLine($"Liczby zespolone {liczba1}i oraz {liczba2}i podzielone przez siebie daja: ");
        Console.WriteLine(Divide(c1, c2).ToString().Trim('<','>'));
    }

    public void wypiszZespolone()
    {
        Console.WriteLine($"Pierwsza liczba zespolona to {liczba1}i, druga liczba zespolona to {liczba2}i");
    }
    
}