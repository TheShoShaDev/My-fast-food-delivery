using Npgsql;
using System;
using System.Data.SqlClient;

namespace Grill1.Helpers
{
	public class Helpers
	{
		public class DbHelper
		{
			public static NpgsqlConnection GetConnection()
			{
				return new NpgsqlConnection("Host = 127.0.0.1; Port = 5432; Database = Grill1; Username = postgres; Password = 1488");
			}
		}
	}
}
