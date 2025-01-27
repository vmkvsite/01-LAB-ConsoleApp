namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kreiranje objekta tipa Proizvod
            Proizvod p = new Proizvod("Laptop", 7999.99m, 10);

            // Pozivanje metode za ispis informacija
            p.IspisiInformacije();

            Console.ReadLine(); // Zaustavlja konzolu da vidimo rezultat

            // Kreiranje objekta PametniTelefon
            PametniTelefon telefon = new PametniTelefon("Galaxy S24", "Samsung", 2024, "Android");

            // Pozivanje metoda
            telefon.IspisiInformacije();
            telefon.InstalirajAplikaciju("WhatsApp");

            Console.ReadLine(); // Zaustavlja konzolu da vidimo rezultat
        }
    }
}
