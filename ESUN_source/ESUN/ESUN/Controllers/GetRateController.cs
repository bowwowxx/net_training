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
	/// 台幣存放款利率查詢
	/// </summary>
    public class GetRateController : ApiController
    {
		/// <summary>
		/// 取得台幣存放款利率
		/// </summary>
		/// <returns>JSON</returns>
		public JsonResult<RateModel> Get()
		{
			RateModel model = new RateModel();
			model.GenTest();

			return Json(model);
		}
	}
}
