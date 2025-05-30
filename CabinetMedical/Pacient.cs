using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetMedical
{
    internal class Pacient : Persoana
    {
        private int id;
        private DateTime dataNasterii;

        public Pacient() : base() { }

        public Pacient(int id, DateTime dataNasterii, string nume,string prenume,string CNP) : base(nume, prenume, CNP)
        {
            this.id = id;
            this.dataNasterii = dataNasterii;
        }

        public int Id { get => id; set => id = value; }
        public DateTime DataNasterii { get => dataNasterii; set => dataNasterii = value; }

        public override string ToString()
        {
            return base.ToString() + $" ID {id} dataNasterii {dataNasterii}";
        }
    }
}
