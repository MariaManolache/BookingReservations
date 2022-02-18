using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaHistograma
{
    public partial class Histograma : UserControl
    {
        //public ColoanaHistograma[] Data = new[]
        //{
        //    new ColoanaHistograma("Maria", 750, "red"),
        //    new ColoanaHistograma("Luca", 1000, "darkgreen"),
        //    new ColoanaHistograma("Stefan", 350, "darkblue"),
        //    new ColoanaHistograma("Ioana", 1200, "pink"),
        //    new ColoanaHistograma("Andrei", 200, "yellow")
        //};

        //public Histograma()
        //{
        //    InitializeComponent();
        //    ResizeRedraw = true;
        //}

        //public ColoanaHistograma[] Data;
        private PieChart[] _data;
        public PieChart[] Data
        {
            get { return _data; }
            set
            {
                if (_data == value)
                    return;
                _data = value;
                Invalidate();
            }
        }

        public Histograma()
        {
            InitializeComponent();
            ResizeRedraw = true;

            Data = new[]
            {
                new PieChart("Single", 10, Color.Red),
                new PieChart("Double", 20, Color.CornflowerBlue),
                new PieChart("Triple", 30, Color.DarkSeaGreen),
                new PieChart("Apartment", 40, Color.LightGoldenrodYellow),

            };
        }

        private void Histograma_Paint(object sender, PaintEventArgs e)
        {
            //    Graphics graphics = e.Graphics;
            //    Rectangle rectangle = e.ClipRectangle;

            //    //float max = 0;
            //    //foreach(ColoanaHistograma c in Data)
            //    //{
            //    //    if(c.Value>max)
            //    //    {
            //    //        max = c.Value;
            //    //    }
            //    //}
            //    float max = Data.Max(x => x.Value);
            //    float scaleFactor = rectangle.Height / max;
            //    float latimeColoana = (rectangle.Width - 300) / Data.Length;
            //    float inaltimeMaxColoana = rectangle.Height * 0.9f;

            //    for (int i = 0; i < Data.Length; i++)
            //    {
            //        ColoanaHistograma c = Data[i];
            //        float inaltime = c.Value * scaleFactor;

            //        graphics.FillRectangle(new SolidBrush(Color.FromName(c.Color)),
            //            i * latimeColoana,
            //            rectangle.Height - inaltime,
            //            latimeColoana * 0.9f,
            //            inaltime
            //            );

            //    }

            //    var xCoord = rectangle.Width - 300;
            //    var yCoord = 0;
            //    for (int i = 0; i < Data.Length; i++)
            //    {
            //        ColoanaHistograma c = Data[i];
            //        graphics.FillRectangle(new SolidBrush(Color.FromName(c.Color)),
            //            xCoord,
            //            yCoord,
            //            35,
            //            35
            //            );
            //        graphics.DrawString(c.Label + ": " + c.Value, new Font("Times New Roman", 8),
            //            new SolidBrush(Color.FromName(c.Color)),
            //            xCoord + 35, yCoord + 20);

            //        yCoord += 35;
            //    }
            //}

            int legendWidth = 150;

            Graphics graphics = e.Graphics;
            Rectangle clipRectangle = e.ClipRectangle;

            float radius = Math.Min(clipRectangle.Height, clipRectangle.Width - legendWidth) / (float)2;

            int xCenter = (clipRectangle.Width - legendWidth) / 2;
            int yCenter = clipRectangle.Height / 2;

            float x = xCenter - radius;
            float y = yCenter - radius;

            float width = radius * 2;
            float height = radius * 2;

            float[] procente = new float[4];
            for(int i=0;i<4;i++)
            {
                procente[i] = 0;
            }
 
            float[] unghiuri = new float[4];
            for (int i = 0; i < Data.Length; i++)
            {
                procente[i] = Data[i].Procent;

                for(int j=0;j<4;j++)
                {
                    unghiuri[j] = procente[j] / 100 * 360;
                }
            }

            Brush b1 = new SolidBrush(Data[0].Culoare);
            graphics.FillPie(b1, x, y, width, height, 0, unghiuri[0]);
            Brush b2 = new SolidBrush(Data[1].Culoare);
            graphics.FillPie(b2, x, y, width, height, unghiuri[0], unghiuri[0]+unghiuri[1]);
            Brush b3 = new SolidBrush(Data[2].Culoare);
            graphics.FillPie(b3, x, y, width, height, unghiuri[0]+unghiuri[1], unghiuri[2]);
            Brush b4 = new SolidBrush(Data[3].Culoare);
            graphics.FillPie(b4, x, y, width, height, unghiuri[2]+unghiuri[3]-unghiuri[0], unghiuri[3]);

            Pen pen = new Pen(Color.Black);
            graphics.DrawEllipse(pen, x, y, width, height);

            float xpos = x + width + 20;
            float ypos = y;
            for (int i = 0; i < Data.Length; i++)
            {
                Brush b = new SolidBrush(Data[i].Culoare);
                graphics.FillRectangle(b, xpos, ypos, 30, 30);
                graphics.DrawRectangle(pen, xpos, ypos, 30, 30);
                Brush br = new SolidBrush(Color.Black);
                graphics.DrawString(Data[i].Nume + ": " + Data[i].Procent + "%",
                Font, br,
                xpos + 35, ypos + 12);
                ypos += 35;
            }
        }
    }
}
