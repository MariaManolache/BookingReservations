using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Clase
{
    [Serializable]
    public class Rezervare : IComparable<Rezervare>, ICloneable
    {
        public int Id { get; set; }
        public Camera Camera { get; set; }
        public Client Client { get; set; }
        public float Tarif { get; set; }
        private DateTime _dataCheckIn;
        public DateTime DataCheckIn
        {
            get { return _dataCheckIn; }
            set
            {
                if (value <= DateTime.Now)
                    throw new DateInvalide(value);
                _dataCheckIn = value;
            }
        }
        private DateTime _dataCheckOut;
        public DateTime DataCheckOut
        {
            get { return _dataCheckOut; }
            set
            {
                if (value <= DateTime.Now)
                    throw new DateInvalide(value);
                _dataCheckOut = value;
            }
        }
        public TimeSpan NrNopti { get; set; }
        public List<String> ListaFacilitati;
        public List<Client> listaClienti;

        public Rezervare()
        {

        }

        public Rezervare(Camera camera, Client client, DateTime dataCheckIn, DateTime dataCheckOut, List<String> facilitati)
        {
            this.Camera = camera;
            this.Client = client;
            this.DataCheckIn = dataCheckIn;
            this.DataCheckOut = dataCheckOut;
            this.NrNopti = this.DataCheckOut.Subtract(this.DataCheckIn);
            this.Tarif = int.Parse(this.NrNopti.TotalDays.ToString()) * camera.Pret;

            this.ListaFacilitati = facilitati;

            switch (ListaFacilitati.Count)
            {
                case 0:
                    this.Tarif = this.Tarif;
                    break;
                case 1:
                    this.Tarif = this.Tarif + 50;
                    break;
                case 2:
                    this.Tarif = this.Tarif + 100;
                    break;
                case 3:
                    this.Tarif = this.Tarif + 150;
                    break;
                case 4:
                    this.Tarif = this.Tarif + 200;
                    break;

            }
        }

        public int CompareTo(Rezervare other)
        {
            return this.Tarif.CompareTo(other.Tarif);
        }

        public object Clone()
        {
            Rezervare clona = new Rezervare
            {
                Camera = (Camera)Camera.Clone(),
                Client = (Client)Client.Clone(),
                Tarif = this.Tarif,
                DataCheckIn = this.DataCheckIn,
                DataCheckOut = this.DataCheckOut,
                NrNopti = this.NrNopti,
                ListaFacilitati = new List<string>()
            };

            foreach (String facilitate in this.ListaFacilitati)
            {
                clona.ListaFacilitati.Add(facilitate);

            }
            return clona;
        }
    }
}
