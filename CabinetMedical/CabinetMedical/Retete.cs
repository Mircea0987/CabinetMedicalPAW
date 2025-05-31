using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetMedical
{
    [Serializable]
    internal class Retete : IComparable<Retete>, ICloneable
    {
        public Retete()
        {

        }

        public Retete(int id, string numePacient, DateTime dataEmitere, string[] medicamente, int medicId)
        {
            Id = id;
            NumePacient = numePacient;
            DataEmitere = dataEmitere;
            Medicamente = medicamente;
            MedicId = medicId;
        }
        public Retete(string numePacient, DateTime dataEmitere, string[] medicamente)
        {
            NumePacient = numePacient;
            DataEmitere = dataEmitere;
            Medicamente = medicamente;
        }

        public int Id { get; set; }
        public string NumePacient { get; set; }
        public DateTime DataEmitere { get; set; }
        public string[] Medicamente { get; set; }
        public int MedicId
        {
            get; set;
        }

        public object Clone()
        {
            return new Retete
            {
                Id = this.Id,
                NumePacient = this.NumePacient,
                DataEmitere = this.DataEmitere,
                MedicId = this.MedicId,
                Medicamente = (string[])this.Medicamente.Clone(),
            };
        }

        public int CompareTo(Retete other)
        {
            return NumePacient.CompareTo(other.NumePacient);
        }
        public static int operator +(Retete a, Retete b)
        {
            {
                return a.Id + b.Id;
            }
        }
        public static bool operator ==(Retete a, Retete b)
        {
            if(a.Id == b.Id && a.NumePacient.Equals(b.NumePacient)&&a.DataEmitere == b.DataEmitere
                && a.MedicId == b.MedicId && a.Medicamente.SequenceEqual(b.Medicamente))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Retete a, Retete b)
        {
            return !(a == b);
        }
        public string this[int index]
        {
            get { return Medicamente[index]; }
        }

        public override string ToString()
        {
            string mesaj = $"ID = {Id} NumePacient = {NumePacient} DataEmitere {DataEmitere}" +
                $"Medic Id {MedicId}";

            for(int i = 0; i < Medicamente.Length; i++)
            {
                mesaj += Medicamente[i];
            }
            return mesaj;
        }
    }
}
