
namespace Proiect
{
    partial class FormularRezervare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularRezervare));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.listBoxClienti = new System.Windows.Forms.ListBox();
            this.checkLocDeParcare = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkScaunCopil = new System.Windows.Forms.CheckBox();
            this.cbVedere = new System.Windows.Forms.ComboBox();
            this.checkMicDejunInclus = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkPatSuplimentar = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lvRezervari = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnCurata = new System.Windows.Forms.Button();
            this.btnEditeaza = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operatiiBinareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareBinara = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareBinara = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareXML = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareXML = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.export = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonClienti = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnFisier = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripBtnGrafic = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1.SuspendLayout();
            this.cms.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClient);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbTip);
            this.groupBox1.Controls.Add(this.listBoxClienti);
            this.groupBox1.Controls.Add(this.checkLocDeParcare);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.checkScaunCopil);
            this.groupBox1.Controls.Add(this.cbVedere);
            this.groupBox1.Controls.Add(this.checkMicDejunInclus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.checkPatSuplimentar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpCheckOut);
            this.groupBox1.Controls.Add(this.dtpCheckIn);
            this.groupBox1.Location = new System.Drawing.Point(35, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 562);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adaugare rezervare";
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(10, 164);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(264, 35);
            this.btnClient.TabIndex = 12;
            this.btnClient.Text = "Adauga client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Clienti";
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple",
            "Apartament"});
            this.cbTip.Location = new System.Drawing.Point(2, 294);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(260, 28);
            this.cbTip.TabIndex = 10;
            // 
            // listBoxClienti
            // 
            this.listBoxClienti.FormattingEnabled = true;
            this.listBoxClienti.ItemHeight = 20;
            this.listBoxClienti.Location = new System.Drawing.Point(10, 54);
            this.listBoxClienti.Name = "listBoxClienti";
            this.listBoxClienti.Size = new System.Drawing.Size(268, 84);
            this.listBoxClienti.TabIndex = 9;
            // 
            // checkLocDeParcare
            // 
            this.checkLocDeParcare.AutoSize = true;
            this.checkLocDeParcare.Location = new System.Drawing.Point(187, 532);
            this.checkLocDeParcare.Name = "checkLocDeParcare";
            this.checkLocDeParcare.Size = new System.Drawing.Size(141, 24);
            this.checkLocDeParcare.TabIndex = 10;
            this.checkLocDeParcare.Text = "Loc de parcare";
            this.checkLocDeParcare.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tip";
            // 
            // checkScaunCopil
            // 
            this.checkScaunCopil.AutoSize = true;
            this.checkScaunCopil.Location = new System.Drawing.Point(0, 532);
            this.checkScaunCopil.Name = "checkScaunCopil";
            this.checkScaunCopil.Size = new System.Drawing.Size(167, 24);
            this.checkScaunCopil.TabIndex = 9;
            this.checkScaunCopil.Text = "Scaun pentru copil";
            this.checkScaunCopil.UseVisualStyleBackColor = true;
            // 
            // cbVedere
            // 
            this.cbVedere.FormattingEnabled = true;
            this.cbVedere.Items.AddRange(new object[] {
            "Gradina",
            "Plaja",
            "Parcare",
            "Strada principala"});
            this.cbVedere.Location = new System.Drawing.Point(6, 231);
            this.cbVedere.Name = "cbVedere";
            this.cbVedere.Size = new System.Drawing.Size(260, 28);
            this.cbVedere.TabIndex = 8;
            // 
            // checkMicDejunInclus
            // 
            this.checkMicDejunInclus.AutoSize = true;
            this.checkMicDejunInclus.Location = new System.Drawing.Point(187, 498);
            this.checkMicDejunInclus.Name = "checkMicDejunInclus";
            this.checkMicDejunInclus.Size = new System.Drawing.Size(146, 24);
            this.checkMicDejunInclus.TabIndex = 8;
            this.checkMicDejunInclus.Text = "Mic dejun inclus";
            this.checkMicDejunInclus.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Vedere";
            // 
            // checkPatSuplimentar
            // 
            this.checkPatSuplimentar.AutoSize = true;
            this.checkPatSuplimentar.Location = new System.Drawing.Point(0, 502);
            this.checkPatSuplimentar.Name = "checkPatSuplimentar";
            this.checkPatSuplimentar.Size = new System.Drawing.Size(145, 24);
            this.checkPatSuplimentar.TabIndex = 7;
            this.checkPatSuplimentar.Text = "Pat suplimentar";
            this.checkPatSuplimentar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 479);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Facilitati";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data check out";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data check in";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(0, 438);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(264, 26);
            this.dtpCheckOut.TabIndex = 1;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(2, 367);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(264, 26);
            this.dtpCheckIn.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Lista Rezervari";
            // 
            // lvRezervari
            // 
            this.lvRezervari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6});
            this.lvRezervari.FullRowSelect = true;
            this.lvRezervari.HideSelection = false;
            this.lvRezervari.Location = new System.Drawing.Point(415, 143);
            this.lvRezervari.Name = "lvRezervari";
            this.lvRezervari.Size = new System.Drawing.Size(577, 367);
            this.lvRezervari.TabIndex = 2;
            this.lvRezervari.UseCompatibleStateImageBehavior = false;
            this.lvRezervari.View = System.Windows.Forms.View.Details;
            this.lvRezervari.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvRezervari_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Client";
            this.columnHeader1.Width = 124;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tip camera";
            this.columnHeader2.Width = 121;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Numar nopti";
            this.columnHeader5.Width = 107;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tarif";
            this.columnHeader6.Width = 77;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(37, 682);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(110, 59);
            this.btnAdauga.TabIndex = 3;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnCurata
            // 
            this.btnCurata.Location = new System.Drawing.Point(205, 682);
            this.btnCurata.Name = "btnCurata";
            this.btnCurata.Size = new System.Drawing.Size(104, 59);
            this.btnCurata.TabIndex = 4;
            this.btnCurata.Text = "Curata";
            this.btnCurata.UseVisualStyleBackColor = true;
            this.btnCurata.Click += new System.EventHandler(this.btnCurata_Click);
            // 
            // btnEditeaza
            // 
            this.btnEditeaza.Location = new System.Drawing.Point(431, 556);
            this.btnEditeaza.Name = "btnEditeaza";
            this.btnEditeaza.Size = new System.Drawing.Size(106, 59);
            this.btnEditeaza.TabIndex = 5;
            this.btnEditeaza.Text = "Editeaza";
            this.btnEditeaza.UseVisualStyleBackColor = true;
            this.btnEditeaza.Click += new System.EventHandler(this.btnEditeaza_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(619, 555);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(107, 59);
            this.btnSterge.TabIndex = 6;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // cms
            // 
            this.cms.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeazaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.cms.Name = "contextMenuStrip1";
            this.cms.Size = new System.Drawing.Size(150, 68);
            // 
            // editeazaToolStripMenuItem
            // 
            this.editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            this.editeazaToolStripMenuItem.Size = new System.Drawing.Size(149, 32);
            this.editeazaToolStripMenuItem.Text = "Editeaza";
            this.editeazaToolStripMenuItem.Click += new System.EventHandler(this.editeazaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(149, 32);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operatiiBinareToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.fisierTextToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1114, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operatiiBinareToolStripMenuItem
            // 
            this.operatiiBinareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareBinara,
            this.deserializareBinara});
            this.operatiiBinareToolStripMenuItem.Name = "operatiiBinareToolStripMenuItem";
            this.operatiiBinareToolStripMenuItem.Size = new System.Drawing.Size(145, 29);
            this.operatiiBinareToolStripMenuItem.Text = "Operatii binare";
            // 
            // serializareBinara
            // 
            this.serializareBinara.Name = "serializareBinara";
            this.serializareBinara.Size = new System.Drawing.Size(212, 34);
            this.serializareBinara.Text = "Serializare";
            this.serializareBinara.Click += new System.EventHandler(this.serializareBinara_Click);
            // 
            // deserializareBinara
            // 
            this.deserializareBinara.Name = "deserializareBinara";
            this.deserializareBinara.Size = new System.Drawing.Size(212, 34);
            this.deserializareBinara.Text = "Deserializare";
            this.deserializareBinara.Click += new System.EventHandler(this.deserializareBinara_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareXML,
            this.deserializareXML});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // serializareXML
            // 
            this.serializareXML.Name = "serializareXML";
            this.serializareXML.Size = new System.Drawing.Size(212, 34);
            this.serializareXML.Text = "Serializare";
            this.serializareXML.Click += new System.EventHandler(this.serializareXML_Click);
            // 
            // deserializareXML
            // 
            this.deserializareXML.Name = "deserializareXML";
            this.deserializareXML.Size = new System.Drawing.Size(212, 34);
            this.deserializareXML.Text = "Deserializare";
            this.deserializareXML.Click += new System.EventHandler(this.deserializareXML_Click);
            // 
            // fisierTextToolStripMenuItem
            // 
            this.fisierTextToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.export});
            this.fisierTextToolStripMenuItem.Name = "fisierTextToolStripMenuItem";
            this.fisierTextToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.fisierTextToolStripMenuItem.Text = "Fisier text";
            // 
            // export
            // 
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(165, 34);
            this.export.Text = "Export";
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonClienti,
            this.toolStripSeparator1,
            this.toolStripBtnFisier,
            this.toolStripSeparator2,
            this.toolStripBtnGrafic});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1114, 33);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonClienti
            // 
            this.toolStripButtonClienti.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClienti.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClienti.Image")));
            this.toolStripButtonClienti.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClienti.Name = "toolStripButtonClienti";
            this.toolStripButtonClienti.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonClienti.Text = "Clienti";
            this.toolStripButtonClienti.Click += new System.EventHandler(this.toolStripButtonClienti_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripBtnFisier
            // 
            this.toolStripBtnFisier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnFisier.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnFisier.Image")));
            this.toolStripBtnFisier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnFisier.Name = "toolStripBtnFisier";
            this.toolStripBtnFisier.Size = new System.Drawing.Size(34, 28);
            this.toolStripBtnFisier.Text = "Fisier";
            this.toolStripBtnFisier.Click += new System.EventHandler(this.toolStripBtnFisier_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 853);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1114, 32);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(156, 25);
            this.statusStripLabel.Text = "Numar rezervari: 0";
            // 
            // toolStripBtnGrafic
            // 
            this.toolStripBtnGrafic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnGrafic.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnGrafic.Image")));
            this.toolStripBtnGrafic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnGrafic.Name = "toolStripBtnGrafic";
            this.toolStripBtnGrafic.Size = new System.Drawing.Size(34, 28);
            this.toolStripBtnGrafic.Text = "Statistici";
            this.toolStripBtnGrafic.Click += new System.EventHandler(this.toolStripBtnGrafic_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // FormularRezervare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 885);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnEditeaza);
            this.Controls.Add(this.btnCurata);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lvRezervari);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularRezervare";
            this.Text = "Formular rezervare";
            this.Load += new System.EventHandler(this.FormularRezervare_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormularPrincipal_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cms.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvRezervari;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnCurata;
        private System.Windows.Forms.CheckBox checkScaunCopil;
        private System.Windows.Forms.CheckBox checkMicDejunInclus;
        private System.Windows.Forms.CheckBox checkPatSuplimentar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.CheckBox checkLocDeParcare;
        private System.Windows.Forms.Button btnEditeaza;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbVedere;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operatiiBinareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareBinara;
        private System.Windows.Forms.ToolStripMenuItem deserializareBinara;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareXML;
        private System.Windows.Forms.ToolStripMenuItem deserializareXML;
        private System.Windows.Forms.ToolStripMenuItem fisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem export;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonClienti;
        private System.Windows.Forms.ListBox listBoxClienti;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtnFisier;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBtnGrafic;
    }
}

