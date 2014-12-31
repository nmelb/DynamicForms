using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DynamicForms.Models.Dynamic_Forms;

namespace DynamicForms.Controllers
{
    public class DynamicFormTestController : Controller
    {
        [HttpGet]
        public ActionResult DynForm()
        {
            var obj = new DynamicForm("SampleFormConfig.xml");
            return View(obj);
        }
        
        [HttpPost]
        public ActionResult DynForm(FormCollection form)
        {
            var obj = new DynamicForm("SampleFormConfig.xml", form);

            return View();
        }
    }
}