using System.Numerics;
using RandomString4Net;

namespace ConsoleApp1;

public class RandomUtility
{
    // Obiekt wbudowanej klasy Random.
    private Random rand = new Random();
    public void randomInt(int a, int b)
    {
        Console.WriteLine("********* randomInt *********");
        Console.WriteLine(rand.Next(a,b));
    }
    
    // Mam nadzieję, ze to nie jest kontrowersyjne rozwiazanie,
    // ale decimale bardzo chetnie sie konwertuja na double i na odwrot
    public void randomDecimal(decimal a, decimal b)
    {
        Console.WriteLine("********* randomDecimal *********");
        double nowyA = decimal.ToDouble(a);
        double nowyB = decimal.ToDouble(b);
        double nowyDouble = rand.NextDouble();
        Console.WriteLine(new decimal(nowyDouble*(nowyB-nowyA)+nowyA));
    }
    public void randomDouble(double a, double b)
    {
        double nowyDouble = rand.NextDouble();
        Console.WriteLine("********* randomDouble *********");
        Console.WriteLine(nowyDouble*(b-a)+a);
    }
    public void randomString(int n)
    {
        // uwaga!! tutaj uzywam nuget package RandomString4Net, a wiec trzeba pobrac pakiet zeby dzialalo.
        // Nie mniej jednak w tresci zadania nie jest wyszczegolnione ze nie mozna korzystac z zewnetrznych
        // bibliotek, a wiec kierujac sie maksyma, ze nie ma sensu wywazac otwartych drzwi...
        // Innym rozwiazaniem jest petla for, ktora ma dlugosc n i dodaje do pustego stringa litery za pomoca 
        // getElementAt(r), gdzie r generuje obiekt klasy Random z zakresu 0-n.
        // https://www.nuget.org/packages/RandomString4Net
        List<string> randomS = RandomString.GetStrings(Types.ALPHABET_LOWERCASE,1, n);
        Console.WriteLine("************ randomString ***********");
        Console.WriteLine(randomS[0]);
    }
    
    
    public void randomFromArray<T>(int n, T[] a, bool rep)
    // type generyczny T musi byc zeby mozna bylo wrzucic tablice dowolnego typu.
    {
        // Tu dla powtarzalnych elementow.
        if (rep)
        {
            Console.WriteLine("****** randomFromArray reps=true **********");
            for (int i=0; i<n; i++)
            {
                int r = rand.Next(a.Length);
                Console.WriteLine(a[r]);
            }    
        }
        else
        // Tu dla unikalnych.
        {
            Console.WriteLine("****** randomFromArray reps=false **********");
            // zastosowałem wbudowany type IEnumerable dla wyciagania unikalnych wynikow. IEnumerable dziala na listach.
            // w zwiazku z tym musimy wypisac elementy tablicy do listy i przepisac ja do IEnumerable.
            List<T> wynik = new List<T>();
            IEnumerable<T> distinctW = wynik.Distinct(); // z kazda aktualizacja zawartosci wyniku, aktualizujemy unikaty.
            
            // zapelniamy losowo liste wynik.
            // Po zapelnieniu wynik, distinctW bedzie jednakze pomniejszony o elementy powtorzone.
            for (int i=0; i<n; i++)
            {
                int r = rand.Next(a.Length);
                wynik.Add(a[r]);
            }  
            
            // zeby uzupelnic distinctW musimy dopisac brakujace n-distinctW.Count() elementow.
            while (distinctW.Count() != n)
            {
                int r = rand.Next(a.Length);
                wynik.Add(a[r]);
            }
            // otrzymujemy n-elementowy distinctW z unikatowymi elementami.
            // Jesli sie Pan zastanawia czy nie lepiej dodawac losowe elementy od razu do distinctW,
            // to mowie ze na pewno sie da, ale szybciej to było na moją logikę rozbić na dwsa osobne kroki.

            string wynikString = string.Join(",", distinctW.ToArray());
            // Wiec nie wiem czy takie wypisywanie zadziala na wszystkich typach tablicy (nie sprawdzalem na
            // tablicy obiektow), ale dla prostego wypisywania foreach tez da rade, jakos ladniej jednak jest z
            // przecinkami i wjednej linii.
            Console.WriteLine(wynikString);
        }
    }
}