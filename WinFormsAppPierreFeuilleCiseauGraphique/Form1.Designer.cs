
namespace WinFormsAppPierreFeuilleCiseauGraphique
{
    partial class Form1
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

        private void InitializeComponent()
        {
            btnJouer = new Button();
            textBox1 = new TextBox();
            btnRegles = new Button();
            btnQuitter = new Button();
            panelJeu = new Panel();
            pnlRegles = new Panel();
            textBox2 = new TextBox();
            btnRetour = new Button();
            btnCiseaux = new Button();
            btnFeuille = new Button();
            btnPierre = new Button();
            btnRetourRegles = new Button();
            panelJeu.SuspendLayout();
            pnlRegles.SuspendLayout();
            SuspendLayout();
            // 
            // btnJouer
            // 
            btnJouer.BackColor = SystemColors.InactiveBorder;
            btnJouer.Location = new Point(360, 94);
            btnJouer.Margin = new Padding(2);
            btnJouer.Name = "btnJouer";
            btnJouer.Size = new Size(78, 20);
            btnJouer.TabIndex = 0;
            btnJouer.Text = "Jouer";
            btnJouer.UseVisualStyleBackColor = false;
            btnJouer.Click += btnJouer_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.Enabled = false;
            textBox1.Location = new Point(289, 46);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "Bienvenue dans le Pierre Feuille Ciseaux !";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // btnRegles
            // 
            btnRegles.BackColor = SystemColors.InactiveBorder;
            btnRegles.Location = new Point(360, 149);
            btnRegles.Margin = new Padding(2);
            btnRegles.Name = "btnRegles";
            btnRegles.Size = new Size(78, 20);
            btnRegles.TabIndex = 2;
            btnRegles.Text = "Règles";
            btnRegles.UseVisualStyleBackColor = false;
            btnRegles.Click += btnRegles_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.BackColor = SystemColors.InactiveBorder;
            btnQuitter.Location = new Point(360, 205);
            btnQuitter.Margin = new Padding(2);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(78, 20);
            btnQuitter.TabIndex = 3;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = false;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // panelJeu
            // 
            panelJeu.Controls.Add(pnlRegles);
            panelJeu.Controls.Add(btnRetour);
            panelJeu.Controls.Add(btnCiseaux);
            panelJeu.Controls.Add(btnFeuille);
            panelJeu.Controls.Add(btnPierre);
            panelJeu.Dock = DockStyle.Fill;
            panelJeu.Location = new Point(0, 0);
            panelJeu.Margin = new Padding(2);
            panelJeu.Name = "panelJeu";
            panelJeu.Size = new Size(820, 335);
            panelJeu.TabIndex = 4;
            panelJeu.Paint += panelJeu_Paint;
            // 
            // pnlRegles
            // 
            pnlRegles.Controls.Add(btnRetourRegles);
            pnlRegles.Controls.Add(textBox2);
            pnlRegles.Location = new Point(0, 0);
            pnlRegles.Name = "pnlRegles";
            pnlRegles.Size = new Size(820, 335);
            pnlRegles.TabIndex = 4;
            pnlRegles.Paint += panel1_Paint;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(154, 74);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(492, 23);
            textBox2.TabIndex = 0;
            textBox2.Text = "Jeu avec des boutons simples, cliquer sur les boutons pour naviguer entre les menus ! ";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.UseWaitCursor = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btnRetour
            // 
            btnRetour.BackColor = SystemColors.InactiveBorder;
            btnRetour.Location = new Point(363, 286);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(75, 23);
            btnRetour.TabIndex = 3;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += buttonRetour_Click;
            // 
            // btnCiseaux
            // 
            btnCiseaux.Location = new Point(513, 189);
            btnCiseaux.Margin = new Padding(2);
            btnCiseaux.Name = "btnCiseaux";
            btnCiseaux.Size = new Size(78, 20);
            btnCiseaux.TabIndex = 2;
            btnCiseaux.Text = "Ciseaux";
            btnCiseaux.UseVisualStyleBackColor = true;
            btnCiseaux.Click += buttonCiseaux_Click;
            // 
            // btnFeuille
            // 
            btnFeuille.Location = new Point(359, 189);
            btnFeuille.Margin = new Padding(2);
            btnFeuille.Name = "btnFeuille";
            btnFeuille.Size = new Size(78, 20);
            btnFeuille.TabIndex = 1;
            btnFeuille.Text = "Feuille";
            btnFeuille.UseVisualStyleBackColor = true;
            // 
            // btnPierre
            // 
            btnPierre.Location = new Point(211, 189);
            btnPierre.Margin = new Padding(2);
            btnPierre.Name = "btnPierre";
            btnPierre.Size = new Size(78, 20);
            btnPierre.TabIndex = 0;
            btnPierre.Text = "Pierre";
            btnPierre.UseVisualStyleBackColor = true;
            // 
            // btnRetourRegles
            // 
            btnRetourRegles.Location = new Point(359, 230);
            btnRetourRegles.Name = "btnRetourRegles";
            btnRetourRegles.Size = new Size(75, 23);
            btnRetourRegles.TabIndex = 1;
            btnRetourRegles.Text = "Retour";
            btnRetourRegles.UseVisualStyleBackColor = true;
            btnRetourRegles.Click += buttonRetourRegles_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(820, 335);
            Controls.Add(panelJeu);
            Controls.Add(btnQuitter);
            Controls.Add(btnRegles);
            Controls.Add(textBox1);
            Controls.Add(btnJouer);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Pierre Feuille Ciseaux";
            Load += Form1_Load;
            panelJeu.ResumeLayout(false);
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
    }
}

