
namespace Proiect
{
    partial class FormularFisiere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularFisiere));
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnRezervari = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnClienti = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripBtnFisierText = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AllowDrop = true;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(33, 106);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(287, 290);
            this.panel.TabIndex = 0;
            this.panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drop area";
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(433, 82);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(264, 398);
            this.treeView.TabIndex = 2;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnRezervari,
            this.toolStripSeparator1,
            this.toolStripBtnClienti,
            this.toolStripSeparator2,
            this.toolStripBtnFisierText});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 33);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnRezervari
            // 
            this.toolStripBtnRezervari.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnRezervari.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnRezervari.Image")));
            this.toolStripBtnRezervari.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnRezervari.Name = "toolStripBtnRezervari";
            this.toolStripBtnRezervari.Size = new System.Drawing.Size(34, 28);
            this.toolStripBtnRezervari.Text = "Rezervari";
            this.toolStripBtnRezervari.Click += new System.EventHandler(this.toolStripBtnRezervari_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripBtnClienti
            // 
            this.toolStripBtnClienti.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnClienti.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnClienti.Image")));
            this.toolStripBtnClienti.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnClienti.Name = "toolStripBtnClienti";
            this.toolStripBtnClienti.Size = new System.Drawing.Size(34, 33);
            this.toolStripBtnClienti.Text = "Clienti";
            this.toolStripBtnClienti.Click += new System.EventHandler(this.toolStripBtnClienti_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 32);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(162, 25);
            this.statusLabel.Text = "Niciun nod selectat";
            // 
            // toolStripBtnFisierText
            // 
            this.toolStripBtnFisierText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnFisierText.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnFisierText.Image")));
            this.toolStripBtnFisierText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnFisierText.Name = "toolStripBtnFisierText";
            this.toolStripBtnFisierText.Size = new System.Drawing.Size(34, 28);
            this.toolStripBtnFisierText.Text = "Fisier text";
            this.toolStripBtnFisierText.Click += new System.EventHandler(this.toolStripBtnFisierText_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // FormularFisiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Name = "FormularFisiere";
            this.Text = "Statistici";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnRezervari;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtnClienti;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripButton toolStripBtnFisierText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}