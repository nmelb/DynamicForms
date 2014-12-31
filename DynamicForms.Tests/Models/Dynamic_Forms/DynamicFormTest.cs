using System;
using DynamicForms.Models.Dynamic_Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynamicForms.Tests.Models.Dynamic_Forms
{
    [TestClass]
    public class DynamicFormTest
    {
        [TestMethod]
        public void TestForm()
        {
            var fObj = new DynamicForm("SampleFormConfig.xml");
        }
    }
}
