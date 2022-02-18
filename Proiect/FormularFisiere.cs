using Proiect.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormularFisiere : Form
    {
        List<Client> clienti = new List<Client>();
        public FormularFisiere()
        {
            InitializeComponent();
        }

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = e.Data.GetData(DataFormats.FileDrop, false) as string[];

            foreach(String path in filePaths)
            {
                string[] content = File.ReadAllLines(path);

                TreeNode root = new TreeNode("Clienti");
                treeView.Nodes.Add(root);

                foreach(String line in content)
                {
                    String[] tokens = line.Split('\t');

                    TreeNode child = new TreeNode(tokens[0]);
                    root.Nodes.Add(child);

                    TreeNode grandchild1 = new TreeNode("Varsta: " + tokens[1]);
                    TreeNode grandchild2 = new TreeNode("CNP: " + tokens[2]);
                    TreeNode grandchild3 = new TreeNode("Telefon: " + tokens[3]);
                    TreeNode grandchild4 = new TreeNode("Numar persoane: " + tokens[4]);

                    child.Nodes.Add(grandchild1);
                    child.Nodes.Add(grandchild2);
                    child.Nodes.Add(grandchild3);
                    child.Nodes.Add(grandchild4);

                    Client c = new Client();
                    c.Nume = tokens[0];
                    c.Varsta = int.Parse(tokens[1]);
                    c.Cnp = tokens[2];
                    c.Telefon = tokens[3];
                    c.NrPersoane = int.Parse(tokens[4]);
                    clienti.Add(c);
                }

                treeView.ExpandAll();
            }
        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void toolStripBtnClienti_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormularClient formularClient = new FormularClient();
            formularClient.ShowDialog();

            this.Close();
        }

        private void toolStripBtnRezervari_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormularRezervare formularRezervare = new FormularRezervare();
            formularRezervare.ShowDialog();

            this.Close();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView.SelectedNode;

            statusLabel.Text = "Ati selectat nodul: " + node.FullPath;
        }

        private void toolStripBtnFisierText_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormularFisiereText formularFisiereText = new FormularFisiereText();
            formularFisiereText.ShowDialog();

            this.Close();
        }
    }
}
