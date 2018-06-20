using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESUN.Models
{
	public class GlodRateModel
	{
		/// <summary>
		/// 黃金存摺利率
		/// </summary>
		public List<GoldPrice> GoldPrice { get; set; }

		public GlodRateModel()
		{
			GoldPrice = new List<GoldPrice>();
		}

		public void  GenTest()
		{
			this.GoldPrice.Add(new GoldPrice {  Buy = "1200000.00" , Curcd = "00" , Currency ="NTD", CurrencyText ="新台幣" , DPDiff = "6809.00" , GoodName = "黃金條塊1公斤"  , GoodNo = "GB0010001000" , InfoDateTime = "2017-01-06T13:55:00" , Sell = "1221809.00" , SellT = "0.00" });
			this.GoldPrice.Add(new GoldPrice {  Buy = "600000.00", Curcd = "00" , Currency ="NTD", CurrencyText ="新台幣" , DPDiff = "4011.00", GoodName = "黃金條塊500克", GoodNo = "GB0010002000", InfoDateTime = "2017-01-06T13:55:00" , Sell = "611511.00", SellT = "0.00" });
			this.GoldPrice.Add(new GoldPrice {  Buy = "300000.00", Curcd = "00" , Currency ="NTD", CurrencyText ="新台幣" , DPDiff = "2309.00", GoodName = "黃金條塊250克", GoodNo = "GB0010003000", InfoDateTime = "2017-01-06T13:55:00" , Sell = "306059.00", SellT = "0.00" });
			this.GoldPrice.Add(new GoldPrice {  Buy = "120000.00", Curcd = "00" , Currency ="NTD", CurrencyText ="新台幣" , DPDiff = "1312.00", GoodName = "黃金條塊100克", GoodNo = "GB0010004000", InfoDateTime = "2017-01-06T13:55:00" , Sell = "122812.00", SellT = "0.00" });
			this.GoldPrice.Add(new GoldPrice {  Buy = "1200.00", Curcd = "00" , Currency ="NTD", CurrencyText ="新台幣" , DPDiff = "0.00", GoodName = "黃金存摺1公克", GoodNo = "GB0030001000", InfoDateTime = "2017-01-06T13:55:00" , Sell = "1215.00", SellT = "0.00" });
			this.GoldPrice.Add(new GoldPrice {  Buy = "1169.20", Curcd = "01" , Currency = "USD", CurrencyText = "美元", DPDiff = "0.00", GoodName = "黃金存摺1盎司", GoodNo = "GB0030001000", InfoDateTime = "2017-01-06T13:55:00" , Sell = "1181.00", SellT = "0.00" });
		}
	}
}