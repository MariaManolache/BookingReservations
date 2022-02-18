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
    public partial class FormularFisiereText : Form
    {
        bool imageOnSrc = true;
        public FormularFisiereText()
        {
            InitializeComponent();

            src.ImageLocation = "D:\\an 2 sem 2\\Proiect\\customer.png";
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if(imageOnSrc)
            {
                Clipboard.SetImage(src.Image);
                dst.Image = Clipboard.GetImage();
                src.Image = null;
                imageOnSrc = false;
            }
            else
            {
                Clipboard.SetImage(dst.Image);
                src.Image = Clipboard.GetImage();
                dst.Image = null;
                imageOnSrc = true;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbSrc.Text);
            tbSrc.Clear();

        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            tbDst.Text = Clipboard.GetText();
        }

        private void toolStripBtnFisier_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormularFisiere formularFisiere = new FormularFisiere();
            formularFisiere.ShowDialog();

            this.Close();
        }
    }
}
