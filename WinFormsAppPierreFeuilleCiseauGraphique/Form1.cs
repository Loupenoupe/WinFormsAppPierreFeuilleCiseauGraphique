
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
            pnlRegles.Visible = false;

        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lancement de la partie !");//debug
            panelJeu.Visible = true;
            pnlRegles.Visible = false;

        }

        private void btnRegles_Click(object sender, EventArgs e)
        {
            panelJeu.Visible = true;
            pnlRegles.Visible = true;

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fermeture du jeu !");
            Application.Exit();
        }

        private void buttonCiseaux_Click(object sender, EventArgs e)
        {

        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            panelJeu.Visible = false;
        }

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRetourRegles_Click(object sender, EventArgs e)
        {
            panelJeu.Visible = false;
        }
    }
}
