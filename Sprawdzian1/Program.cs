using Sprawdzian1;

internal class Program
{
    public static void Main(string[] args)
    {
        //zad1
        Console.WriteLine("ZADANIE 1");
        string tekst = "Ala ma kota";
        int klucz = 3;
        string zaszyfrowanyTekst = Szyfrowanie.ZaszyfrujCezar(tekst, klucz);
        string odszyfrowanyTekst = Szyfrowanie.OdszyfrujCezar(zaszyfrowanyTekst, klucz);

        Console.WriteLine(zaszyfrowanyTekst); 
        Console.WriteLine(odszyfrowanyTekst);
        //zad3

        Console.WriteLine("ZADANIE 3");

        Student student1 = new Student("Michał", "Brzoza", "JanekOgarek", "haslo123", 2022);
        Console.WriteLine(" ");
        Console.WriteLine("Dane studenta 1: " + student1.ToString());
        Console.WriteLine("Rocznik studiów: " + student1.rocznikStudiow);
        Console.WriteLine(" ");
        Console.WriteLine(student1.UkryjLogin()); 
        Console.WriteLine(student1.UkryjHaslo()); 
        Console.WriteLine(student1.PokazLogin());
        Console.WriteLine(student1.PokazHaslo());
   
        Student student2 = new Student("Jan", "Kowalski", "20220002", "haslo456", 2022);
        Console.WriteLine(" ");
        Console.WriteLine("Dane studenta 2: " + student2.ToString());
        Console.WriteLine("Rocznik studiów: " + student2.rocznikStudiow);
        Console.WriteLine(" ");
        Console.WriteLine(student2.UkryjLogin());
        Console.WriteLine(student2.UkryjHaslo());
        Console.WriteLine(student2.PokazLogin());
        Console.WriteLine(student2.PokazHaslo());
        Console.WriteLine(" ");
        if (student1.Equals(student2))
        {
            Console.WriteLine("Obiekty są identyczne");
        }
        else
        {
            Console.WriteLine("Obiekty są różne");
        }
        Console.WriteLine(" ");
        Console.WriteLine("ZADANIE 4");
        Wydzial wydzial = new Wydzial();

        
        wydzial.DodajStudenta(student1);
        wydzial.ZmienHaslo(student1, "haslo123", "NoweHaslo123");
        wydzial.ZmienLogin(student1, "JanekOgarek", "JKowalski");
        Console.WriteLine();

       
        wydzial.DodajStudenta(student2);
        wydzial.ZmienHaslo(student2, "Now123", "NoweHaslo456");

    }
}
