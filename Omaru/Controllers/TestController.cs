using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Omaru.Models;
using omaru.Data;

namespace Omaru.Controllers
{
	public class TestController : Controller
	{
        private readonly MockUsersRepo _repository = new MockUsersRepo();

        [HttpGet]
        public IActionResult AccountLogin()
		{
			return View();
		}


        [HttpPost]
		public IActionResult AccountLogin(Users model) {

                var result = model;

           var data =  _repository.GetUsers();

			foreach (var item in data)
			{
                if(item.username==result.username && item.password==model.password)
				{
					if (item.role == "admin")
					{
                        return RedirectToAction("Index", "Admin");
                    }
                   else if (item.role == "reception")
                    {
                        return RedirectToAction("Index", "Receptionist");
                    }
                    else if (item.role == "chef")
                    {
                        return RedirectToAction("Index", "Chef");
                    }

                }

			}
            return View();
              
      
        }
    }
}
    

	

