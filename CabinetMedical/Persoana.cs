using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetMedical
{
    internal abstract class Persoana
    {
        private String nume;
        private String prenume;
        private String CNP;

        public Persoana()
        {

        }
        public Persoana(string nume, string prenume, string cNP)
        {
            this.nume = nume;
            this.prenume = prenume;
            CNP = cNP;
        }

        public override string ToString()
        {
            return $"Nume {nume} prenume {prenume} CNP {CNP}";
        }
    }
}
