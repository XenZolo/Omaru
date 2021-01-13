using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Omaru.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Products()
		{
			return View();
		}

		public IActionResult AddProducts()
		{
			return View();
		}
		public IActionResult Inventory()
		{
			return View();
		}
		public IActionResult AddInventory()
		{
			return View();
		}
	}
}
