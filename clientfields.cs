using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saiyagym
{
    class clientfields
    {
        public int id_client { get; set; }
        public bool status { get; set; }
        public string advice { get; set; }
        
        public clientfields() { } //constructor
        public clientfields(int id_client, bool status, string advice)
        {
            this.id_client = id_client;
            this.status = status;
            this.advice = advice;
        }
    }
}
