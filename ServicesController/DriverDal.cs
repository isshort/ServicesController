using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace ServicesController
{
    public class DriverDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;Initial Catalog=ServiceController;Integrated Security=True");
        private void CheckConnection(){
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public void UpdateDriver(Driver driver)
        {
            CheckConnection();
            SqlCommand command = new SqlCommand("Update drivers set herperion=@herperion,name=@name,last_name=@last_name where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", driver.Id);
            command.Parameters.AddWithValue("@herperion", driver.Herperion);
            command.Parameters.AddWithValue("@name", driver.Name);
            command.Parameters.AddWithValue("@last_name", driver.LastName);
            command.ExecuteNonQuery();
            _connection.Close();
           
        }
        public void AddDriver(Driver driver)
        {
            CheckConnection();
            Random rnd = new Random();
            SqlCommand command = new SqlCommand(
                "Insert into drivers   values (@Id,@herperion,@name,@last_name)", _connection);
            command.Parameters.AddWithValue("@Id", rnd.Next(0, 1000));
            command.Parameters.AddWithValue("@herperion", driver.Herperion);
            command.Parameters.AddWithValue("@name", driver.Name);
            command.Parameters.AddWithValue("@last_name", driver.LastName);

            command.ExecuteNonQuery();
            _connection.Close();
        }
        public List<Driver> GetAllDrivers()
        {
            CheckConnection();
             SqlCommand command = new SqlCommand("Select * from Drivers", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Driver> drivers = new List<Driver>();
            while (reader.Read())
            {
                Driver driver = new Driver
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Herperion = reader["Herperion"].ToString(),
                    Name=reader["name"].ToString(),
                    LastName=reader["last_name"].ToString()

                };
                drivers.Add(driver);
            }

            reader.Close();
            _connection.Close();
            
            return drivers;

        }
        public DataTable GetAllDrivers2()
        {
           if(_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Drivers", _connection);
            SqlDataReader reader= command.ExecuteReader();
           
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            reader.Close();
            _connection.Close();

            return dataTable;
            
        }
    }
}
