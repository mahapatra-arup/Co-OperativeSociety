﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessEntities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CoOperativeEntities1 : DbContext
    {
        public CoOperativeEntities1()
            : base("name=CoOperativeEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<CustomerAddressDetail> CustomerAddressDetails { get; set; }
        public virtual DbSet<CustomerBankDetail> CustomerBankDetails { get; set; }
        public virtual DbSet<CustomerDetail> CustomerDetails { get; set; }
        public virtual DbSet<CustomerLoanDetail> CustomerLoanDetails { get; set; }
        public virtual DbSet<CustomerLoanEMI> CustomerLoanEMIs { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<FinancialYear> FinancialYears { get; set; }
        public virtual DbSet<LedgerBankDetail> LedgerBankDetails { get; set; }
        public virtual DbSet<Ledger> Ledgers { get; set; }
        public virtual DbSet<LedgersStatu> LedgersStatus { get; set; }
        public virtual DbSet<LedgerSubAccount> LedgerSubAccounts { get; set; }
        public virtual DbSet<LoanSubType> LoanSubTypes { get; set; }
        public virtual DbSet<LoanType> LoanTypes { get; set; }
        public virtual DbSet<ROIofBank> ROIofBanks { get; set; }
        public virtual DbSet<SocietyDetail> SocietyDetails { get; set; }
        public virtual DbSet<SocietyLoanDetail> SocietyLoanDetails { get; set; }
        public virtual DbSet<SocietyLoanEMI> SocietyLoanEMIs { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Transection> Transections { get; set; }
        public virtual DbSet<CustomerList> CustomerLists { get; set; }
        public virtual DbSet<TransectionView> TransectionViews { get; set; }
        public virtual DbSet<DecimalPointTool> DecimalPointTools { get; set; }
    }
}
