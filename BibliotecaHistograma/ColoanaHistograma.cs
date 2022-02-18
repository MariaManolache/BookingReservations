using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaHistograma
{
    public class ColoanaHistograma
    {
        public float Value { get; set; }
        public string Label { get; set; }
        public string Color { get; set; }

        public ColoanaHistograma(string label, float value, string color)
        {
            this.Label = label;
            this.Value = value;
            this.Color = color;
        }
    }
}
