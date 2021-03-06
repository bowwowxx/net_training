﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESUN
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ESunDBEntities1 : DbContext
    {
        public ESunDBEntities1()
            : base("name=ESunDBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TbCurrency> TbCurrency { get; set; }
        public virtual DbSet<TbDepositeInterestRate> TbDepositeInterestRate { get; set; }
        public virtual DbSet<TbDepositLoanCategory> TbDepositLoanCategory { get; set; }
        public virtual DbSet<TbGoldenPassbook> TbGoldenPassbook { get; set; }
        public virtual DbSet<TbLoanInterestRate> TbLoanInterestRate { get; set; }
        public virtual DbSet<TbMessageContent> TbMessageContent { get; set; }
        public virtual DbSet<TbServiceType> TbServiceType { get; set; }
        public virtual DbSet<TbWithdrawalFee> TbWithdrawalFee { get; set; }
    
        public virtual ObjectResult<SP_DepositeInterestRate_Result> SP_DepositeInterestRate(string date, string currencyCode)
        {
            var dateParameter = date != null ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(string));
    
            var currencyCodeParameter = currencyCode != null ?
                new ObjectParameter("currencyCode", currencyCode) :
                new ObjectParameter("currencyCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_DepositeInterestRate_Result>("SP_DepositeInterestRate", dateParameter, currencyCodeParameter);
        }
    
        public virtual ObjectResult<SP_GoldenPassbook_Result> SP_GoldenPassbook(string createDate)
        {
            var createDateParameter = createDate != null ?
                new ObjectParameter("createDate", createDate) :
                new ObjectParameter("createDate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GoldenPassbook_Result>("SP_GoldenPassbook", createDateParameter);
        }
    
        public virtual ObjectResult<SP_LoanInterestRate_Result> SP_LoanInterestRate(string date, string currencyCode)
        {
            var dateParameter = date != null ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(string));
    
            var currencyCodeParameter = currencyCode != null ?
                new ObjectParameter("currencyCode", currencyCode) :
                new ObjectParameter("currencyCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_LoanInterestRate_Result>("SP_LoanInterestRate", dateParameter, currencyCodeParameter);
        }
    
        public virtual ObjectResult<string> SP_MessageContent(string typeCode)
        {
            var typeCodeParameter = typeCode != null ?
                new ObjectParameter("TypeCode", typeCode) :
                new ObjectParameter("TypeCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SP_MessageContent", typeCodeParameter);
        }
    
        public virtual int SP_UpdateCreateDate()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UpdateCreateDate");
        }
    
        public virtual ObjectResult<SP_WithdrawalFee_Result> SP_WithdrawalFee(string createDate, string currencyCode)
        {
            var createDateParameter = createDate != null ?
                new ObjectParameter("createDate", createDate) :
                new ObjectParameter("createDate", typeof(string));
    
            var currencyCodeParameter = currencyCode != null ?
                new ObjectParameter("currencyCode", currencyCode) :
                new ObjectParameter("currencyCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_WithdrawalFee_Result>("SP_WithdrawalFee", createDateParameter, currencyCodeParameter);
        }
    }
}
