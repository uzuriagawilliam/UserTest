using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserTest.Models
{
    public class Category
    {
        public string CategoryName { get; set; } = "Scree9 Video";
        public bool InheritParent { get; set; } = true;
        public bool SettingsAllSubitems { get; set; } = true;   
    }
}
