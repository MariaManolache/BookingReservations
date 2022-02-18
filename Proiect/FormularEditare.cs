using Proiect.Clase;
using System;
using System.Collections;
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
    public partial class FormularEditareRezervare : Form
    {
        public List<Camera> listaCamere = new List<Camera>();
        Rezervare instanta;
        private List<Client> clienti = null;
   
        public FormularEditareRezervare(Rezervare rezervare, List<Client> _clienti)
        {
            InitializeComponent();
            instanta = rezervare;
            clienti = _clienti;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            bool valid = true;

            Client client = clienti.Find(c=> c.Nume == listBoxClienti.SelectedItem.ToString());
            instanta.Client = client;

            int indexVedere = cbVedere.SelectedIndex;
            if(indexVedere == 0)
            {
                instanta.Camera.Vedere = EVedere.GRADINA;
            }
            else if (indexVedere == 1)
            {
                instanta.Camera.Vedere = EVedere.PLAJA;
            }
            else if (indexVedere == 2)
            {
                instanta.Camera.Vedere = EVedere.PARCARE;
            }
            else
            {
                instanta.Camera.Vedere = EVedere.STRADA_PRINCIPALA;
            }

            int indexTip = cbTip.SelectedIndex;

            if (indexTip== 0)
            {
                instanta.Camera.Tip = "Single";
                instanta.Camera.Numar = 101;
                instanta.Camera.Pret = 100;
            }
            else if (indexTip == 1)
            {
                instanta.Camera.Tip = "Double";
                instanta.Camera.Numar = 102;
                instanta.Camera.Pret = 200;
            }
            else if (indexTip == 2)
            {
                instanta.Camera.Tip = "Triple";
                instanta.Camera.Numar = 203;
                instanta.Camera.Pret = 300;
            }
            else
            {
                instanta.Camera.Tip = "Apartament";
                instanta.Camera.Numar = 204;
                instanta.Camera.Pret = 400;
            }

            instanta.Tarif = int.Parse(instanta.NrNopti.TotalDays.ToString()) * instanta.Camera.Pret;

            instanta.DataCheckIn = dtpCheckIn.Value;
            instanta.DataCheckOut = dtpCheckOut.Value;

            if (DateTime.Compare(instanta.DataCheckIn, DateTime.Now) < 0 &&
                DateTime.Compare(instanta.DataCheckOut, DateTime.Now) < 0 &&
                DateTime.Compare(instanta.DataCheckIn, instanta.DataCheckOut) < 0)
            {
                valid = false;
            }

            instanta.NrNopti = instanta.DataCheckOut.Subtract(instanta.DataCheckIn);
            instanta.Tarif = int.Parse(instanta.NrNopti.TotalDays.ToString()) * instanta.Camera.Pret;

            List<String> facilitati = new List<string>();
            if (checkPatSuplimentar.Checked)
            {
                facilitati.Add("Pat suplimentar");
            }
            if (checkMicDejunInclus.Checked)
            {
                facilitati.Add("Mic dejun inclus");
            }
            if (checkScaunCopil.Checked)
            {
                facilitati.Add("Scaun copil");
            }
            if (checkLocDeParcare.Checked)
            {
                facilitati.Add("Loc de parcare");
            }
            instanta.ListaFacilitati = facilitati;

            switch (facilitati.Count)
            {
                case 0:
                    instanta.Tarif = instanta.Tarif;
                    break;
                case 1:
                    instanta.Tarif = instanta.Tarif + 50;
                    break;
                case 2:
                    instanta.Tarif = instanta.Tarif + 100;
                    break;
                case 3:
                    instanta.Tarif = instanta.Tarif + 150;
                    break;
                case 4:
                    instanta.Tarif = instanta.Tarif + 200;
                    break;
            }

            if (valid)
            {

                MessageBox.Show("Instanta modificata cu succes", "Succes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Instanta modificata contine erori!", "Eroare",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                
            }

        }
            private void FormularEditareRezervare_Load(object sender, EventArgs e)
            {
          
                listBoxClienti.DataSource = null;

                String[] nume = new String[clienti.Count()];
                int index = 0;
                foreach (Client c in clienti)
                {
                    nume[index] = c.Nume;
                    index++;
                }

             listBoxClienti.DataSource = nume;

            Client client = clienti.Find(instanta=> instanta.Nume == listBoxClienti.SelectedItem.ToString());
            client = instanta.Client;
            EVedere vedere = instanta.Camera.Vedere;
            if (vedere == EVedere.GRADINA)
            {
                cbVedere.SelectedIndex = 0;
            }
            else if (vedere == EVedere.PLAJA)
            {
                cbVedere.SelectedIndex = 1;
            }
            else if (vedere == EVedere.PARCARE)
            {
                cbVedere.SelectedIndex = 2;
            }
            else
            {
                cbVedere.SelectedIndex = 3;
            }

            String tip = instanta.Camera.Tip;
            if (tip == "Single")
            {
                cbTip.SelectedIndex = 0;
            }
            else if (tip == "Double")
            {
                cbTip.SelectedIndex = 1;
            }
            else if (tip == "Triple")
            {
                cbTip.SelectedIndex = 2;
            }
            else
            {
                cbTip.SelectedIndex = 3;
            }


            dtpCheckIn.Value = instanta.DataCheckIn;
            dtpCheckOut.Value = instanta.DataCheckOut;

            List<string> lista = instanta.ListaFacilitati;
                if (lista.Contains("Pat suplimentar"))
                {
                    checkPatSuplimentar.Checked = true;
                }
                if (lista.Contains("Mic dejun inclus"))
                {
                    checkMicDejunInclus.Checked = true;
                }
                if (lista.Contains("Scaun copil"))
                {
                    checkScaunCopil.Checked = true;
                }
                if (lista.Contains("Loc de parcare"))
                {
                    checkLocDeParcare.Checked = true;
                }

            }

            private void btnRenunta_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        private void FormularEditareRezervare_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                btnSalveaza_Click(sender, e);
            }
        }
    }
}
