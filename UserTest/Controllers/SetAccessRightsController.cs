using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserTest.Models;

namespace UserTest.Controllers
{
    public class SetAccessRightsController : Controller
    {
        public IActionResult Index()
        {
            List<User> usersList = new();

            User user1 = new (1, "Administrators", "Screen9 Video", true, true, true, true, true, true, true, true);
            User user2 = new (2, "Everyone", "Screen9 Video", true, false, false, false, false, false,true, true);
            User user3 = new (3, "WebAdmins", "Screen9 Video", true, false, false, false, false, false, true, true);
            User user4 = new (4, "Others", "Screen9 Video", true, false, false, false, false, false, true, true);
            User user5 = new (5, "Me", "Screen9 Video", true, true, true, true, true, true, true, true);

            usersList.Add(user1);
            usersList.Add(user2);
            usersList.Add(user3);
            //usersList.Add(user4);
            //usersList.Add(user5);

            return View(usersList);
        }

        [HttpPost]
        public void Index(List<User> users)
        {
            if (users is null)
            {
                throw new ArgumentNullException(nameof(users));
            }

            foreach(var user in users)
            {
                //Do something
            }
        }
    }
}
