using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saiyagym
{
    class adminfields
    {
        public string id_admin { get; set; }
        public string password_admin { get; set; }

        public adminfields() { } //constructor
        public adminfields(string id_admin, string password_admin)
        {
            this.id_admin = id_admin;
            this.password_admin = password_admin;
        }
    }
}

