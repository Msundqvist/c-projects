﻿namespace Inlamning_3._0
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
            menuStrip1 = new MenuStrip();
            menyToolStripMenuItem = new ToolStripMenuItem();
            registreraAnvändareToolStripMenuItem = new ToolStripMenuItem();
            avslutaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menyToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(255, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menyToolStripMenuItem
            // 
            menyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registreraAnvändareToolStripMenuItem, avslutaToolStripMenuItem });
            menyToolStripMenuItem.Name = "menyToolStripMenuItem";
            menyToolStripMenuItem.Size = new Size(49, 20);
            menyToolStripMenuItem.Text = "Meny";
            // 
            // registreraAnvändareToolStripMenuItem
            // 
            registreraAnvändareToolStripMenuItem.Name = "registreraAnvändareToolStripMenuItem";
            registreraAnvändareToolStripMenuItem.Size = new Size(184, 22);
            registreraAnvändareToolStripMenuItem.Text = "Registrera användare";
            registreraAnvändareToolStripMenuItem.Click += registreraAnvändareToolStripMenuItem_Click;
            // 
            // avslutaToolStripMenuItem
            // 
            avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            avslutaToolStripMenuItem.Size = new Size(184, 22);
            avslutaToolStripMenuItem.Text = "Avsluta";
            avslutaToolStripMenuItem.Click += avslutaToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 244);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Meny";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menyToolStripMenuItem;
        private ToolStripMenuItem registreraAnvändareToolStripMenuItem;
        private ToolStripMenuItem avslutaToolStripMenuItem;
    }
}