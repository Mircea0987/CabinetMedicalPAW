using System;

namespace CabinetMedical
{
    [Serializable]
    internal class Pacient
    {
        private int id;
        private DateTime dataNasterii;
        private string name;
        private string cnp;

        public Pacient() { }

        public Pacient(int id, DateTime dataNasterii, string nume, string prenume, string cnp)
        {
            Id = id;
            DataNasterii = dataNasterii;
            Nume = nume;
            Prenume = prenume;
            CNP = cnp;
        }

        public Pacient(DateTime dataNasterii, string nume, string prenume, string cnp)
        {
            DataNasterii = dataNasterii;
            Nume = nume;
            Prenume = prenume;
            CNP = cnp;
        }

        public int Id { get => id; set => id = value; }
        public DateTime DataNasterii { get => dataNasterii; set => dataNasterii = value; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Nume: {Nume}, Prenume: {Prenume}, CNP: {CNP}, Data nașterii: {DataNasterii.ToShortDateString()}";
        }
    }
}
