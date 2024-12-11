namespace Inlämning_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNamn = new Label();
            lblPersonNummer = new Label();
            lblDistrikt = new Label();
            lblAntal = new Label();
            tbxNamn = new TextBox();
            tbxPersonNummer = new TextBox();
            tbxDistrikt = new TextBox();
            tbxAntal = new TextBox();
            btnLaggTill = new Button();
            tbxResultat = new TextBox();
            btnSkrivUt = new Button();
            btnSpara = new Button();
            SuspendLayout();
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Location = new Point(64, 32);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(46, 15);
            lblNamn.TabIndex = 0;
            lblNamn.Text = "Namn :";
            // 
            // lblPersonNummer
            // 
            lblPersonNummer.AutoSize = true;
            lblPersonNummer.Location = new Point(12, 65);
            lblPersonNummer.Name = "lblPersonNummer";
            lblPersonNummer.Size = new Size(98, 15);
            lblPersonNummer.TabIndex = 1;
            lblPersonNummer.Text = "Personnummer : ";
            // 
            // lblDistrikt
            // 
            lblDistrikt.AutoSize = true;
            lblDistrikt.Location = new Point(60, 95);
            lblDistrikt.Name = "lblDistrikt";
            lblDistrikt.Size = new Size(50, 15);
            lblDistrikt.TabIndex = 2;
            lblDistrikt.Text = "Distrikt :";
            // 
            // lblAntal
            // 
            lblAntal.AutoSize = true;
            lblAntal.Location = new Point(66, 123);
            lblAntal.Name = "lblAntal";
            lblAntal.Size = new Size(44, 15);
            lblAntal.TabIndex = 3;
            lblAntal.Text = "Antal : ";
            // 
            // tbxNamn
            // 
            tbxNamn.Location = new Point(129, 24);
            tbxNamn.Name = "tbxNamn";
            tbxNamn.Size = new Size(100, 23);
            tbxNamn.TabIndex = 4;
            // 
            // tbxPersonNummer
            // 
            tbxPersonNummer.Location = new Point(129, 57);
            tbxPersonNummer.Name = "tbxPersonNummer";
            tbxPersonNummer.Size = new Size(100, 23);
            tbxPersonNummer.TabIndex = 5;
            // 
            // tbxDistrikt
            // 
            tbxDistrikt.Location = new Point(129, 87);
            tbxDistrikt.Name = "tbxDistrikt";
            tbxDistrikt.Size = new Size(100, 23);
            tbxDistrikt.TabIndex = 6;
            // 
            // tbxAntal
            // 
            tbxAntal.Location = new Point(129, 115);
            tbxAntal.Name = "tbxAntal";
            tbxAntal.Size = new Size(100, 23);
            tbxAntal.TabIndex = 7;
            // 
            // btnLaggTill
            // 
            btnLaggTill.Location = new Point(259, 61);
            btnLaggTill.Name = "btnLaggTill";
            btnLaggTill.Size = new Size(75, 23);
            btnLaggTill.TabIndex = 8;
            btnLaggTill.Text = "Lägg till";
            btnLaggTill.UseVisualStyleBackColor = true;
            btnLaggTill.Click += btnLaggTill_Click;
            // 
            // tbxResultat
            // 
            tbxResultat.Location = new Point(12, 154);
            tbxResultat.Multiline = true;
            tbxResultat.Name = "tbxResultat";
            tbxResultat.ScrollBars = ScrollBars.Vertical;
            tbxResultat.Size = new Size(421, 223);
            tbxResultat.TabIndex = 9;
            // 
            // btnSkrivUt
            // 
            btnSkrivUt.Location = new Point(259, 95);
            btnSkrivUt.Name = "btnSkrivUt";
            btnSkrivUt.Size = new Size(75, 23);
            btnSkrivUt.TabIndex = 10;
            btnSkrivUt.Text = "Skriv ut ";
            btnSkrivUt.UseVisualStyleBackColor = true;
            btnSkrivUt.Click += btnSkrivUt_Click;
            // 
            // btnSpara
            // 
            btnSpara.Location = new Point(358, 76);
            btnSpara.Name = "btnSpara";
            btnSpara.Size = new Size(75, 23);
            btnSpara.TabIndex = 11;
            btnSpara.Text = "Spara till fil";
            btnSpara.UseVisualStyleBackColor = true;
            btnSpara.Click += btnSpara_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 389);
            Controls.Add(btnSpara);
            Controls.Add(btnSkrivUt);
            Controls.Add(tbxResultat);
            Controls.Add(btnLaggTill);
            Controls.Add(tbxAntal);
            Controls.Add(tbxDistrikt);
            Controls.Add(tbxPersonNummer);
            Controls.Add(tbxNamn);
            Controls.Add(lblAntal);
            Controls.Add(lblDistrikt);
            Controls.Add(lblPersonNummer);
            Controls.Add(lblNamn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNamn;
        private Label lblPersonNummer;
        private Label lblDistrikt;
        private Label lblAntal;
        private TextBox tbxNamn;
        private TextBox tbxPersonNummer;
        private TextBox tbxDistrikt;
        private TextBox tbxAntal;
        private Button btnLaggTill;
        private TextBox tbxResultat;
        private Button btnSkrivUt;
        private Button btnSpara;
    }
}