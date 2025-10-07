using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsmedia_tech
{
    public partial class AccueilForm : Form
    {
        private MediaTechRepository repo;
        private string filtreActif = "Tous"; // Pour garder trace du filtre actif

        public AccueilForm()
        {
            InitializeComponent();
            repo = new MediaTechRepository();
        }

        private void AccueilForm_Load(object sender, EventArgs e)
        {
            // Vérifier la connexion à la base de données
            if (!repo.TestConnection())
            {
                MessageBox.Show("Erreur de connexion à la base de données. Vérifiez votre configuration.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Charger tous les contenus au démarrage
            ChargerTousLesContenus();

            // Configurer le DataGridView
            ConfigurerDataGridView();

            // Charger les options des ComboBox
            ChargerComboBoxGenres();
            ChargerComboBoxTri();

            // Définir le bouton "Tous" comme actif par défaut
            DefinirBoutonActif(btn_filter1);
        }

        private void ConfigurerDataGridView()
        {
            // Configurer l'apparence du DataGridView
            dataGridViewCatalogue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCatalogue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCatalogue.MultiSelect = false;
            dataGridViewCatalogue.ReadOnly = true;
            dataGridViewCatalogue.AllowUserToAddRows = false;
            dataGridViewCatalogue.RowHeadersVisible = false;

            // Adapter la taille du DataGridView si nécessaire
            dataGridViewCatalogue.Size = new Size(1400, 600);
        }

        private void ChargerComboBoxGenres()
        {
            try
            {
                box_genre.Items.Clear();
                box_genre.Items.Add("Tous les genres");

                DataTable categories = repo.GetCategories();
                foreach (DataRow row in categories.Rows)
                {
                    box_genre.Items.Add(row["nom_categorie"].ToString());
                }

                box_genre.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des genres : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerComboBoxTri()
        {
            box_trier.Items.Clear();
            box_trier.Items.Add("Titre (A-Z)");
            box_trier.Items.Add("Titre (Z-A)");
            box_trier.Items.Add("Auteur (A-Z)");
            box_trier.Items.Add("Date de publication");
            box_trier.Items.Add("Disponibilité");

            box_trier.SelectedIndex = 0;
            box_trier.SelectedIndexChanged += box_trier_SelectedIndexChanged;
        }

        private void ChargerTousLesContenus()
        {
            try
            {
                DataTable contenus = repo.GetAllContenus();
                dataGridViewCatalogue.DataSource = contenus;

                // Personnaliser les en-têtes de colonnes
                if (dataGridViewCatalogue.Columns.Count > 0)
                {
                    dataGridViewCatalogue.Columns["id"].HeaderText = "ID";
                    dataGridViewCatalogue.Columns["titre"].HeaderText = "Titre";
                    dataGridViewCatalogue.Columns["auteur"].HeaderText = "Auteur";
                    dataGridViewCatalogue.Columns["editeur"].HeaderText = "Éditeur";
                    dataGridViewCatalogue.Columns["date_publication"].HeaderText = "Date de publication";
                    dataGridViewCatalogue.Columns["quantite"].HeaderText = "Quantité disponible";
                    dataGridViewCatalogue.Columns["categorie"].HeaderText = "Catégorie";
                }

                filtreActif = "Tous";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des contenus : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DefinirBoutonActif(Button boutonActif)
        {
            // Réinitialiser tous les boutons de filtre
            btn_filter1.BackColor = SystemColors.Control;
            btn_filter1.ForeColor = SystemColors.ControlText;
            btn_filter2.BackColor = SystemColors.Control;
            btn_filter2.ForeColor = SystemColors.ControlText;
            btn_filter3.BackColor = SystemColors.Control;
            btn_filter3.ForeColor = SystemColors.ControlText;
            btn_filter4.BackColor = SystemColors.Control;
            btn_filter4.ForeColor = SystemColors.ControlText;

            // Mettre en évidence le bouton actif
            boutonActif.BackColor = Color.Black;
            boutonActif.ForeColor = Color.White;
        }

        // Bouton "Tous"
        private void btn_tous(object sender, EventArgs e)
        {
            ChargerTousLesContenus();
            DefinirBoutonActif(btn_filter1);
        }

        // Bouton "Livres"
        private void btn_livres(object sender, EventArgs e)
        {
            try
            {
                DataTable livres = repo.GetLivres();
                dataGridViewCatalogue.DataSource = livres;
                filtreActif = "Livres";
                DefinirBoutonActif(btn_filter2);

                MessageBox.Show($"{livres.Rows.Count} livre(s) trouvé(s)",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des livres : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Bouton "CD Audio"
        private void btn_cd(object sender, EventArgs e)
        {
            try
            {
                DataTable cds = repo.GetCDAudio();
                dataGridViewCatalogue.DataSource = cds;
                filtreActif = "CD Audio";
                DefinirBoutonActif(btn_filter3);

                MessageBox.Show($"{cds.Rows.Count} CD Audio trouvé(s)",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des CD Audio : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Bouton "DVD/Blu-Ray"
        private void btn_dvd(object sender, EventArgs e)
        {
            try
            {
                DataTable dvds = repo.GetDVD();
                dataGridViewCatalogue.DataSource = dvds;
                filtreActif = "DVD";
                DefinirBoutonActif(btn_filter4);

                MessageBox.Show($"{dvds.Rows.Count} DVD/Blu-Ray trouvé(s)",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des DVD : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Bouton "Découvrir la Bibliothèque"
        private void btn_decouverte(object sender, EventArgs e)
        {
            // Faire défiler vers le catalogue
            dataGridViewCatalogue.Focus();
            ChargerTousLesContenus();
        }

        // Bouton "Créer un compte"
        private void btn_creer_compte(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité de création de compte à venir !",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // TODO: Ouvrir un formulaire d'inscription
            // InscriptionForm inscriptionForm = new InscriptionForm();
            // inscriptionForm.ShowDialog();
        }

        // Recherche en temps réel
        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            string recherche = txtRecherche.Text.Trim();

            if (string.IsNullOrWhiteSpace(recherche))
            {
                // Si la recherche est vide, recharger selon le filtre actif
                switch (filtreActif)
                {
                    case "Livres":
                        btn_livres(sender, e);
                        break;
                    case "CD Audio":
                        btn_cd(sender, e);
                        break;
                    case "DVD":
                        btn_dvd(sender, e);
                        break;
                    default:
                        ChargerTousLesContenus();
                        break;
                }
            }
            else
            {
                // Effectuer la recherche
                RechercherContenu(recherche);
            }
        }

        private void RechercherContenu(string recherche)
        {
            try
            {
                DataTable resultats = repo.SearchContenu(recherche);
                dataGridViewCatalogue.DataSource = resultats;

                // Afficher le nombre de résultats dans la barre de titre ou un label
                this.Text = $"Média-Tech - {resultats.Rows.Count} résultat(s) trouvé(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la recherche : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tri des résultats
        private void box_trier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridViewCatalogue.DataSource == null)
                return;

            DataTable dt = (DataTable)dataGridViewCatalogue.DataSource;

            switch (box_trier.SelectedIndex)
            {
                case 0: // Titre (A-Z)
                    dt.DefaultView.Sort = "titre ASC";
                    break;
                case 1: // Titre (Z-A)
                    dt.DefaultView.Sort = "titre DESC";
                    break;
                case 2: // Auteur (A-Z)
                    dt.DefaultView.Sort = "auteur ASC";
                    break;
                case 3: // Date de publication
                    dt.DefaultView.Sort = "date_publication DESC";
                    break;
                case 4: // Disponibilité
                    dt.DefaultView.Sort = "quantite DESC";
                    break;
            }

            dataGridViewCatalogue.DataSource = dt;
        }

        // Filtre par genre via ComboBox
        private void box_genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (box_genre.SelectedIndex == 0) // "Tous les genres"
            {
                ChargerTousLesContenus();
            }
            else
            {
                try
                {
                    string genre = box_genre.SelectedItem.ToString();
                    DataTable resultats = repo.GetContenusByCategorie(genre);
                    dataGridViewCatalogue.DataSource = resultats;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors du filtrage par genre : {ex.Message}",
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Méthode générée par le designer - peut rester vide ou être supprimée
        }

        private void ImageAccueil1_Click(object sender, EventArgs e)
        {
            // Optionnel : Action au clic sur l'image
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Méthode générée par le designer - peut rester vide
        }

        private void dataGridViewCatalogue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optionnel : Afficher les détails du contenu sélectionné
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCatalogue.Rows[e.RowIndex];
                string titre = row.Cells["titre"].Value?.ToString();
                string auteur = row.Cells["auteur"].Value?.ToString();
                string categorie = row.Cells["categorie"].Value?.ToString();

                MessageBox.Show($"Titre : {titre}\nAuteur : {auteur}\nCatégorie : {categorie}",
                    "Détails du contenu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}