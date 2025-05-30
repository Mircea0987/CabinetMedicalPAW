using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetMedical
{
    internal class Medici : Persoana, IMediciCount, IComparable<Medici>
    {
        public Medici() : base() {
        
        } 
        public Medici(int id, string specializare, string telefon, string email, int cabinetId,
            List<Medici> mediciList, string nume,string prenume,string CNP) : base(nume,prenume,CNP)
        {
            Id = id;
            Specializare = specializare;
            Telefon = telefon;
            Email = email;
            CabinetId = cabinetId;
            this.mediciList = mediciList;

        }

        public int Id { get; set; }
        public string Specializare { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public int CabinetId { get; set; }

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
                $" Email = {Email} Cabinet Id = {CabinetId}" + base.ToString();

            foreach(Medici m in mediciList)
            {
                mesaj = m.ToString();
            }
            return mesaj;
        }
    }
}
