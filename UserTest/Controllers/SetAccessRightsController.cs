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
        public IActionResult Index(string cat)
        {
            List<User> usersList = new();
            VideoCategory Cat = new();

            Cat.CategoryName = cat;
            Cat.InheritParent = true;
            Cat.SettingsAllSubitems = true;

            User user1 = new (1, "Administrators", Cat, true, true, true, true, true, true);
            User user2 = new (2, "Everyone", Cat, true, false, false, false, false, false);
            User user3 = new (3, "WebAdmins", Cat, true, false, false, false, false, false);
            //User user4 = new (4, "Others", cat, true, false, false, false, false, false);
            //User user5 = new (5, "Me", cat, true, true, true, true, true, true);

            usersList.Add(user1);
            usersList.Add(user2);
            usersList.Add(user3);
            //usersList.Add(user4);
            //usersList.Add(user5);

            return View(usersList);
        }
    }
}
