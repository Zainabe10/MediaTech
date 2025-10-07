using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace WinFormsmedia_tech
{
    internal class MediaTechRepository
    {
        private readonly string connectionString = "Data Source=localhost;Initial Catalog=MediaTech;Integrated Security=True;TrustServerCertificate=True;";

        // Récupérer tous les contenus avec leurs catégories
        public DataTable GetAllContenus()
        {
            string query = @"
                SELECT 
                    c.id,
                    c.titre,
                    c.auteur,
                    c.editeur,
                    c.date_publication,
                    c.quantite,
                    cat.nom_categorie AS categorie
                FROM Contenu c
                LEFT JOIN Categorie cat ON c.id_categorie = cat.id
                ORDER BY c.titre";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Filtrer les contenus par catégorie
        public DataTable GetContenusByCategorie(string nomCategorie)
        {
            string query = @"
                SELECT 
                    c.id,
                    c.titre,
                    c.auteur,
                    c.editeur,
                    c.date_publication,
                    c.quantite,
                    cat.nom_categorie AS categorie
                FROM Contenu c
                INNER JOIN Categorie cat ON c.id_categorie = cat.id
                WHERE cat.nom_categorie = @categorie
                ORDER BY c.titre";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@categorie", nomCategorie);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Rechercher des contenus par titre, auteur ou éditeur
        public DataTable SearchContenu(string recherche)
        {
            string query = @"
                SELECT 
                    c.id,
                    c.titre,
                    c.auteur,
                    c.editeur,
                    c.date_publication,
                    c.quantite,
                    cat.nom_categorie AS categorie
                FROM Contenu c
                LEFT JOIN Categorie cat ON c.id_categorie = cat.id
                WHERE c.titre LIKE @recherche 
                   OR c.auteur LIKE @recherche 
                   OR c.editeur LIKE @recherche
                ORDER BY c.titre";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@recherche", "%" + recherche + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Récupérer les livres uniquement
        public DataTable GetLivres()
        {
            string query = @"
                SELECT 
                    c.id,
                    c.titre,
                    c.auteur,
                    c.editeur,
                    c.date_publication,
                    c.quantite,
                    l.nombre_page,
                    cat.nom_categorie AS categorie
                FROM Contenu c
                INNER JOIN Livres l ON c.id = l.id_contenu
                INNER JOIN Categorie cat ON c.id_categorie = cat.id
                ORDER BY c.titre";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Récupérer les CD Audio uniquement
        public DataTable GetCDAudio()
        {
            string query = @"
                SELECT 
                    c.id,
                    c.titre,
                    c.auteur,
                    c.editeur,
                    c.date_publication,
                    c.quantite,
                    cd.nombre_morceau,
                    cd.duree,
                    cat.nom_categorie AS categorie
                FROM Contenu c
                INNER JOIN CD_Audio cd ON c.id = cd.id_contenu
                INNER JOIN Categorie cat ON c.id_categorie = cat.id
                ORDER BY c.titre";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Récupérer les DVD uniquement
        public DataTable GetDVD()
        {
            string query = @"
                SELECT 
                    c.id,
                    c.titre,
                    c.auteur,
                    c.editeur,
                    c.date_publication,
                    c.quantite,
                    d.duree,
                    cat.nom_categorie AS categorie
                FROM Contenu c
                INNER JOIN DVD d ON c.id = d.id_contenu
                INNER JOIN Categorie cat ON c.id_categorie = cat.id
                ORDER BY c.titre";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Récupérer toutes les catégories
        public DataTable GetCategories()
        {
            string query = "SELECT id, nom_categorie, description FROM Categorie ORDER BY nom_categorie";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Tester la connexion à la base de données
        public bool TestConnection()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
