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
        public VideoCategory Category{ get; set; }
        public bool Read { get; set; } = false;
        public bool Create { get; set; } = false;
        public bool Change { get; set; } = false;
        public bool Delete { get; set; } = false;
        public bool Publish { get; set; } = false;
        public bool Administer { get; set; } = false;
        
        public User(int i, string n, VideoCategory vc, bool r, bool c, bool ch, bool d, bool p, bool a )
        {
            Id = i;
            UserName = n;
            Category = vc;
            Read = r;
            Create = c;
            Change = ch;
            Delete = d;
            Publish = p;
            Administer = a;
    }
}
}
