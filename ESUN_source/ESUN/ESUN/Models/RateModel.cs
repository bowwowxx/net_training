using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ESUN.Models
{
	public class RateModel
	{
		/// <summary>
		/// 生效日
		/// </summary>
		public string UpdateTime { get; set; }
		/// <summary>
		/// 存款利率
		/// </summary>
		public depositeInterestRateList depositeInterestRateList { get; set; }
		/// <summary>
		/// 放款利率
		/// </summary>
		public loanInterestRateList loanInterestRateList { get; set; }
		public RateModel()
		{
			depositeInterestRateList = new depositeInterestRateList();
			loanInterestRateList = new loanInterestRateList();
		} 
		public void  GenTest()
		{

			
			UpdateTime = "2018/06/12";

			ESunDBEntities1 ef = new ESunDBEntities1();

			string sql = @"	select Category as title , FloatingRate as fRate, FixRate as mRate  from [dbo].[TbDepositeInterestRate] dep left join [dbo].[TbDepositLoanCategory] c on dep.CategoryCode = c.CategoryCode
						where CONVERT(varchar, dep.CreateDate , 112) = 20180613 and dep.CurrencyCode = 'TWD' and [Type] = 'D'
						order by dep.CreateDate desc";

			List<DepositeRate> DRage = ef.Database.SqlQuery<DepositeRate>(sql).ToList();
			this.depositeInterestRateList.DepositeRate = DRage;


			sql = @"select Category as title , Rate  from [dbo].[TbLoanInterestRate] dep left join [dbo].[TbDepositLoanCategory] c on dep.CategoryCode = c.CategoryCode
					where CONVERT(varchar, dep.CreateDate , 112) = 20180613 and dep.CurrencyCode = 'TWD' and [Type] = 'L'
					order by dep.CreateDate desc";

			List<LoanRate> LoanRate = ef.Database.SqlQuery<LoanRate>(sql).ToList();
			this.loanInterestRateList.LoanRate = LoanRate;

			//List<DepositeRate> DepositeRate = new List<DepositeRate>();
			//DepositeRate.Add(new DepositeRate { fRate = "不計息", mRate = "不計息", title = "支票存款" });
			//DepositeRate.Add(new DepositeRate { fRate = "-", mRate = "0.010", title = "活期存款" });
			//this.depositeInterestRateList.DepositeRate = DepositeRate;

			//List<LoanRate> LoanRate = new List<LoanRate>();
			//LoanRate.Add(new LoanRate { Rate = "15.000", title = "信用卡最高利率" });
			//LoanRate.Add(new LoanRate { Rate = "14.880", title = "信用卡次高利率" });
			//this.loanInterestRateList.LoanRate = LoanRate;
		}
	}
}