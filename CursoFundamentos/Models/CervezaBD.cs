using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoFundamentos.Models
{
    class CervezaBD
    {
        private string connectionString
            = "Data Source=DESKTOP-SK3IRM7;Initial Catalog=CursoFundamentos;"+ "User=usuarioCursoFundamentos;Password=abc123";
    

    public List<Cerveza> Get()
    {
        List<Cerveza> cervezas = new List<Cerveza>();

        string query = "select nombre, marca, alcohol, cantidad from cerveza";

        using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string serverVersion = connection.ServerVersion;

                SqlCommand command = new SqlCommand(query, connection);
                
              
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int Cantidad = reader.GetInt32(3);
                    string Nombre = reader.GetString(0);

                    Cerveza cerveza = new Cerveza(Cantidad, Nombre);
                    cerveza.Alcohol = reader.GetInt32(2);
                    cerveza.Marca = reader.GetString(1);

                    cervezas.Add(cerveza);
                }
                reader.Close();
                connection.Close();
            }

        return cervezas;
    }

     public void Add(Cerveza cerveza)
        {
            string query =
                "insert into cerveza (nombre, marca, alcohol, cantidad) " + "values (@nombre, @marca, @alcohol, @cantidad)";

            using (var connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", cerveza.Nombre);
                command.Parameters.AddWithValue("@marca", cerveza.Marca);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@cantidad", cerveza.Cantidad);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string serverVersion = connection.ServerVersion;

                command.ExecuteNonQuery();

                connection.Close();
            }

        }

    }

   


}
