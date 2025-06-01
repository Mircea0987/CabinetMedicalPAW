using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetMedical
{
    public class Cabinet : IComparable<Cabinet> , ICloneable
    {
        public Cabinet() { }
        public Cabinet(int id, string nume, string adresa, string telefon, int capacitate)
        {
            Id = id;
            Nume = nume;
            Adresa = adresa;
            Telefon = telefon;
            Capacitate = capacitate;
        }

        public Cabinet( string nume, string adresa, string telefon, int capacitate)
        {
            Nume = nume;
            Adresa = adresa;
            Telefon = telefon;
            Capacitate = capacitate;
        }

        public int Id { get; set; }
        public string Nume { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }

        public int Capacitate { get; set; }

        public object Clone()
        {
            return new Cabinet
            {
                Id = this.Id,
                Nume = this.Nume,
                Adresa = this.Adresa,
                Telefon = this.Telefon
            };

        }

        public int CompareTo(Cabinet other)
        {
           return Nume.CompareTo(other.Nume);
        }

        public override string ToString()
        {
            return $"Id = {Id} Nume {Nume} Adresa {Adresa} Telefon {Telefon} ";
        }

        public static bool operator ==(Cabinet c, Cabinet c2)
        {
            if(c.Id == c2.Id && c.Adresa.Equals(c2.Adresa) && c.Nume.Equals(c2.Nume) && c.Telefon.Equals(c2.Telefon))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Cabinet c, Cabinet c2)
        {
            return !(c == c2);
        }
    }
}
