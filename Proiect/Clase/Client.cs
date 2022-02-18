using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Clase
{
    [Serializable]
    public class Client : ICloneable
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public int Varsta { get; set; }
        public string Cnp { get; set; }
        public string Telefon { get; set; }
        public int NrPersoane { get; set; }

        public Client()
        {

        }

        public Client(string nume, int varsta, string cnp, string telefon, int nrPersoane)
        {
            this.Nume = nume;
            this.Varsta = varsta;
            this.Cnp = cnp;
            this.Telefon = telefon;
            this.NrPersoane = nrPersoane;
        }

        public object Clone()
        {
            Client clona = new Client
            {
                Nume = this.Nume,
                Varsta = this.Varsta,
                Cnp = this.Cnp,
                Telefon = this.Telefon,
                NrPersoane = this.NrPersoane
            };
            return clona;
        }
    }
}
