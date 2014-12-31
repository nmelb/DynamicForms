using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace DynamicForms.Models.Dynamic_Forms
{
    public class DynamicParameter
    {
        public DynamicParameter()
        {

        }

        public string LabelName { get; set; }
        public string FormName { get; set; } // Unique
        public string Type { get; set; }        
    }
}