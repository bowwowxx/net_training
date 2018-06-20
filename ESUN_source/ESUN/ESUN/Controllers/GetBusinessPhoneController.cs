using ESUN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace ESUN.Controllers
{
	/// <summary>
	/// 玉山e客服專線
	/// </summary>
    public class GetBusinessPhoneController : ApiController
    {
		/// <summary>
		/// 取得玉山e客服專線
		/// </summary>
		/// <returns>JSON</returns>
		[HttpGet]
		public JsonResult<BusinessModel> Get()
		{
			BusinessModel model = new BusinessModel();
			model.GenTest();

			return Json(model);
		}
	}
}
