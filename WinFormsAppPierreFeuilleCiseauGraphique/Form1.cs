
namespace WinFormsAppPierreFeuilleCiseauGraphique
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelJeu.Visible = false;

        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lancement de la partie !");//debug
            panelJeu.Visible = true;
        }

        private void btnRegles_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voici les règles !");//debug
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fermeture du jeu !");
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
