using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Omaru.Controllers
{
	public class ChefController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
