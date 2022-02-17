using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserTest.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string CategoryName { get; set; } = "Screen9 Video";
        public bool Read { get; set; } = false;
        public bool Create { get; set; } = false;
        public bool Change { get; set; } = false;
        public bool Delete { get; set; } = false;
        public bool Publish { get; set; } = false;
        public bool Administer { get; set; } = false;
        [Display(Name ="Inherit from parents")]
        public bool InheritParent { get; set; } = false;
        [Display(Name = "Settings for all subitems")]
        public bool SettingsAllSubitems { get; set; } = false;
        public User(int i, string n, string cn, bool r, bool c, bool ch, bool d, bool p, bool a, bool ip, bool sas)
        {
            Id = i;
            UserName = n;
            CategoryName = cn;
            Read = r;
            Create = c;
            Change = ch;
            Delete = d;
            Publish = p;
            Administer = a;
            InheritParent = ip;
            SettingsAllSubitems = sas;
    }
}
}
