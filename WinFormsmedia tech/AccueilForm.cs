using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsmedia_tech
{
    public partial class AccueilForm : Form
    {
        private MediaTechRepository repo;
        public AccueilForm()
        {
            InitializeComponent();
            repo = new MediaTechRepository();
        }

        private void AccueilForm_Load(object sender, EventArgs e)
        {
            ChargerTousLesContenus();
        }

        private void ChargerTousLesContenus()
        {
            //dataGridViewCatalogue.DataSource = repo.GetAllContenus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel headerPanel = new Panel();
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Height = 60;
            headerPanel.BackColor = Color.LightGray;

        }

        private void ImageAccueil1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_dvd(object sender, EventArgs e)
        {
            //ConnectToDatabase();
        }

        private void btn_cd(object sender, EventArgs e)
        {

        }

        private void btn_livres(object sender, EventArgs e)
        {

        }

        private void btn_tous(object sender, EventArgs e)
        {

        }

        private void btn_creer_compte(object sender, EventArgs e)
        {

        }

        private void btn_decouverte(object sender, EventArgs e)
        {

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewCatalogue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
