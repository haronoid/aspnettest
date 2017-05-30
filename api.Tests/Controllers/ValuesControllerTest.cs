using NUnit.Framework;
using System;
using System.Web.Http;
using api;
using api.Controllers;

namespace api.Tests.Controllers
{
    [TestFixture]
    public class ValuesControllerTest
    {
		[Test]
		public void GetValue()
        {
            var controller = new ValuesController();

            var result = controller.GetValue();

            Assert.AreEqual("value", result);
        }
    }
}
