
namespace Proiect
{
    partial class FormularFisiereText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularFisiereText));
            this.src = new System.Windows.Forms.PictureBox();
            this.dst = new System.Windows.Forms.PictureBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.tbSrc = new System.Windows.Forms.TextBox();
            this.tbDst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnFisier = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.src)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dst)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // src
            // 
            this.src.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.src.Location = new System.Drawing.Point(77, 98);
            this.src.Name = "src";
            this.src.Size = new System.Drawing.Size(164, 165);
            this.src.TabIndex = 0;
            this.src.TabStop = false;
            // 
            // dst
            // 
            this.dst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dst.Location = new System.Drawing.Point(458, 98);
            this.dst.Name = "dst";
            this.dst.Size = new System.Drawing.Size(164, 165);
            this.dst.TabIndex = 1;
            this.dst.TabStop = false;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(308, 148);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(90, 69);
            this.btnSwitch.TabIndex = 2;
            this.btnSwitch.Text = "Schimba";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // tbSrc
            // 
            this.tbSrc.Location = new System.Drawing.Point(132, 316);
            this.tbSrc.Name = "tbSrc";
            this.tbSrc.Size = new System.Drawing.Size(299, 26);
            this.tbSrc.TabIndex = 3;
            // 
            // tbDst
            // 
            this.tbDst.Location = new System.Drawing.Point(132, 368);
            this.tbDst.Name = "tbDst";
            this.tbDst.Size = new System.Drawing.Size(299, 26);
            this.tbDst.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Copy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Paste";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(501, 316);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 33);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(501, 368);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 33);
            this.btnPaste.TabIndex = 8;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnFisier});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 33);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnFisier
            // 
            this.toolStripBtnFisier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnFisier.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnFisier.Image")));
            this.toolStripBtnFisier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnFisier.Name = "toolStripBtnFisier";
            this.toolStripBtnFisier.Size = new System.Drawing.Size(34, 28);
            this.toolStripBtnFisier.Text = "toolStripButton1";
            this.toolStripBtnFisier.Click += new System.EventHandler(this.toolStripBtnFisier_Click);
            // 
            // FormularFisiereText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDst);
            this.Controls.Add(this.tbSrc);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.dst);
            this.Controls.Add(this.src);
            this.Name = "FormularFisiereText";
            this.Text = "FormularFisierText";
            ((System.ComponentModel.ISupportInitialize)(this.src)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dst)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox src;
        private System.Windows.Forms.PictureBox dst;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.TextBox tbSrc;
        private System.Windows.Forms.TextBox tbDst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnFisier;
    }
}