using NUnit.Framework;
using System;
using System.Web.Http;
using api;
using api.Controllers;
using System.Collections.Generic;

namespace api.Tests.Controllers
{
    [TestFixture]
    public class ValuesControllerTest
    {
		[Test]
		public void Get()
        {
            var controller = new ValuesController();

            var result = (IEnumerable<string>)controller.Get();

            var forecast = new string[] { "value", "value2" };

            Assert.AreEqual(forecast, result);
        }

        [Test]
        public void GetByName()
        {
            var controller = new ValuesController();

            var result = (string)controller.GetByName("Porter");
            var forecast = (string)"my name is Porter";

            Assert.AreEqual(forecast,result);
        }

        [Test]
        public void Post()
        {
            var controller = new ValuesController();

            var result = (string)controller.Post("1", "");
            var forecast = "success";

            Assert.AreEqual(forecast, result);
        }
    }
}
