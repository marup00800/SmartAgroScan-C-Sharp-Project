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
        private int userId;

        public GlobalChatService()
        {
        }

        public GlobalChatService(int userId)
        {
            this.userId = userId;
        }

        public void InsertMessage(int userId, string username, string message)
        {
                
            SqlConnection connection = new SqlConnection(connectionString);
            
                connection.Open();
                string query = "INSERT INTO GlobalChat (UserID, Username, Message) VALUES (@UserID, @Username, @Message)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserID", userId); 
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Message", message);
                cmd.ExecuteNonQuery();
          
        }

        // Load chat into a RichTextBox
        public void LoadMessages(RichTextBox chatBox)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT UserID, Username, Message
                         FROM GlobalChat
                         ORDER BY ChatID";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader(); 
                chatBox.Clear();
                while (reader.Read())
                {   
                    int userId = Convert.ToInt32(reader["UserID"]);
                    string user = reader["Username"].ToString();
                    string msg = reader["Message"].ToString();

                    chatBox.AppendText("[" + userId + "] " + user + ": " + msg + "\n");

                }
            }
        }   
    }
}
