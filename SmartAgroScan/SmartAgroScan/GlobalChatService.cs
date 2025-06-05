using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartAgroScan
{
    internal class GlobalChatService
    {

        private string connectionString = @"Data Source=MARUP;Initial Catalog=PlantTest;Integrated Security=True;Trust Server Certificate=True";

        // Insert a new chat message
        public void InsertMessage(string username, string message)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO GlobalChat (Username, Message) VALUES (@Username, @Message)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Message", message);
                cmd.ExecuteNonQuery();
            }
        }

        // Load chat into a RichTextBox
        public void LoadMessages(RichTextBox chatBox)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Username, Message FROM GlobalChat ORDER BY SentAt"; // Make sure SentAt exists
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                chatBox.Clear();
                while (reader.Read())
                {
                    string user = reader["Username"].ToString();
                    string msg = reader["Message"].ToString();
                    chatBox.AppendText($"{user}: {msg}\n");
                }
            }
        }
    }
}
