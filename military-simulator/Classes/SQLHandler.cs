using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace military_simulator.Classes
{
    class SQLHandler
    {
        string connectionString = @"Data Source=network.gpselectrical.co.za\KYLESQLSERVER;Initial Catalog=military-simulator;;User ID=milsim.sharp;Password=123;";
        public void createUser(string firstName, string lastName, string rank, string dodIdentification, string affiliation, string username, string hash, string salt)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string insertUserQuery = "INSERT INTO dbo.Users (FirstName, LastName, Rank, DodIdentification, Affiliation, Username, Hash, Salt)";
            insertUserQuery += " VALUES (@FirstName, @LastName, @Rank, @DodIdentification, @Affiliation, @Username, @Hash, @Salt)";
            SqlCommand insertCommand = new SqlCommand(insertUserQuery, sqlConnection);
            insertCommand.Parameters.AddWithValue("@FirstName", firstName);
            insertCommand.Parameters.AddWithValue("@LastName", lastName);
            insertCommand.Parameters.AddWithValue("@Rank", rank);
            insertCommand.Parameters.AddWithValue("@DodIdentification", dodIdentification);
            insertCommand.Parameters.AddWithValue("@Affiliation", affiliation);
            insertCommand.Parameters.AddWithValue("@Username", username);
            insertCommand.Parameters.AddWithValue("@Hash", hash);
            insertCommand.Parameters.AddWithValue("@Salt", salt);
            
            sqlConnection.Open();
            insertCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
