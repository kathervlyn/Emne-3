using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media
{
    class User
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<User> Friends { get; } = new List<User>();
    }
}
