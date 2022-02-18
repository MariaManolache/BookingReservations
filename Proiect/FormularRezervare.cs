using Proiect.Clase;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Proiect
{
    public partial class FormularRezervare : Form
    {
        List<Rezervare> listaRezervari = new List<Rezervare>();
        ClientRezervareContext ctx = new ClientRezervareContext();
        List<Client> clienti = new List<Client>();
        public FormularRezervare()
        {
            InitializeComponent();
        }

        private void CurataFormular()
        {
            cbTip.SelectedIndex = -1;
            cbVedere.SelectedIndex = -1;
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now;

            checkPatSuplimentar.Checked = false;
            checkMicDejunInclus.Checked = false;
            checkScaunCopil.Checked = false;
            checkLocDeParcare.Checked = false;

        }

        #region CRUD
        private void btnCurata_Click(object sender, EventArgs e)
        {
            CurataFormular();
        }

        //CREATE
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            bool valid = true;
            FormularClient formularClient = new FormularClient(ctx);
 

           int indexClient = listBoxClienti.SelectedIndex;

            Client client = new Client();

            client = clienti.Find(c => c.Nume == listBoxClienti.SelectedItem.ToString());

            int indexVedere = cbVedere.SelectedIndex;
            EVedere vedere;
            if (indexVedere == 0)
            {
                vedere = EVedere.GRADINA;
            }
            else if (indexVedere == 1)
            {
                vedere = EVedere.PLAJA;
            }
            else if (indexVedere == 2)
            {
                vedere = EVedere.PARCARE;
            }
            else
            {
                vedere = EVedere.STRADA_PRINCIPALA;
            }

            int indexTip = cbTip.SelectedIndex;
            string tip;
            int numar;
            if (indexTip == 0)
            {
                tip = "Single";
                numar = 101;
            }
            else if (indexTip == 1)
            {
                tip = "Double";
                numar = 102;
            }
            else if (indexTip == 2)
            {
                tip = "Triple";
                numar = 203;
            }
            else
            {
                tip = "Apartament";
                numar = 204;
            }


            Camera camera = new Camera(numar,tip,vedere);

            DateTime dataCheckIn = dtpCheckIn.Value;
            DateTime dataCheckOut = dtpCheckOut.Value;

            if( DateTime.Compare(dataCheckIn, dataCheckOut) > 0)
            {
                valid = false;
            }

            List<String> facilitati = new List<string>();
            if(checkPatSuplimentar.Checked)
            {
                facilitati.Add("Pat suplimentar");
            }
            if(checkMicDejunInclus.Checked)
            {
                facilitati.Add("Mic dejun inclus");
            }
            if(checkScaunCopil.Checked)
            {
                facilitati.Add("Scaun copil");
            }
            if(checkLocDeParcare.Checked)
            {
                facilitati.Add("Loc de parcare");
            }

            if(valid)
            {
                try
                {
                    Rezervare r = new Rezervare(camera, client, dataCheckIn, dataCheckOut, facilitati);
                    listaRezervari.Add(r);

                    populeazaListView();

                    CurataFormular();

                    MessageBox.Show("Instanta creata!", "Succes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch(DateInvalide)
                {
                    MessageBox.Show(string.Format("Data pentru check-in {0} sau data pentru check-out {1} nu este corecta", dataCheckIn.Date, dataCheckOut.Date));
                }
                catch(Exception)
                {
                    MessageBox.Show("S-a declansat o exceptie.");
                }

            }
            else
            {
                MessageBox.Show("Formularul contine erori!", "Eroare",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        // READ
        private void populeazaListView()
        {
            lvRezervari.Items.Clear();

            foreach(Rezervare rez in listaRezervari)
            {
                ListViewItem lvi = new ListViewItem(new String[]
                    { rez.Client.Nume.ToString(), rez.Camera.Tip.ToString(), (rez.NrNopti).Days.ToString(), rez.Tarif.ToString()});

                lvi.Tag = rez;
                lvRezervari.Items.Add(lvi);
                statusStripLabel.Text = "Numar rezervari: " + lvRezervari.Items.Count;

            }
        }

        //UPDATE
        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            if(lvRezervari.SelectedItems.Count != 0)
            {
                Rezervare r = listaRezervari.ElementAt(lvRezervari.SelectedIndices[0]);

                FormularEditareRezervare editare = new FormularEditareRezervare(r, clienti);
                DialogResult dialogResult = editare.ShowDialog();

                if(dialogResult==DialogResult.OK)
                {
                    populeazaListView();
                }
            }
        }

        // DELETE
        private void btnSterge_Click(object sender, EventArgs e)
        {
            if(lvRezervari.SelectedItems.Count != 0)
            {
                if(DialogResult.Yes == MessageBox.Show("Doresti sa stergi aceasta rezervare?",
                    "Stergere rezervare", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                {
                    Rezervare r = lvRezervari.SelectedItems[0].Tag as Rezervare;
                    listaRezervari.Remove(r);
                    populeazaListView();

                }
            }
        }

        #endregion

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEditeaza_Click(sender, e);
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSterge_Click(sender, e);
        }

        private void lvRezervari_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cms.Show(Cursor.Position.X + 5, Cursor.Position.Y + 5);
            }
        }

        private void FormularPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D && e.Control)
            {
                btnSterge_Click(sender, e);
            }
            if (e.KeyCode == Keys.E && e.Control)
            {
                btnEditeaza_Click(sender, e);
            }

        }

        #region Serializare/Deserializare/Export

        private void serializareBinara_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            FileStream stream = new FileStream("binary.dat", FileMode.Create);
            binaryFormatter.Serialize(stream, listaRezervari);

            stream.Close();
            MessageBox.Show("Fisierul binary.dat salvat cu succes");
        }

        private void deserializareBinara_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Selecteaza fisierul binar pentru deserializare";
            ofd.Filter = "Text files (*.txt)|*.txt|Binary files (*.dat)|*.dat|All files (*.*)|*.*";
            ofd.FilterIndex = 2;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = File.OpenRead(ofd.FileName);
                listaRezervari = binaryFormatter.Deserialize(fileStream) as List<Rezervare>;

                fileStream.Close();
                populeazaListView();
            }
        }

        private void serializareXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Rezervare>));

            FileStream stream = File.Create("rezervari.xml");
            serializer.Serialize(stream, listaRezervari);

            stream.Close();
            MessageBox.Show("Fisierul rezervari.xml salvat cu succes");

        }

        private void deserializareXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Rezervare>));

            try
            {
                FileStream stream = File.OpenRead("rezervari.xml");
                listaRezervari = serializer.Deserialize(stream) as List<Rezervare>;

                stream.Close();
                populeazaListView();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void export_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Salveaza in fisier text";
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(sfd.FileName);
                writer.Write("Nume        Varsta         CNP      Vedere     Tip         Data check in          Data check out          Facilitati\n");

                foreach (Rezervare r in listaRezervari)
                {
                    writer.Write(r.Client.Nume + ", " + r.Client.Varsta + ", " + r.Client.Cnp + ", " + r.Camera.Vedere + ", " + r.Camera.Tip + ", "
                        + r.DataCheckIn.Date + ", " + r.DataCheckOut.Date + ", ");
                    for(int i =0;i<r.ListaFacilitati.Count;i++)
                    {
                        writer.Write(r.ListaFacilitati[i] + "; ");
                    }
                    writer.Write('\n');
                }
                writer.Close();
            }
        }

        #endregion

        private void toolStripButtonClienti_Click(object sender, EventArgs e)
        {

            this.Hide();

            FormularClient formularClienti = new FormularClient();
            formularClienti.ShowDialog();

            this.Close();
        }

        private void FormularRezervare_Load(object sender, EventArgs e)
        {
            FormularClient formularClienti = new FormularClient(ctx);

                listBoxClienti.DataSource = null;

                String[] nume = new String[ctx.Clienti.Count()];
                int index = 0;
                foreach (Client c in ctx.Clienti)
                {
                    nume[index] = c.Nume;
                    index++;
                clienti.Add(c);
                }

                listBoxClienti.DataSource = nume;
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            FormularClient formularClient = new FormularClient(ctx);

            if (formularClient.ShowDialog() == DialogResult.Cancel)
            {
                listBoxClienti.DataSource = null;

                String[] nume = new String[ctx.Clienti.Count()];
                int index = 0;
                clienti = new List<Client>();
                foreach (Client c in ctx.Clienti)
                {

                    nume[index] = c.Nume;
                    index++;
                    clienti.Add(c);
                }

                listBoxClienti.DataSource = nume; 
            }
        }

        private void toolStripBtnFisier_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormularFisiere formularFisiere = new FormularFisiere();
            formularFisiere.ShowDialog();

            this.Close();
        }

        private void toolStripBtnGrafic_Click(object sender, EventArgs e)
        {
            Histograma histograma = new Histograma(listaRezervari);
            histograma.ShowDialog();
        }
    }
}
