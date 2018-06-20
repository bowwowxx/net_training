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
	/// 黃金存摺牌價查詢
	/// </summary>
    public class GetGlodRateController : ApiController
    {
		/// <summary>
		/// 取得黃金存摺牌價
		/// </summary>
		/// <returns>JSON</returns>
		[HttpGet]
		public JsonResult<GlodRateModel> Get()
		{
			GlodRateModel model = new GlodRateModel();
			model.GenTest();

			return Json(model);
		}
	}
}
