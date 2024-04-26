using System.Collections;

namespace ConsoleApp1;

public class Kalkulator
{
    
    public void KonwersjaKmNaMile(double km)
    {
        double metry = ((km * 1000) / 3600);
        Console.WriteLine($"Wynik konwersji {km} km/h na m/s to : {metry}");
    }

    public void CenaKalk(double cena)
    {
        Console.WriteLine($"Cena: {cena}, wys. VAT : {cena*0.22}, kw. brutto {cena+(cena*0.22)}");
    }
    
    public void BMI(double wzrost, double waga)
    {
        double bmi = waga / wzrost;
        string wynik = bmi switch
        {
            0 => "Wyglodzenie",
            > 0 and <= 15.1 => "Wyglodzenie",
            > 15.2 and <= 17.4 => "Wychudzenie",
            > 17.5 and <= 18.4 => "Niedowaga",
            > 18.5 and <= 24.9 => "Waga prawidlowa",
            > 25 and <= 29.9 => "Nadwaga",
            > 30 and <= 34.9 => "I stopien otylosci",
            > 35 and <= 39.9 => "II stopien otylosci",
            > 40 => "Otylosc skrajna"
        };
        Console.WriteLine($"BMI: {bmi}, {wynik}");
    }
    

}