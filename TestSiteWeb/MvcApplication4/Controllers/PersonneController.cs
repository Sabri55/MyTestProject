using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication4.Models;




namespace MvcApplication4.Controllers
{
    public class PersonneController : Controller
    {

       // private BDv2bEntities a = new BDv2bEntities();
        //
        // GET: /Personne/

        public ActionResult Index()
        {
            var list = personneDAL.getAllPersones();
            return View(list);
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(personneModels personne)
        {

            return  Redirect("~/Personne");
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult Autocomplete(string term)
        {
            var result = new List<KeyValuePair<string, string>>();

            IList<SelectListItem> List = new List<SelectListItem>();
            List.Add(new SelectListItem { Text = "test1", Value = "0" });
            List.Add(new SelectListItem { Text = "test2", Value = "1" });
            List.Add(new SelectListItem { Text = "test3", Value = "2" });
            List.Add(new SelectListItem { Text = "test4", Value = "3" });

            foreach (var item in List)
            {
                result.Add(new KeyValuePair<string, string>(item.Value.ToString(), item.Text));
            }
            //var result3 = result.Where(s => s.Value.ToLower().Contains
            //              (term.ToLower())).Select(w => w).ToList();

            var list = personneDAL.getAllPersones();

            return Json(list, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var personne = personneDAL.getAllPersones().Single(p => p.id == Id);
            personneModels perso = AutoMapper.Mapper.Map<personneModels>(personne);
            return View(perso);
        }

        [HttpPost]
        public ActionResult Edit(personneModels personne)
        {          
            return View();
        }


    }
}
