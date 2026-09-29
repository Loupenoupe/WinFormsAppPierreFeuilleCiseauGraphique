
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
            btnPierre = new Button();
            btnFeuille = new Button();
            button3 = new Button();
            panelJeu.SuspendLayout();
            SuspendLayout();
            // 
            // btnJouer
            // 
            btnJouer.BackColor = SystemColors.InactiveBorder;
            btnJouer.Location = new Point(514, 156);
            btnJouer.Name = "btnJouer";
            btnJouer.Size = new Size(112, 34);
            btnJouer.TabIndex = 0;
            btnJouer.Text = "Jouer";
            btnJouer.UseVisualStyleBackColor = false;
            btnJouer.Click += btnJouer_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.Enabled = false;
            textBox1.Location = new Point(413, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(332, 31);
            textBox1.TabIndex = 1;
            textBox1.Text = "Bienvenue dans le Pierre Feuille Ciseaux !";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // btnRegles
            // 
            btnRegles.BackColor = SystemColors.InactiveBorder;
            btnRegles.Location = new Point(514, 249);
            btnRegles.Name = "btnRegles";
            btnRegles.Size = new Size(112, 34);
            btnRegles.TabIndex = 2;
            btnRegles.Text = "Règles";
            btnRegles.UseVisualStyleBackColor = false;
            btnRegles.Click += btnRegles_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.BackColor = SystemColors.InactiveBorder;
            btnQuitter.Location = new Point(514, 341);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(112, 34);
            btnQuitter.TabIndex = 3;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = false;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // panelJeu
            // 
            panelJeu.Controls.Add(button3);
            panelJeu.Controls.Add(btnFeuille);
            panelJeu.Controls.Add(btnPierre);
            panelJeu.Dock = DockStyle.Fill;
            panelJeu.Location = new Point(0, 0);
            panelJeu.Name = "panelJeu";
            panelJeu.Size = new Size(1172, 558);
            panelJeu.TabIndex = 4;
            // 
            // btnPierre
            // 
            btnPierre.Location = new Point(307, 249);
            btnPierre.Name = "btnPierre";
            btnPierre.Size = new Size(112, 34);
            btnPierre.TabIndex = 0;
            btnPierre.Text = "Pierre";
            btnPierre.UseVisualStyleBackColor = true;
            // 
            // btnFeuille
            // 
            btnFeuille.Location = new Point(540, 249);
            btnFeuille.Name = "btnFeuille";
            btnFeuille.Size = new Size(112, 34);
            btnFeuille.TabIndex = 1;
            btnFeuille.Text = "Feuille";
            btnFeuille.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(795, 249);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1172, 558);
            Controls.Add(panelJeu);
            Controls.Add(btnQuitter);
            Controls.Add(btnRegles);
            Controls.Add(textBox1);
            Controls.Add(btnJouer);
            Name = "Form1";
            Text = "Pierre Feuille Ciseaux";
            Load += Form1_Load;
            panelJeu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnJouer;
        private TextBox textBox1;
        private Button btnRegles;
        private Button btnQuitter;
        private Panel panelJeu;
        private Button button3;
        private Button btnFeuille;
        private Button btnPierre;
    }
}

