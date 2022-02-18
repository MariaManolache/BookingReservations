using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaHistograma
{
    public class PieChart
    {
		public string Nume { get; set; }

		public float Procent { get; set; }

		public Color Culoare { get; set; }

		public PieChart(string nume, float procent, Color culoare)
		{
			Nume = nume;
			Procent = procent;
			Culoare = culoare;
		}
	}
}
