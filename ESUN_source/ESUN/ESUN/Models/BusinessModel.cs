using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESUN.Models
{
	public class BusinessModel
	{
		//信用卡業務
		public List<BusinessPhone> CreditCardBusiness { get; set; }

		//存款業務
		public List<BusinessPhone> DepositeInterestBusiness { get; set; }

		//理財業務
		public List<BusinessPhone> InvestmentBusiness { get; set; }

		public BusinessModel()
		{
			CreditCardBusiness = new List<BusinessPhone>();
			DepositeInterestBusiness = new List<BusinessPhone>();
			InvestmentBusiness = new List<BusinessPhone>();
		}

		public void GenTest()
		{
			CreditCardBusiness.Add(new BusinessPhone { title = "信用卡申請", phone = "0221821313" });
			CreditCardBusiness.Add(new BusinessPhone { title = "帳單查詢", phone = "0221821314" });
			CreditCardBusiness.Add(new BusinessPhone { title = "開卡服務", phone = "0221821315" });
			CreditCardBusiness.Add(new BusinessPhone { title = "信用卡掛失", phone = "0221821316" });
			CreditCardBusiness.Add(new BusinessPhone { title = "自扣戶申請", phone = "0221821317" });
			DepositeInterestBusiness.Add(new BusinessPhone { title = "存匯服務", phone = "0221821318" });
			DepositeInterestBusiness.Add(new BusinessPhone { title = "掛失服務", phone = "0221821319" });
			InvestmentBusiness.Add(new BusinessPhone { title = "基金服務", phone = "0221821320" });
			InvestmentBusiness.Add(new BusinessPhone { title = "理財服務", phone = "0221821321" });
		}
	}

	public class BusinessPhone
	{
		public string title { get; set; }
		public string phone { get; set; }
	}
}