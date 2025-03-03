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

                ListCars(connection);
                Console.WriteLine();
                //InsertCar(connection,"ASDFGH", "Trabant", "Kombi", DateTime.Now);
                //ListCars(connection);
                //Console.WriteLine();
                //UpdateCar(connection, 5, "ASDFGH", "Wartburg", "Kombi", DateTime.Now);
                //ListCars(connection);
                //Console.WriteLine();
                //DeleteCar(connection, 5);
                //ListCars(connection);
                //Console.WriteLine();
            }
        }

        private static void InsertCar(SqlConnection connection, 
            //int id,
            string regPlate,
            string brand,
            string model,
            DateTime purchased
            )
        {
            string insQuery = "INSERT INTO Cars(RegPlate, Brand, Model, Purchased) VALUES (@RegPlate, @Brand, @Model, @Purchased)";

            SqlCommand insCommand = new SqlCommand(insQuery, connection);
            //insCommand.Parameters.AddWithValue("@Id", id);
            insCommand.Parameters.AddWithValue("@RegPlate", regPlate);
            insCommand.Parameters.AddWithValue("@Brand", brand);
            insCommand.Parameters.AddWithValue("@Model", model);
            insCommand.Parameters.AddWithValue("@Purchased", purchased);

            insCommand.ExecuteNonQuery();
        }

        private static void UpdateCar(SqlConnection connection,
            int id,
            string regPlate,
            string brand,
            string model,
            DateTime purchased
            )
        {
            string updateQuery = "UPDATE Cars SET RegPlate=@RegPlate, Brand=@Brand, Model=@Model, Purchased=@Purchased WHERE Id=@Id";

            SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@Id", id);
            updateCommand.Parameters.AddWithValue("@RegPlate", regPlate);
            updateCommand.Parameters.AddWithValue("@Brand", brand);
            updateCommand.Parameters.AddWithValue("@Model", model);
            updateCommand.Parameters.AddWithValue("@Purchased", purchased);

            updateCommand.ExecuteNonQuery();
        }

        private static void DeleteCar(SqlConnection connection, int id)
        {
            string updateQuery = "DELETE FROM Cars WHERE Id=@Id";

            SqlCommand delCommand = new SqlCommand(updateQuery, connection);
            delCommand.Parameters.AddWithValue("@Id", id);
            delCommand.ExecuteNonQuery();
        }

        private static void ListCars(SqlConnection connection)
        {
            string query = 
                    "SELECT * FROM Cars"
                +   " LEFT JOIN Drivers ON (Cars.Id = Drivers.CarId)";

            using SqlCommand command = new SqlCommand(query, connection);
            using SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                //string RegPlate = reader.GetString(1);
                string regPlate = (string)reader["RegPlate"];
                string brand = (string)reader["Brand"];
                string model = (string)reader["Model"];
                string name = (reader["Name"] is null) ?  "" : (string)reader["Name"];
                string surname = (reader["Surname"] is null) ? "" : (string)reader["Surname"]; 
                DateTime purchased = reader.GetDateTime(4);

                Console.WriteLine($"ID: {id}, reg. plate: {regPlate}, brand: {brand}, model: {model}, purchased {purchased}, driver: {surname}, {name}");

            }
                        
        }
    }
}
