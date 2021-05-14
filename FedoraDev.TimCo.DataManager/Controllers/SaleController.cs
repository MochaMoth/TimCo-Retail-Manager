﻿using FedoraDev.TimCo.DataManager.Library.DataAccess;
using FedoraDev.TimCo.DataManager.Library.Models;
using FedoraDev.TimCo.DataManager.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Web.Http;

namespace FedoraDev.TimCo.DataManager.Controllers
{
    [Authorize]
	public class SaleController : ApiController
    {
        [HttpPost]
        public void Post(SaleModel sale)
        {
            SaleData saleData = new SaleData();
            string userId = RequestContext.Principal.Identity.GetUserId();

            saleData.SaveSale(sale, userId);
		}
    }
}