using Proiect.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormularClient : Form
    {
        ClientRezervareContext ctx = new ClientRezervareContext();
        public List<Client> clienti = new List<Client>();
        public FormularClient()
        {
            InitializeComponent();
        }

        public FormularClient(ClientRezervareContext clienti)
        {
            InitializeComponent();
            ctx = clienti;
        }

        private void curataFormular()
        {
            tbNumeClient.Clear();
            tbVarstaClient.Clear();
            tbCNPClient.Clear();
            tbTelefon.Clear();
            nupPersoane.Value = 0;
        }

        private void btnAdaugaEditeaza_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if(dgv.SelectedRows.Count != 0)
            {
                Client client = clientBindingSource.Current as Client;
                

                client.Nume = tbNumeClient.Text;

                if (String.IsNullOrEmpty(client.Nume) ||
                String.IsNullOrWhiteSpace(client.Nume) ||
                client.Nume.Length < 3)
                {
                    valid = false;
                }

                try
                {
                    client.Varsta = int.Parse(tbVarstaClient.Text);
                }
                catch (Exception)
                {
                    valid = false;
                }
                if (client.Varsta == 0 || client.Varsta < 18)
                {
                    valid = false;
                }

                //client.Varsta = int.Parse(tbVarstaClient.Text);
                client.Cnp = tbCNPClient.Text;

                if (String.IsNullOrEmpty(client.Cnp) ||
                String.IsNullOrWhiteSpace(client.Cnp) ||
                client.Cnp.Length != 13)
                {
                    valid = false;
                }

                client.Telefon = tbTelefon.Text;

                if (String.IsNullOrEmpty(client.Telefon) ||
                String.IsNullOrWhiteSpace(client.Telefon))
                {
                    valid = false;
                }
                client.NrPersoane = int.Parse(nupPersoane.Value.ToString());

                if(valid)
                {

                ctx.Clienti.Update(client);
                    MessageBox.Show("Instanta creata!", "Succes",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Formularul contine erori!", "Eroare",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
            else
            {
                Client client = new Client();

                client.Nume = tbNumeClient.Text;

                if (String.IsNullOrEmpty(client.Nume) ||
                String.IsNullOrWhiteSpace(client.Nume) ||
                client.Nume.Length < 3)
                {
                    valid = false;
                }

                try
                {
                    client.Varsta = int.Parse(tbVarstaClient.Text);
                }
                catch (Exception)
                {
                    valid = false;
                }
                if (client.Varsta == 0 || client.Varsta < 18)
                {
                    valid = false;
                }

                //client.Varsta = int.Parse(tbVarstaClient.Text);
                client.Cnp = tbCNPClient.Text;

                if (String.IsNullOrEmpty(client.Cnp) ||
                String.IsNullOrWhiteSpace(client.Cnp) ||
                client.Cnp.Length != 13)
                {
                    valid = false;
                }

                client.Telefon = tbTelefon.Text;

                if (String.IsNullOrEmpty(client.Telefon) ||
                String.IsNullOrWhiteSpace(client.Telefon))
                {
                    valid = false;
                }
                client.NrPersoane = int.Parse(nupPersoane.Value.ToString());

                if (valid)
                {

                    ctx.Clienti.Add(client);
                    MessageBox.Show("Instanta creata!", "Succes",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Formularul contine erori!", "Eroare",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
            ctx.SaveChanges();

            clientBindingSource.DataSource = ctx.Clienti.ToList();
            curataFormular();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if(dgv.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Doresti sa stergi intrarea?", "Stergere",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    ctx.Clienti.Remove(clientBindingSource.Current as Client);
                    ctx.SaveChanges(); //commit

                    clientBindingSource.DataSource = ctx.Clienti.ToList();
                }
            }
        }

        private void FormularClient_Load(object sender, EventArgs e)
        {
            clientBindingSource.DataSource = ctx.Clienti.ToList();

        }

        private void toolStripButtonRezervare_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormularRezervare formularRezervare = new FormularRezervare();
            formularRezervare.ShowDialog();

            this.Close();
        }

        private void tbCNPClient_Validated(object sender, EventArgs e)
        {
            epCNP.Clear();
        }

        private void tbCNPClient_Validating(object sender, CancelEventArgs e)
        {
            string cnpClient = tbCNPClient.Text;

            if (String.IsNullOrEmpty(cnpClient) ||
                String.IsNullOrWhiteSpace(cnpClient) ||
                cnpClient.Length != 13)
            {
                epCNP.SetError((Control)sender, "CNP != 13 caractere");
                e.Cancel = true;
            }
        }

        private void tbVarstaClient_Validated(object sender, EventArgs e)
        {
            epVarsta.Clear();
        }

        private void tbVarstaClient_Validating(object sender, CancelEventArgs e)
        {
            int.TryParse(tbVarstaClient.Text, out int varstaClient);
            if (varstaClient == 0 || varstaClient < 18)
            {
                epVarsta.SetError((Control)sender, "Varsta nu contine doar cifre");
                e.Cancel = true;
            }
        }

        private void tbNumeClient_Validated(object sender, EventArgs e)
        {
            epNume.Clear();
        }

        private void tbNumeClient_Validating(object sender, CancelEventArgs e)
        {
            String numeClient = tbNumeClient.Text;
            if (String.IsNullOrEmpty(numeClient) ||
                String.IsNullOrWhiteSpace(numeClient) ||
                numeClient.Length < 3)
            {
                epNume.SetError((Control)sender, "Nume < 3 caractere");
                e.Cancel = true;
            }
        }

        private void dgv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Client client = clientBindingSource.Current as Client;

            tbNumeClient.Text = client.Nume;
            tbVarstaClient.Text = client.Varsta.ToString();
            tbCNPClient.Text = client.Cnp;
            tbTelefon.Text = client.Telefon;
            nupPersoane.Value = client.NrPersoane;

            clienti = ctx.Clienti.Where(each => each.Id == client.Id).ToList();

        }

        private void btnCurata_Click(object sender, EventArgs e)
        {
            curataFormular();
        }


        #region Printare
        private void toolStripBtnPrint_Click(object sender, EventArgs e)
        {
            pageSetupDialog.Document = printDoc;
            pageSetupDialog.PageSettings = printDoc.DefaultPageSettings;

            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.DefaultPageSettings = pageSetupDialog.PageSettings;

                printPreviewDialog.Document = printDoc;
                printPreviewDialog.ShowDialog();
            }
        }

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Font font = new Font("Times New Roman",20);
            Brush brush = Brushes.BlueViolet;
            Pen pen = new Pen(brush);

            PageSettings settings = printDoc.DefaultPageSettings;

            var totalDrawableW = settings.PaperSize.Width - settings.Margins.Left - settings.Margins.Right;
            var totalDrawableH = settings.PaperSize.Height - settings.Margins.Top - settings.Margins.Bottom;

            if (settings.Landscape)
            {
                var temp = totalDrawableW;
                totalDrawableW = totalDrawableH;
                totalDrawableH = temp;
            }

            int cellWidth = totalDrawableW / 3;
            int cellHeight = 40;

            int x = settings.Margins.Left;
            int y = 100;
            graphics.DrawString("Lista clienti", font, brush, totalDrawableW/3 + 100, y);

            y += 100;

            graphics.DrawRectangle(pen, x, y, cellWidth, cellHeight);
            graphics.DrawRectangle(pen, x + cellWidth, y, cellWidth, cellHeight);
            graphics.DrawRectangle(pen, x + 2 * cellWidth, y, cellWidth, cellHeight);
           
            graphics.DrawString("Nume", font, brush, x, y);
            graphics.DrawString("CNP", font, brush, x + cellWidth, y);
            graphics.DrawString("Nr persoane", font, brush, x + 2*cellWidth, y);

            y += cellHeight;

            List<Client> clienti = ctx.Clienti.ToList();
            foreach(Client c in clienti)
            {
                graphics.DrawRectangle(pen, x, y, cellWidth, cellHeight);
                graphics.DrawRectangle(pen, x + cellWidth, y, cellWidth, cellHeight);
                graphics.DrawRectangle(pen, x + 2 * cellWidth, y, cellWidth, cellHeight);

                graphics.DrawString(c.Nume, font, brush, x, y);
                graphics.DrawString(c.Cnp, font, brush, x + cellWidth, y);
                graphics.DrawString(c.NrPersoane.ToString(), font, brush, x + 2 * cellWidth, y);

                y += cellHeight;
            }
        
        }

        #endregion

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.P && e.Control)
            {
                toolStripBtnPrint_Click(sender, e);
            }
        }


        private void toolStripBtnFisiere_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormularFisiere formularFisiere = new FormularFisiere();
            formularFisiere.ShowDialog();

            this.Close();
        }
    }
}
