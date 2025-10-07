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
        private readonly string connectionString = "Data Source=localhost;Initial Catalog=MediaTech;Integrated Security=True;";

        public DataTable GetAllContenus()
        {
            string query = "SELECT * FROM Contenu";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable SearchContenu(string recherche)
        {
            string query = "SELECT * FROM Contenu WHERE titre LIKE @recherche";
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

    }
}
