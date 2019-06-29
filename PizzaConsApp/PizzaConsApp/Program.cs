using System;
using System.Collections.Generic;
using System.Data.SqlClient;



namespace PizzaConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PizzaPrice> pizzaPrices = GetPizzaPricesFromDatabase();
            foreach (var item in pizzaPrices)
            {
                Console.WriteLine($"#{item.PizzaId}- Size: {item.Size} Price: {item.Price}");
            }

            Console.ReadLine();
        }

       
        public static List<PizzaPrice> GetPizzaPricesFromDatabase()
        {
            var connStr = @"Data Source=PALMYRA17;Initial Catalog=PizzaDatabase;User ID=sa;Password=Password1;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection sqlConnection = new SqlConnection(connStr);
            sqlConnection.Open();
            var query = $"select * from PizzaPrices";
            SqlCommand sqlCommand = new SqlCommand(query);
            sqlCommand.Connection = sqlConnection;

            var pizzas = new List<PizzaPrice>();
            var sqlReader = sqlCommand.ExecuteReader();
            while (sqlReader.Read())
            {
                int id = (int)sqlReader["PizzaId"];
                int size = (int)sqlReader["Size"];
                double price = (double)sqlReader["Price"];
                pizzas.Add(new PizzaPrice
                {
                    PizzaId = id,
                    Size = size,
                    Price=price
                
                });
            }



            sqlConnection.Close();
            return pizzas;
        }
    }
}
