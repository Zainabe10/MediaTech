﻿namespace WinFormsmedia_tech
{
    partial class HeaderControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeaderControl));
            panel1 = new Panel();
            textBox1 = new TextBox();
            Se_Connecter = new Button();
            pictureBox1 = new PictureBox();
            A_propos = new Button();
            Accueil = new Button();
            Catalogue = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(Se_Connecter);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(A_propos);
            panel1.Controls.Add(Accueil);
            panel1.Controls.Add(Catalogue);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(2574, 55);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint_2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(465, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(965, 23);
            textBox1.TabIndex = 5;
            textBox1.Click += btnSearch_Click;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // Se_Connecter
            // 
            Se_Connecter.Location = new Point(2227, 2);
            Se_Connecter.Margin = new Padding(3, 2, 3, 2);
            Se_Connecter.Name = "Se_Connecter";
            Se_Connecter.Size = new Size(215, 53);
            Se_Connecter.TabIndex = 4;
            Se_Connecter.Text = "Se_Connecter";
            Se_Connecter.UseVisualStyleBackColor = true;
            Se_Connecter.Click += btnSeConnecter_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += btnLogo_Click;
            // 
            // A_propos
            // 
            A_propos.Location = new Point(1810, 10);
            A_propos.Margin = new Padding(3, 2, 3, 2);
            A_propos.Name = "A_propos";
            A_propos.Size = new Size(152, 36);
            A_propos.TabIndex = 3;
            A_propos.Text = "A_propos";
            A_propos.TextImageRelation = TextImageRelation.TextBeforeImage;
            A_propos.UseVisualStyleBackColor = true;
            A_propos.Click += btnApropos_Click;
            // 
            // Accueil
            // 
            Accueil.BackColor = SystemColors.ActiveCaptionText;
            Accueil.ForeColor = SystemColors.ButtonHighlight;
            Accueil.Location = new Point(1490, 10);
            Accueil.Margin = new Padding(3, 2, 3, 2);
            Accueil.Name = "Accueil";
            Accueil.Size = new Size(156, 36);
            Accueil.TabIndex = 1;
            Accueil.Text = "Accueil";
            Accueil.UseVisualStyleBackColor = false;
            Accueil.Click += btnAccueil_Click;
            // 
            // Catalogue
            // 
            Catalogue.Location = new Point(1652, 10);
            Catalogue.Margin = new Padding(3, 2, 3, 2);
            Catalogue.Name = "Catalogue";
            Catalogue.Size = new Size(137, 36);
            Catalogue.TabIndex = 2;
            Catalogue.Text = "Catalogue";
            Catalogue.UseVisualStyleBackColor = true;
            Catalogue.Click += btnCatalogue_Click;
            // 
            // HeaderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel1);
            Name = "HeaderControl";
            Size = new Size(2574, 1036);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Button Se_Connecter;
        private PictureBox pictureBox1;
        private Button A_propos;
        private Button Accueil;
        private Button Catalogue;
    }
}
