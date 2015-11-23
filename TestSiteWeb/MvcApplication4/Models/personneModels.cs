using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication4.Models
{
    public class personneModels
    {

        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Role> Roles { get; set; }

      
        public override string ToString()
        {
            return id +"/"+ FirstName +"/"+ LastName;
        }

    }
}