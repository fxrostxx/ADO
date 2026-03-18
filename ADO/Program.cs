using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Movies_PV_521;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			Console.WriteLine($"{connection_string}\n");

			SqlConnection connection = new SqlConnection(connection_string);
			connection.Open();

			SelectTable(connection, "movie_id, title, release_date, first_name, last_name", "Movies, Directors", "director = director_id");
			Console.WriteLine($"Кол-во записей: {SelectScalar(connection, "COUNT(*)", "Movies")}");

			connection.Close();
		}
		static SqlCommand CreateSqlCommand(SqlConnection connection, string statement, string table, string searchCondition = "")
		{
			string cmd = $"SELECT {statement} FROM {table}";
			if (searchCondition.Length != 0) cmd += $" WHERE {searchCondition}";
			return new SqlCommand(cmd, connection);
		}
		static void SelectTable(SqlConnection connection, string statement, string table, string searchCondition = "")
		{
			SqlCommand command = CreateSqlCommand(connection, statement, table, searchCondition);
			SqlDataReader reader = command.ExecuteReader();
			for (int i = 0; i < reader.FieldCount; ++i)
				Console.Write($"{reader.GetName(i)}\t");
			Console.WriteLine();
			while (reader.Read())
			{
				for (int i = 0; i < reader.FieldCount; ++i)
					Console.Write($"{reader[i]}\t\t");
				Console.WriteLine();
			}
			reader.Close();
		}
		static string SelectScalar(SqlConnection connection, string statement, string table, string searchCondition = "")
		{
			SqlCommand command = CreateSqlCommand(connection, statement, table, searchCondition);
			return Convert.ToString(command.ExecuteScalar());
		}
	}
}
