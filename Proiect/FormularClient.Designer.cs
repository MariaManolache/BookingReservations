
namespace Proiect
{
    partial class FormularClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularClient));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nupPersoane = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCNPClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVarstaClient = new System.Windows.Forms.TextBox();
            this.tbNumeClient = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnAdaugaEditeaza = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRezervare = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.epCNP = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNume = new System.Windows.Forms.ErrorProvider(this.components);
            this.epVarsta = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCurata = new System.Windows.Forms.Button();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripBtnFisiere = new System.Windows.Forms.ToolStripButton();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrPersoaneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPersoane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCNP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epVarsta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTelefon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nupPersoane);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbCNPClient);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbVarstaClient);
            this.groupBox1.Controls.Add(this.tbNumeClient);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(48, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adauga client";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(10, 253);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(253, 26);
            this.tbTelefon.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Telefon";
            // 
            // nupPersoane
            // 
            this.nupPersoane.Location = new System.Drawing.Point(10, 314);
            this.nupPersoane.Name = "nupPersoane";
            this.nupPersoane.Size = new System.Drawing.Size(253, 26);
            this.nupPersoane.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Numar persoane";
            // 
            // tbCNPClient
            // 
            this.tbCNPClient.Location = new System.Drawing.Point(6, 192);
            this.tbCNPClient.Name = "tbCNPClient";
            this.tbCNPClient.Size = new System.Drawing.Size(260, 26);
            this.tbCNPClient.TabIndex = 20;
            this.tbCNPClient.Validating += new System.ComponentModel.CancelEventHandler(this.tbCNPClient_Validating);
            this.tbCNPClient.Validated += new System.EventHandler(this.tbCNPClient_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nume client";
            // 
            // tbVarstaClient
            // 
            this.tbVarstaClient.Location = new System.Drawing.Point(6, 131);
            this.tbVarstaClient.Name = "tbVarstaClient";
            this.tbVarstaClient.Size = new System.Drawing.Size(260, 26);
            this.tbVarstaClient.TabIndex = 19;
            this.tbVarstaClient.Validating += new System.ComponentModel.CancelEventHandler(this.tbVarstaClient_Validating);
            this.tbVarstaClient.Validated += new System.EventHandler(this.tbVarstaClient_Validated);
            // 
            // tbNumeClient
            // 
            this.tbNumeClient.Location = new System.Drawing.Point(6, 68);
            this.tbNumeClient.Name = "tbNumeClient";
            this.tbNumeClient.Size = new System.Drawing.Size(260, 26);
            this.tbNumeClient.TabIndex = 15;
            this.tbNumeClient.Validating += new System.ComponentModel.CancelEventHandler(this.tbNumeClient_Validating);
            this.tbNumeClient.Validated += new System.EventHandler(this.tbNumeClient_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "CNP client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Varsta client";
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.varstaDataGridViewTextBoxColumn,
            this.cnpDataGridViewTextBoxColumn,
            this.Telefon,
            this.nrPersoaneDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.clientBindingSource;
            this.dgv.Location = new System.Drawing.Point(477, 104);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(563, 325);
            this.dgv.TabIndex = 1;
            this.dgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_KeyDown);
            this.dgv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseDoubleClick);
            // 
            // btnAdaugaEditeaza
            // 
            this.btnAdaugaEditeaza.Location = new System.Drawing.Point(52, 449);
            this.btnAdaugaEditeaza.Name = "btnAdaugaEditeaza";
            this.btnAdaugaEditeaza.Size = new System.Drawing.Size(152, 72);
            this.btnAdaugaEditeaza.TabIndex = 4;
            this.btnAdaugaEditeaza.Text = "Adauga/Editeaza";
            this.btnAdaugaEditeaza.UseVisualStyleBackColor = true;
            this.btnAdaugaEditeaza.Click += new System.EventHandler(this.btnAdaugaEditeaza_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(235, 449);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(145, 72);
            this.btnSterge.TabIndex = 7;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRezervare,
            this.toolStripSeparator1,
            this.toolStripBtnPrint,
            this.toolStripSeparator2,
            this.toolStripBtnFisiere});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1111, 33);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonRezervare
            // 
            this.toolStripButtonRezervare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRezervare.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRezervare.Image")));
            this.toolStripButtonRezervare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRezervare.Name = "toolStripButtonRezervare";
            this.toolStripButtonRezervare.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonRezervare.Text = "Rezervari";
            this.toolStripButtonRezervare.Click += new System.EventHandler(this.toolStripButtonRezervare_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripBtnPrint
            // 
            this.toolStripBtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnPrint.Image")));
            this.toolStripBtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnPrint.Name = "toolStripBtnPrint";
            this.toolStripBtnPrint.Size = new System.Drawing.Size(34, 28);
            this.toolStripBtnPrint.Text = "Printare";
            this.toolStripBtnPrint.Click += new System.EventHandler(this.toolStripBtnPrint_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // epCNP
            // 
            this.epCNP.ContainerControl = this;
            // 
            // epNume
            // 
            this.epNume.ContainerControl = this;
            // 
            // epVarsta
            // 
            this.epVarsta.ContainerControl = this;
            // 
            // btnCurata
            // 
            this.btnCurata.Location = new System.Drawing.Point(491, 444);
            this.btnCurata.Name = "btnCurata";
            this.btnCurata.Size = new System.Drawing.Size(160, 83);
            this.btnCurata.TabIndex = 9;
            this.btnCurata.Text = "Curata";
            this.btnCurata.UseVisualStyleBackColor = true;
            this.btnCurata.Click += new System.EventHandler(this.btnCurata_Click);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.MinimumWidth = 8;
            this.Telefon.Name = "Telefon";
            this.Telefon.Width = 150;
            // 
            // toolStripBtnFisiere
            // 
            this.toolStripBtnFisiere.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnFisiere.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnFisiere.Image")));
            this.toolStripBtnFisiere.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnFisiere.Name = "toolStripBtnFisiere";
            this.toolStripBtnFisiere.Size = new System.Drawing.Size(34, 28);
            this.toolStripBtnFisiere.Text = "Fisiere";
            this.toolStripBtnFisiere.Click += new System.EventHandler(this.toolStripBtnFisiere_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.Width = 150;
            // 
            // varstaDataGridViewTextBoxColumn
            // 
            this.varstaDataGridViewTextBoxColumn.DataPropertyName = "Varsta";
            this.varstaDataGridViewTextBoxColumn.HeaderText = "Varsta";
            this.varstaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.varstaDataGridViewTextBoxColumn.Name = "varstaDataGridViewTextBoxColumn";
            this.varstaDataGridViewTextBoxColumn.Width = 150;
            // 
            // cnpDataGridViewTextBoxColumn
            // 
            this.cnpDataGridViewTextBoxColumn.DataPropertyName = "Cnp";
            this.cnpDataGridViewTextBoxColumn.HeaderText = "Cnp";
            this.cnpDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cnpDataGridViewTextBoxColumn.Name = "cnpDataGridViewTextBoxColumn";
            this.cnpDataGridViewTextBoxColumn.Width = 150;
            // 
            // nrPersoaneDataGridViewTextBoxColumn
            // 
            this.nrPersoaneDataGridViewTextBoxColumn.DataPropertyName = "NrPersoane";
            this.nrPersoaneDataGridViewTextBoxColumn.HeaderText = "NrPersoane";
            this.nrPersoaneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nrPersoaneDataGridViewTextBoxColumn.Name = "nrPersoaneDataGridViewTextBoxColumn";
            this.nrPersoaneDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(Proiect.Clase.Client);
            // 
            // FormularClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 616);
            this.Controls.Add(this.btnCurata);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnAdaugaEditeaza);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "FormularClient";
            this.Text = "FormularClient";
            this.Load += new System.EventHandler(this.FormularClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPersoane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCNP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epVarsta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCNPClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVarstaClient;
        private System.Windows.Forms.TextBox tbNumeClient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAdaugaEditeaza;
        private System.Windows.Forms.NumericUpDown nupPersoane;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonRezervare;
        private System.Windows.Forms.ErrorProvider epCNP;
        private System.Windows.Forms.ErrorProvider epNume;
        private System.Windows.Forms.ErrorProvider epVarsta;
        private System.Windows.Forms.Button btnCurata;
        private System.Windows.Forms.ToolStripButton toolStripBtnPrint;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrPersoaneDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripBtnFisiere;
    }
}