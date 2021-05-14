﻿using FedoraDev.TimCo.DataManager.Library.Internal.DataAccess;
using FedoraDev.TimCo.DataManager.Library.Models;
using System.Collections.Generic;
using System.Linq;

namespace FedoraDev.TimCo.DataManager.Library.DataAccess
{
	public class ProductData
	{
		public List<ProductModel> GetProducts()
		{
			SqlDataAccess sql = new SqlDataAccess();

			var parameters = new { };

			return sql.LoadData<ProductModel, dynamic>("dbo.spProductGetAll", parameters, "TimCo-Data");
		}

		public ProductModel GetProductById(int productId)
		{
			SqlDataAccess sql = new SqlDataAccess();

			var parameters = new { Id = productId };

			return sql.LoadData<ProductModel, dynamic>("dbo.spProductGetById", parameters, "TimCo-Data").FirstOrDefault();
		}
	}
}
