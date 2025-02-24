using Microsoft.Data.SqlClient;

namespace _06_DB_01_SQL_connection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PR2B;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //string insQuery = "INSERT INTO Cars(Id, RegPlate, Brand, Model, Purchased) VALUES (@Id, @RegPlate, @Brand, @Model, @Purchased)";

                //SqlCommand insCommand = new SqlCommand(insQuery, connection);
                //insCommand.Parameters.AddWithValue("@Id", 3);
                //insCommand.Parameters.AddWithValue("@RegPlate", "3E33257");
                //insCommand.Parameters.AddWithValue("@Brand", "Ford");
                //insCommand.Parameters.AddWithValue("@Model", "Fiesta");
                //insCommand.Parameters.AddWithValue("@Purchased", DateTime.Now);

                //insCommand.ExecuteNonQuery();



                string query = "SELECT * FROM Cars";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            //string RegPlate = reader.GetString(1);
                            string regPlate = (string)reader["RegPlate"];
                            string brand = (string)reader["Brand"];
                            string model = (string)reader["Model"];
                            DateTime purchased = reader.GetDateTime(4);

                            Console.WriteLine($"ID: {id}, reg. plate: {regPlate}, brand: {brand}, model: {model}, purchased {purchased}");

                        }
                    }
                }
            }
        }
    }
}
