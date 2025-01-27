using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Proizvod
{
    // Svojstva
    public string Naziv { get; set; }
    public decimal Cijena { get; set; }
    public int DostupnaKolicina { get; set; }

    // Konstruktor
    public Proizvod(string naziv, decimal cijena, int dostupnaKolicina)
    {
        Naziv = naziv;
        Cijena = cijena;
        DostupnaKolicina = dostupnaKolicina;
    }

    // Metoda za ispis informacija
    public void IspisiInformacije()
    {
        Console.WriteLine($"Naziv: {Naziv}, Cijena: {Cijena} kn, Dostupna količina: {DostupnaKolicina}");
    }
}
