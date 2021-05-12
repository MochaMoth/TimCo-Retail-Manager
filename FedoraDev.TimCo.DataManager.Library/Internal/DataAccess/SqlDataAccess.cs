﻿using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace FedoraDev.TimCo.DataManager.Library.Internal.DataAccess
{
	internal class SqlDataAccess
	{
		public string GetConnectionString(string name)
		{
			return ConfigurationManager.ConnectionStrings[name].ConnectionString;
		}

		public List<T> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName)
		{
			string connectionString = GetConnectionString(connectionStringName);

			using (IDbConnection connection = new SqlConnection(connectionString))
				return connection.Query<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure).ToList();
		}

		public void SaveData<T>(string storedProcedure, T parameters, string connectionStringName)
		{
			string connectionString = GetConnectionString(connectionStringName);

			using (IDbConnection connection = new SqlConnection(connectionString))
				_ = connection.Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
		}
	}
}
