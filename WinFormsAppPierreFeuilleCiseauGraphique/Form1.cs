using System.Security.Cryptography;

namespace WinFormsAppPierreFeuilleCiseauGraphique
{
    public partial class Form1 : Form
    {
        int choixJoueur;
        int choixOrdi;
        string choixOrdiTxt;

        public void lancementJeu()
        {
            Random random = new Random();
            choixOrdi = random.Next(1, 4);
            if (choixOrdi == 1)
            {
                choixOrdiTxt = "Pierre";
            }
            else if (choixOrdi == 2)
            {
                choixOrdiTxt = "Feuille";
            }
            else if (choixOrdi == 3)
            {
                choixOrdiTxt = "Ciseaux";
            }
            textBox3.Text = "Réfléxion...";
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Au démarrage, seul le menu principal est visible
            panelJeu.Visible = false;
            pnlRegles.Visible = false;

        }

        // =========================
        // MENU PRINCIPAL
        // =========================

        private void btnJouer_Click(object sender, EventArgs e)
        {
            // Afficher le jeu
            panelJeu.Visible = true;
            pnlRegles.Visible = false;
            panelJeu.BringToFront();
            lancementJeu();
        }

        private void btnRegles_Click(object sender, EventArgs e)
        {
            // Afficher les règles
            panelJeu.Visible = false;
            pnlRegles.Visible = true;
            pnlRegles.BringToFront();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // =========================
        // JEU
        // =========================

        private void btnPierre_Click(object sender, EventArgs e)
        {
            choixJoueur = 1;
            textBox3.Text = choixOrdiTxt;
            if (choixOrdi == 1)
            {
                MessageBox.Show("Égalités !");
            }
            else if (choixOrdi == 2)
            {
                MessageBox.Show("Perdu !");
            }
            else if (choixOrdi == 3)
            {
                MessageBox.Show("Gagné !");
            }
            btnPierre.Enabled = false;
            btnFeuille.Enabled = false;
            btnCiseaux.Enabled = false;
        }

        private void btnFeuille_Click(object sender, EventArgs e)
        {
            choixJoueur = 2;
            textBox3.Text = choixOrdiTxt;
            if (choixOrdi == 2)
            {
                MessageBox.Show("Égalités !");
            }
            else if (choixOrdi == 3)
            {
                MessageBox.Show("Perdu !");
            }
            else if (choixOrdi == 1)
            {
                MessageBox.Show("Gagné !");
            }
            btnPierre.Enabled = false;
            btnFeuille.Enabled = false;
            btnCiseaux.Enabled = false;
        }

        private void buttonCiseaux_Click(object sender, EventArgs e)
        {
            choixJoueur = 3;
            textBox3.Text = choixOrdiTxt;
            if (choixOrdi == 3)
            {
                MessageBox.Show("Égalités !");
            }
            else if (choixOrdi == 1)
            {
                MessageBox.Show("Perdu !");
            }
            else if (choixOrdi == 2)
            {
                MessageBox.Show("Gagné !");
            }
            btnPierre.Enabled = false;
            btnFeuille.Enabled = false;
            btnCiseaux.Enabled = false;
        }

        private void rejouer_Click(object sender, EventArgs e)
        {
            lancementJeu();
            btnPierre.Enabled = true;
            btnFeuille.Enabled = true;
            btnCiseaux.Enabled = true;
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            // Retour au menu principal
            panelJeu.Visible = false;
            btnPierre.Enabled = true;
            btnFeuille.Enabled = true;
            btnCiseaux.Enabled = true;
        }


        // =========================
        // REGLES
        // =========================

        private void buttonRetourRegles_Click(object sender, EventArgs e)
        {
            // Retour au menu principal
            pnlRegles.Visible = false;
        }


        // =========================
        // EVENEMENTS DU DESIGNER
        // =========================

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void panelJeu_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        

    }
}

