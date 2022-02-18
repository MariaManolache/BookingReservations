
namespace Proiect
{
    partial class FormularEditareRezervare
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.listBoxClienti = new System.Windows.Forms.ListBox();
            this.checkLocDeParcare = new System.Windows.Forms.CheckBox();
            this.checkScaunCopil = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkMicDejunInclus = new System.Windows.Forms.CheckBox();
            this.checkPatSuplimentar = new System.Windows.Forms.CheckBox();
            this.cbVedere = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbTip);
            this.groupBox1.Controls.Add(this.listBoxClienti);
            this.groupBox1.Controls.Add(this.checkLocDeParcare);
            this.groupBox1.Controls.Add(this.checkScaunCopil);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.checkMicDejunInclus);
            this.groupBox1.Controls.Add(this.checkPatSuplimentar);
            this.groupBox1.Controls.Add(this.cbVedere);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpCheckOut);
            this.groupBox1.Controls.Add(this.dtpCheckIn);
            this.groupBox1.Location = new System.Drawing.Point(37, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 617);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editare rezervare";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Clienti";
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple",
            "Apartament"});
            this.cbTip.Location = new System.Drawing.Point(10, 313);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(260, 28);
            this.cbTip.TabIndex = 10;
            // 
            // listBoxClienti
            // 
            this.listBoxClienti.FormattingEnabled = true;
            this.listBoxClienti.ItemHeight = 20;
            this.listBoxClienti.Location = new System.Drawing.Point(10, 116);
            this.listBoxClienti.Name = "listBoxClienti";
            this.listBoxClienti.Size = new System.Drawing.Size(268, 84);
            this.listBoxClienti.TabIndex = 12;
            // 
            // checkLocDeParcare
            // 
            this.checkLocDeParcare.AutoSize = true;
            this.checkLocDeParcare.Location = new System.Drawing.Point(194, 569);
            this.checkLocDeParcare.Name = "checkLocDeParcare";
            this.checkLocDeParcare.Size = new System.Drawing.Size(141, 24);
            this.checkLocDeParcare.TabIndex = 10;
            this.checkLocDeParcare.Text = "Loc de parcare";
            this.checkLocDeParcare.UseVisualStyleBackColor = true;
            // 
            // checkScaunCopil
            // 
            this.checkScaunCopil.AutoSize = true;
            this.checkScaunCopil.Location = new System.Drawing.Point(0, 569);
            this.checkScaunCopil.Name = "checkScaunCopil";
            this.checkScaunCopil.Size = new System.Drawing.Size(167, 24);
            this.checkScaunCopil.TabIndex = 9;
            this.checkScaunCopil.Text = "Scaun pentru copil";
            this.checkScaunCopil.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tip";
            // 
            // checkMicDejunInclus
            // 
            this.checkMicDejunInclus.AutoSize = true;
            this.checkMicDejunInclus.Location = new System.Drawing.Point(194, 524);
            this.checkMicDejunInclus.Name = "checkMicDejunInclus";
            this.checkMicDejunInclus.Size = new System.Drawing.Size(146, 24);
            this.checkMicDejunInclus.TabIndex = 8;
            this.checkMicDejunInclus.Text = "Mic dejun inclus";
            this.checkMicDejunInclus.UseVisualStyleBackColor = true;
            // 
            // checkPatSuplimentar
            // 
            this.checkPatSuplimentar.AutoSize = true;
            this.checkPatSuplimentar.Location = new System.Drawing.Point(0, 524);
            this.checkPatSuplimentar.Name = "checkPatSuplimentar";
            this.checkPatSuplimentar.Size = new System.Drawing.Size(145, 24);
            this.checkPatSuplimentar.TabIndex = 7;
            this.checkPatSuplimentar.Text = "Pat suplimentar";
            this.checkPatSuplimentar.UseVisualStyleBackColor = true;
            // 
            // cbVedere
            // 
            this.cbVedere.FormattingEnabled = true;
            this.cbVedere.Items.AddRange(new object[] {
            "Gradina",
            "Plaja",
            "Parcare",
            "Strada principala"});
            this.cbVedere.Location = new System.Drawing.Point(10, 244);
            this.cbVedere.Name = "cbVedere";
            this.cbVedere.Size = new System.Drawing.Size(260, 28);
            this.cbVedere.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Facilitati";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data check out";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Vedere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data check in";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(6, 441);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(264, 26);
            this.dtpCheckOut.TabIndex = 1;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(6, 378);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(264, 26);
            this.dtpCheckIn.TabIndex = 2;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalveaza.Location = new System.Drawing.Point(43, 678);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(106, 59);
            this.btnSalveaza.TabIndex = 6;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnRenunta
            // 
            this.btnRenunta.Location = new System.Drawing.Point(231, 678);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(107, 59);
            this.btnRenunta.TabIndex = 7;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // FormularEditareRezervare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 749);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "FormularEditareRezervare";
            this.Text = "Formular Editare Rezervare";
            this.Load += new System.EventHandler(this.FormularEditareRezervare_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormularEditareRezervare_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkLocDeParcare;
        private System.Windows.Forms.CheckBox checkScaunCopil;
        private System.Windows.Forms.CheckBox checkMicDejunInclus;
        private System.Windows.Forms.CheckBox checkPatSuplimentar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbVedere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxClienti;
    }
}