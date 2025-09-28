namespace WinFormsmedia_tech
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            Accueil = new Button();
            Catalogue = new Button();
            A_propos = new Button();
            Se_Connecter = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(Se_Connecter);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(A_propos);
            panel1.Controls.Add(Accueil);
            panel1.Controls.Add(Catalogue);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 58);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(27, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 38);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Accueil
            // 
            Accueil.BackColor = SystemColors.ActiveCaptionText;
            Accueil.ForeColor = SystemColors.ButtonHighlight;
            Accueil.Location = new Point(414, 22);
            Accueil.Name = "Accueil";
            Accueil.Size = new Size(70, 29);
            Accueil.TabIndex = 1;
            Accueil.Text = "Accueil";
            Accueil.UseVisualStyleBackColor = false;
            Accueil.Click += button1_Click;
            // 
            // Catalogue
            // 
            Catalogue.Location = new Point(490, 22);
            Catalogue.Name = "Catalogue";
            Catalogue.Size = new Size(72, 29);
            Catalogue.TabIndex = 2;
            Catalogue.Text = "Catalogue";
            Catalogue.UseVisualStyleBackColor = true;
            Catalogue.Click += button2_Click;
            // 
            // A_propos
            // 
            A_propos.Location = new Point(568, 22);
            A_propos.Name = "A_propos";
            A_propos.Size = new Size(94, 29);
            A_propos.TabIndex = 3;
            A_propos.Text = "A_propos";
            A_propos.TextImageRelation = TextImageRelation.TextBeforeImage;
            A_propos.UseVisualStyleBackColor = true;
            // 
            // Se_Connecter
            // 
            Se_Connecter.Location = new Point(705, 22);
            Se_Connecter.Name = "Se_Connecter";
            Se_Connecter.Size = new Size(94, 29);
            Se_Connecter.TabIndex = 4;
            Se_Connecter.Text = "Se_Connecter";
            Se_Connecter.UseVisualStyleBackColor = true;
            Se_Connecter.Click += SeConnecter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Média_Tech";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button Accueil;
        private Button Catalogue;
        private Button A_propos;
        private Button Se_Connecter;
    }
}
