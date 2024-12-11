namespace Inlamning_3._0
{
    partial class formular
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
            lblfirstName = new Label();
            lblSurName = new Label();
            lblSocialSecurityNumber = new Label();
            tbxFirstName = new TextBox();
            tbxSurName = new TextBox();
            tbxSocialSecurityNumber = new TextBox();
            tbxResults = new TextBox();
            btnOk = new Button();
            menuStrip1 = new MenuStrip();
            stToolStripMenuItem = new ToolStripMenuItem();
            startsidaToolStripMenuItem = new ToolStripMenuItem();
            avslutaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblfirstName
            // 
            lblfirstName.AutoSize = true;
            lblfirstName.Location = new Point(87, 71);
            lblfirstName.Name = "lblfirstName";
            lblfirstName.Size = new Size(58, 15);
            lblfirstName.TabIndex = 0;
            lblfirstName.Text = "Förnamn:";
            // 
            // lblSurName
            // 
            lblSurName.AutoSize = true;
            lblSurName.Location = new Point(80, 100);
            lblSurName.Name = "lblSurName";
            lblSurName.Size = new Size(65, 15);
            lblSurName.TabIndex = 1;
            lblSurName.Text = "Efternamn:";
            // 
            // lblSocialSecurityNumber
            // 
            lblSocialSecurityNumber.AutoSize = true;
            lblSocialSecurityNumber.Location = new Point(53, 121);
            lblSocialSecurityNumber.Name = "lblSocialSecurityNumber";
            lblSocialSecurityNumber.Size = new Size(92, 15);
            lblSocialSecurityNumber.TabIndex = 2;
            lblSocialSecurityNumber.Text = "Personnummer:";
            // 
            // tbxFirstName
            // 
            tbxFirstName.Location = new Point(160, 63);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(100, 23);
            tbxFirstName.TabIndex = 3;
            // 
            // tbxSurName
            // 
            tbxSurName.Location = new Point(160, 92);
            tbxSurName.Name = "tbxSurName";
            tbxSurName.Size = new Size(100, 23);
            tbxSurName.TabIndex = 4;
            // 
            // tbxSocialSecurityNumber
            // 
            tbxSocialSecurityNumber.Location = new Point(160, 121);
            tbxSocialSecurityNumber.Name = "tbxSocialSecurityNumber";
            tbxSocialSecurityNumber.Size = new Size(100, 23);
            tbxSocialSecurityNumber.TabIndex = 5;
            // 
            // tbxResults
            // 
            tbxResults.Location = new Point(45, 159);
            tbxResults.Multiline = true;
            tbxResults.Name = "tbxResults";
            tbxResults.Size = new Size(319, 183);
            tbxResults.TabIndex = 6;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(289, 92);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 7;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { stToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(441, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // stToolStripMenuItem
            // 
            stToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startsidaToolStripMenuItem, avslutaToolStripMenuItem });
            stToolStripMenuItem.Name = "stToolStripMenuItem";
            stToolStripMenuItem.Size = new Size(49, 20);
            stToolStripMenuItem.Text = "Meny";
            // 
            // startsidaToolStripMenuItem
            // 
            startsidaToolStripMenuItem.Name = "startsidaToolStripMenuItem";
            startsidaToolStripMenuItem.Size = new Size(180, 22);
            startsidaToolStripMenuItem.Text = "Startsida";
            startsidaToolStripMenuItem.Click += startsidaToolStripMenuItem_Click;
            // 
            // avslutaToolStripMenuItem
            // 
            avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            avslutaToolStripMenuItem.Size = new Size(180, 22);
            avslutaToolStripMenuItem.Text = "Avsluta";
            avslutaToolStripMenuItem.Click += avslutaToolStripMenuItem_Click;
            // 
            // formular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 374);
            Controls.Add(btnOk);
            Controls.Add(tbxResults);
            Controls.Add(tbxSocialSecurityNumber);
            Controls.Add(tbxSurName);
            Controls.Add(tbxFirstName);
            Controls.Add(lblSocialSecurityNumber);
            Controls.Add(lblSurName);
            Controls.Add(lblfirstName);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "formular";
            Text = "formular";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblfirstName;
        private Label lblSurName;
        private Label lblSocialSecurityNumber;
        private TextBox tbxFirstName;
        private TextBox tbxSurName;
        private TextBox tbxSocialSecurityNumber;
        private TextBox tbxResults;
        private Button btnOk;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem stToolStripMenuItem;
        private ToolStripMenuItem startsidaToolStripMenuItem;
        private ToolStripMenuItem avslutaToolStripMenuItem;
    }
}