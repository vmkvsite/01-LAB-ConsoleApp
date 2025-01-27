using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ElektronickiUredjaj
{
    public string Naziv { get; set; }
    public string Proizvodjac { get; set; }
    public int GodinaProizvodnje { get; set; }

    public ElektronickiUredjaj(string naziv, string proizvodjac, int godinaProizvodnje)
    {
        Naziv = naziv;
        Proizvodjac = proizvodjac;
        GodinaProizvodnje = godinaProizvodnje;
    }

    public void IspisiInformacije()
    {
        Console.WriteLine($"Naziv: {Naziv}, Proizvođač: {Proizvodjac}, Godina proizvodnje: {GodinaProizvodnje}");
    }
}
