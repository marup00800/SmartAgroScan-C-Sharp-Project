using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SmartAgroScan
{

    internal class GlobalChatService
    {

        private string connectionString = @"Data Source=Marup;Initial Catalog=PlantTest;Integrated Security=True;Trust Server Certificate=True";
        private int userId; // This is the user ID of the logged-in user

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
            SqlConnection connection = new SqlConnection(connectionString);
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
            reader.Close();

            string query2 = "SELECT  ua.UserID, ISNULL(CAST(ua.TestID AS VARCHAR), '000') AS TestID, ua.ActivityType, u.Username FROM UserActivity ua  JOIN Users u ON ua.UserID = u.UserID";


            SqlCommand cmd2 = new SqlCommand(query2, connection);
                SqlDataReader reader2 = cmd2.ExecuteReader();
           
                while (reader2.Read())
                {
                    string userId = reader2["UserID"].ToString();
                string username = reader2["Username"].ToString();
                string testId = reader2["TestID"].ToString();
                    string activityType = reader2["ActivityType"].ToString();
                    chatBox.AppendText("[" + userId + "] " + username + "" + "< Test ID : " + testId + ">" + ": " + activityType + "**" + "\n");
                }
            reader2.Close();    


        }
    }
}

