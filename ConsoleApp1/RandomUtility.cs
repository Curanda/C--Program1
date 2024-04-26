using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
using RandomString4Net;

namespace ConsoleApp1;

/* W klasie zdefiniuj metody:

      a) do losowego generowania liczby z podanego przedziału dla różnych typów liczbowych ( int, decimal, double): randomInt(a, b), randomDecimal(a, b), randomDouble(a, b)
      b) do losowego generowania łańcucha znakowego (stringa) składającego się z n dowolnych znaków: randomString(n)
      dla uproszczenia można założyć, że string ma składać się wyłącznie z liter
      c) do losowego wybierania n elementów z podanej tablicy (z możliwością powtórzeń lub bez): randomFromArray(n, array, rep)
*/


public class RandomUtility
{
    private Random rand = new Random();
    public void randomInt(int a, int b)
    {
        Console.WriteLine(rand.Next(a,b));
    }
    public void randomDecimal(decimal a, decimal b)
    {
        double nowyA = decimal.ToDouble(a);
        double nowyB = decimal.ToDouble(b);
        double nowyDouble = rand.NextDouble();
        Console.WriteLine(new decimal(nowyDouble*(nowyB-nowyA)+nowyA));
    }
    public void randomDouble(double a, double b)
    {
        double nowyDouble = rand.NextDouble();
        Console.WriteLine(nowyDouble*(b-a)+a);
    }
    public void randomString(int n)
    {
        // uwaga!! tutaj uzywam nuget package RandomString4Net, a wiec trzeba pobrac pakiet zeby dzialalo.
        // Nie mniej jednak w tresci zadania nie jest wyszczegolnione ze nie mozna korzystac z zewnetrznych
        // bibliotek, a wiec kierujac sie maksyma, ze nie ma sensu wywazac otwartych drzwi...
        // Innym rozwiazaniem jest petla for, ktora ma dlugosc n i dodaje do pustego stringa litery za pomoca 
        // getElementAt(n).
        // https://www.nuget.org/packages/RandomString4Net
        List<string> randomS = RandomString.GetStrings(Types.ALPHABET_LOWERCASE,1, n);
        foreach (var s in randomS)
        {
            Console.WriteLine(s);
        }
    }
    public void randomFromArray<T>(int n, T[] a, bool rep)
    {
        if (!rep)
        {
            for (int i=0; i<n; i++)
            {
                int r = rand.Next(a.Length);
                Console.WriteLine(a[r]);
            }    
        }
        else
        {
            for (int i=0; i<n; i++)
            {
                int r = rand.Next(a.Length);
                Console.WriteLine(a[r]);
            }  
        }
        
    }
}