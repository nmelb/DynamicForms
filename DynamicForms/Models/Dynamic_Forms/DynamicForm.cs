using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Data;

namespace DynamicForms.Models.Dynamic_Forms
{
    public class DynamicForm : FormParameter
    {
        public DynamicForm()
        {
        }

        /// <summary>
        /// Builds a parameter list from config file provided
        /// </summary>
        /// <param name="fileName"></param>
        public DynamicForm(string fileName)
        {
            ConfigFileName = fileName;
            PopulateParams();
        }
        
        /// <summary>
        /// Binds form collection
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="form"></param>
        public DynamicForm(string fileName, FormCollection form)
        {
            ConfigFileName = fileName;
            PopulateParams();

            var binder = new List<string>();

            // This is an example on how tio retrieve values from FormCollection by Config params
            foreach (var item in Parameters)
            {
                binder.Add(form[item.FormName]);
            }
        }

        public List<DynamicParameter> Parameters { get; set; }

        private string ConfigFileName { get; set; }

        private void PopulateParams()
        {
            // Read file (the path retrieval is for test purposes only)
            string file = AppDomain.CurrentDomain.BaseDirectory + "//FormsCfg//" + ConfigFileName;

            // Get form values
            var xml = XDocument.Load(file);
            var FormElement = xml.Element("form");
            Parameters = (from a in FormElement.Descendants("field")
                          select new DynamicParameter
                              {
                                  LabelName = (string)a.Element("name"),
                                  Type = (string)a.Element("type"),
                                  FormName = (string)a.Element("formname"),
                              }).ToList();

        }
    }
}