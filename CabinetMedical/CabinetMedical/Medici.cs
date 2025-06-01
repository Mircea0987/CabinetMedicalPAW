using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetMedical
{
    [Serializable]

    public class Medici : IMediciCount, IComparable<Medici>
    {
        public Medici() {
        
        } 
        public Medici(int id, string specializare, string telefon, string email, int cabinetId,
            List<Medici> mediciList, string nume,string prenume,string CNP)
        {
            Id = id;
            Specializare = specializare;
            Telefon = telefon;
            Email = email;
            CabinetId = cabinetId;
            this.mediciList = mediciList;

        }
        public Medici(string specializare, string telefon, string email,
           List<Medici> mediciList, string nume, string prenume, string CNP)
        {
            Specializare = specializare;
            Telefon = telefon;
            Email = email;
            this.mediciList = mediciList;

        }
        public Medici(string specializare, string telefon, string email,
             string nume, string prenume, string cNP, double salariul)
        {
            Specializare = specializare;
            Telefon = telefon;
            Email = email;
            Nume = nume;
            Prenume = prenume;
            CNP = cNP;
            Salariul = salariul;
        }

        public int Id { get; set; }
        public string Specializare { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public int CabinetId { get; set; }
        public string Nume {  get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }
        public double Salariul { get; set; }

        public List<Medici> mediciList;

        public int countNrMedici()
        {
            return mediciList.Count;
        }

        public int CompareTo(Medici other)
        {
            return this.Id.CompareTo(other.Id);
        }
        public Medici mediciListMap()
        {
            foreach (Medici medici in mediciList)
            {
                return medici;
            }
            return null;
        }

        public override string ToString()
        {
            
            string mesaj =  $"Id = {Id} Secializare = {Specializare} Telefon = {Telefon}" +
                $" Email = {Email} Cabinet Id = {CabinetId}";

            return mesaj;
        }
    }
}
