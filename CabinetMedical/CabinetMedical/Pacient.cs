using System;

namespace CabinetMedical
{
    internal class Pacient
    {
        private int id;
        private DateTime dataNasterii;
        private string name;
        private string cnp;

        // Constructor fără parametri
        public Pacient() { }

        // Constructor complet
        public Pacient(int id, DateTime dataNasterii, string nume, string prenume, string cnp)
        {
            Id = id;
            DataNasterii = dataNasterii;
            Nume = nume;
            Prenume = prenume;
            CNP = cnp;
        }

        // Constructor fără ID
        public Pacient(DateTime dataNasterii, string nume, string prenume, string cnp)
        {
            DataNasterii = dataNasterii;
            Nume = nume;
            Prenume = prenume;
            CNP = cnp;
        }

        // Proprietăți
        public int Id { get => id; set => id = value; }
        public DateTime DataNasterii { get => dataNasterii; set => dataNasterii = value; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }

        // Suprascrierea metodei ToString()
        public override string ToString()
        {
            return $"ID: {Id}, Nume: {Nume}, Prenume: {Prenume}, CNP: {CNP}, Data nașterii: {DataNasterii.ToShortDateString()}";
        }
    }
}
