using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESUN;
using ESUN.Controllers;

namespace ESUN.Tests.Controllers
{
	[TestClass]
	public class HomeControllerTest
	{
		[TestMethod]
		public void GetRateTest()
		{
			GetRateController api = new GetRateController();
			var result = api.Get();

			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void GetGlodRateTest()
		{
			GetGlodRateController api = new GetGlodRateController();
			var result = api.Get();

			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void GetBusinessPhoneTest()
		{
			GetBusinessPhoneController api = new GetBusinessPhoneController();
			var result = api.Get();

			Assert.IsNotNull(result);
		}

	}
}
