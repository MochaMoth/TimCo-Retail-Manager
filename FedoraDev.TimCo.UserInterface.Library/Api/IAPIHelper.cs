﻿using FedoraDev.TimCo.UserInterface.Library.Models;
using System.Threading.Tasks;

namespace FedoraDev.TimCo.UserInterface.Library.Helpers
{
	public interface IAPIHelper
	{
		Task<AuthenticatedUser> Authenticate(string username, string password);
		Task SetLoggedInUserInfo(string token);
	}
}