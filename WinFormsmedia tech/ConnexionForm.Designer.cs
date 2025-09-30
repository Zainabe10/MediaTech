namespace WinFormsmedia_tech
{
    partial class ConnexionForm
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
            labelTitre = new Label();
            labelNom = new Label();
            textBoxEmail = new TextBox();
            textBoxMdp = new TextBox();
            labelEmail = new Label();
            labelMdp = new Label();
            buttonValider = new Button();
            SuspendLayout();
            // 
            // labelTitre
            // 
            labelTitre.Anchor = AnchorStyles.Top;
            labelTitre.AutoSize = true;
            labelTitre.Font = new Font("Sans Serif Collection", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitre.ImageAlign = ContentAlignment.TopCenter;
            labelTitre.Location = new Point(100, 20);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(416, 217);
            labelTitre.TabIndex = 0;
            labelTitre.Text = "Connexion";
            labelTitre.TextAlign = ContentAlignment.TopCenter;
            labelTitre.Click += label1_Click;
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(185, 323);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(0, 15);
            labelNom.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(218, 292);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(256, 46);
            textBoxEmail.TabIndex = 2;
            textBoxEmail.TextChanged += textBox1_TextChanged;
            // 
            // textBoxMdp
            // 
            textBoxMdp.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxMdp.Location = new Point(218, 425);
            textBoxMdp.Name = "textBoxMdp";
            textBoxMdp.Size = new Size(256, 46);
            textBoxMdp.TabIndex = 3;
            textBoxMdp.UseSystemPasswordChar = true;
            textBoxMdp.TextChanged += textBox2_TextChanged;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(218, 237);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(100, 40);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email :";
            // 
            // labelMdp
            // 
            labelMdp.AutoSize = true;
            labelMdp.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMdp.Location = new Point(218, 366);
            labelMdp.Name = "labelMdp";
            labelMdp.Size = new Size(203, 40);
            labelMdp.TabIndex = 5;
            labelMdp.Text = "Mot de passe :";
            // 
            // buttonValider
            // 
            buttonValider.BackColor = Color.FromArgb(192, 255, 192);
            buttonValider.Location = new Point(243, 557);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(75, 23);
            buttonValider.TabIndex = 6;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = false;
            // 
            // ConnexionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1981, 1015);
            Controls.Add(buttonValider);
            Controls.Add(labelMdp);
            Controls.Add(labelEmail);
            Controls.Add(textBoxMdp);
            Controls.Add(textBoxEmail);
            Controls.Add(labelNom);
            Controls.Add(labelTitre);
            Name = "ConnexionForm";
            Text = "ConnexionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitre;
        private Label labelNom;
        private TextBox textBoxEmail;
        private TextBox textBoxMdp;
        private Label labelEmail;
        private Label labelMdp;
        private Button buttonValider;
    }
}