    namespace WinFormsAppPierreFeuilleCiseauGraphique
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources doivent être supprimées ; sinon false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Forms

        private void InitializeComponent()
        {
            btnJouer = new Button();
            textBox1 = new TextBox();
            btnRegles = new Button();
            btnQuitter = new Button();
            panelJeu = new Panel();
            textBox3 = new TextBox();
            btnRetour = new Button();
            btnCiseaux = new Button();
            btnFeuille = new Button();
            btnPierre = new Button();
            pnlRegles = new Panel();
            btnRetourRegles = new Button();
            textBox2 = new TextBox();
            rejouer = new Button();
            panelJeu.SuspendLayout();
            pnlRegles.SuspendLayout();
            SuspendLayout();
            // 
            // btnJouer
            // 
            btnJouer.BackColor = SystemColors.InactiveBorder;
            btnJouer.Location = new Point(514, 157);
            btnJouer.Name = "btnJouer";
            btnJouer.Size = new Size(111, 33);
            btnJouer.TabIndex = 0;
            btnJouer.Text = "Jouer";
            btnJouer.UseVisualStyleBackColor = false;
            btnJouer.Click += btnJouer_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.Enabled = false;
            textBox1.Location = new Point(413, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 31);
            textBox1.TabIndex = 1;
            textBox1.Text = "Bienvenue dans le Pierre Feuille Ciseaux !";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // btnRegles
            // 
            btnRegles.BackColor = SystemColors.InactiveBorder;
            btnRegles.Location = new Point(514, 248);
            btnRegles.Name = "btnRegles";
            btnRegles.Size = new Size(111, 33);
            btnRegles.TabIndex = 2;
            btnRegles.Text = "Règles";
            btnRegles.UseVisualStyleBackColor = false;
            btnRegles.Click += btnRegles_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.BackColor = SystemColors.InactiveBorder;
            btnQuitter.Location = new Point(514, 342);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(111, 33);
            btnQuitter.TabIndex = 3;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = false;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // panelJeu
            // 
            panelJeu.Controls.Add(rejouer);
            panelJeu.Controls.Add(textBox3);
            panelJeu.Controls.Add(btnRetour);
            panelJeu.Controls.Add(btnCiseaux);
            panelJeu.Controls.Add(btnFeuille);
            panelJeu.Controls.Add(btnPierre);
            panelJeu.Dock = DockStyle.Fill;
            panelJeu.Location = new Point(0, 0);
            panelJeu.Name = "panelJeu";
            panelJeu.Size = new Size(1171, 558);
            panelJeu.TabIndex = 4;
            panelJeu.Paint += panelJeu_Paint;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(498, 55);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(128, 31);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // btnRetour
            // 
            btnRetour.BackColor = SystemColors.InactiveBorder;
            btnRetour.Location = new Point(446, 476);
            btnRetour.Margin = new Padding(4, 5, 4, 5);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(107, 38);
            btnRetour.TabIndex = 3;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += buttonRetour_Click;
            // 
            // btnCiseaux
            // 
            btnCiseaux.Location = new Point(733, 315);
            btnCiseaux.Name = "btnCiseaux";
            btnCiseaux.Size = new Size(111, 33);
            btnCiseaux.TabIndex = 2;
            btnCiseaux.Text = "Ciseaux";
            btnCiseaux.UseVisualStyleBackColor = true;
            btnCiseaux.Click += buttonCiseaux_Click;
            // 
            // btnFeuille
            // 
            btnFeuille.Location = new Point(513, 315);
            btnFeuille.Name = "btnFeuille";
            btnFeuille.Size = new Size(111, 33);
            btnFeuille.TabIndex = 1;
            btnFeuille.Text = "Feuille";
            btnFeuille.UseVisualStyleBackColor = true;
            btnFeuille.Click += btnFeuille_Click;
            // 
            // btnPierre
            // 
            btnPierre.Location = new Point(301, 315);
            btnPierre.Name = "btnPierre";
            btnPierre.Size = new Size(111, 33);
            btnPierre.TabIndex = 0;
            btnPierre.Text = "Pierre";
            btnPierre.UseVisualStyleBackColor = true;
            btnPierre.Click += btnPierre_Click;
            // 
            // pnlRegles
            // 
            pnlRegles.Controls.Add(btnRetourRegles);
            pnlRegles.Controls.Add(textBox2);
            pnlRegles.Dock = DockStyle.Fill;
            pnlRegles.Location = new Point(0, 0);
            pnlRegles.Name = "pnlRegles";
            pnlRegles.Size = new Size(1171, 558);
            pnlRegles.TabIndex = 5;
            pnlRegles.Paint += panel1_Paint;
            // 
            // btnRetourRegles
            // 
            btnRetourRegles.Location = new Point(513, 383);
            btnRetourRegles.Name = "btnRetourRegles";
            btnRetourRegles.Size = new Size(107, 38);
            btnRetourRegles.TabIndex = 1;
            btnRetourRegles.Text = "Retour";
            btnRetourRegles.UseVisualStyleBackColor = true;
            btnRetourRegles.Click += buttonRetourRegles_Click;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(220, 123);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(701, 36);
            textBox2.TabIndex = 0;
            textBox2.Text = "Pierre bat Ciseaux, Ciseaux bat Feuille et Feuille bat Pierre.";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // rejouer
            // 
            rejouer.Location = new Point(601, 476);
            rejouer.Name = "rejouer";
            rejouer.Size = new Size(112, 34);
            rejouer.TabIndex = 5;
            rejouer.Text = "Rejouer";
            rejouer.UseVisualStyleBackColor = true;
            rejouer.Click += rejouer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1171, 558);
            Controls.Add(panelJeu);
            Controls.Add(btnQuitter);
            Controls.Add(btnRegles);
            Controls.Add(textBox1);
            Controls.Add(btnJouer);
            Controls.Add(pnlRegles);
            Name = "Form1";
            Text = "Pierre Feuille Ciseaux";
            Load += Form1_Load;
            panelJeu.ResumeLayout(false);
            panelJeu.PerformLayout();
            pnlRegles.ResumeLayout(false);
            pnlRegles.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnJouer;
        private TextBox textBox1;
        private Button btnRegles;
        private Button btnQuitter;

        private Panel panelJeu;
        private Button btnCiseaux;
        private Button btnFeuille;
        private Button btnPierre;
        private Button btnRetour;

        private Panel pnlRegles;
        private TextBox textBox2;
        private Button btnRetourRegles;
        private TextBox textBox3;
        private Button rejouer;
    }
}
