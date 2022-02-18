using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Clase
{
    public class DateInvalide : Exception
    {
        public DateTime dataCheckIn { get; set; }
        public DateTime dataCheckOut { get; set; }

        public DateInvalide(DateTime data1, DateTime data2)
        {
            dataCheckIn = data1;
            dataCheckOut = data2;
        }

        public DateInvalide(DateTime data)
        {
            dataCheckIn = data;
        }

        public override string Message
        {
            get
            {
                return "Data " + dataCheckIn + " nu este valida";
            }
        }
    }
}
