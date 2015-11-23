using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication4.Models
{
    public class personneDAL
    {
        public int id { get; set; }
        public List<Role> Roles { get; set; }

        public static List<personneModels> getAllPersones()
        {
            var list = new List<personneModels>(){
                 new personneModels(){ id = 1 ,FirstName="ben", LastName="sabri"}
                ,new personneModels(){ id = 2 ,FirstName="ben", LastName="sabri"}
                ,new personneModels(){ id = 3 ,FirstName="ben", LastName="sabri"}
                ,new personneModels(){ id = 4 ,FirstName="ben", LastName="sabri"}

            };
            return list;

        }
       
    }
}