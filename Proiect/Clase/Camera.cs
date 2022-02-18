using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Clase
{
   [Serializable]

    public class Camera : ICloneable
    {
        public int Numar { get; set; }
        public float Pret { get; set; }
        public String Tip { get; set; }
        public EVedere Vedere { get; set; }
        public int Etaj { get; set; }

        public Camera()
        {

        }

        public Camera( int numar, String tip, EVedere vedere)
        {
            this.Numar = numar;
            this.Tip = tip;
            this.Vedere = vedere;
            this.Etaj = numar / 100;
          
            if(this.Tip == "Single")
            {
                this.Pret = 100;
            }
            else if (this.Tip == "Double")
            {
                this.Pret = 200;
            }
            else if (this.Tip == "Triple")
            {
                this.Pret = 300;
            }
            else
            {
                this.Pret = 400;
            }
        }

        public object Clone()
        {
            Camera clona = new Camera
            {
                Numar = this.Numar,
                Pret = this.Pret,
                Tip = this.Tip,
                Vedere = this.Vedere,
                Etaj = this.Etaj,
            };

            return clona;
        }
    }
}
