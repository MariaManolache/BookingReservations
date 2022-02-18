using BibliotecaHistograma;
using Proiect.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Histograma : Form
    {
        public Histograma()
        {
            InitializeComponent();
        }
        public Histograma(List<Rezervare> rezervari)
        {
            InitializeComponent();

            BibliotecaHistograma.Histograma hist = new BibliotecaHistograma.Histograma();

            hist.Location = new System.Drawing.Point(55, 12);
            hist.Name = "histograma1";
            hist.Size = new System.Drawing.Size(701, 433);
            hist.TabIndex = 0;

            this.Controls.Add(hist);

        }
    }
}
