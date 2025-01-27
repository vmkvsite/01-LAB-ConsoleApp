using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PametniTelefon : ElektronickiUredjaj
{
    public string OperativniSustav { get; set; }

    public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav)
        : base(naziv, proizvodjac, godinaProizvodnje)
    {
        OperativniSustav = operativniSustav;
    }

    public void InstalirajAplikaciju(string nazivAplikacije)
    {
        Console.WriteLine($"Aplikacija '{nazivAplikacije}' je uspješno instalirana na {Naziv}.");
    }
}
