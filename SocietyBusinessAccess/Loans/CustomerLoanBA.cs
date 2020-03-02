using BusinessEntities;
using BusinessEntities._enum;
using SocietyBusinessAccess.Ledgers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using SocietyDataAccess.Loans;
using BusinessEntities.CustomProperties;
using System.Data.SqlClient;
using SocietyDataAccess.Transections;

namespace SocietyBusinessAccess.Loans
{
    public class CustomerLoanBA
    {
        CustomerloanDA frmCustomerloansDA = new CustomerloanDA();


        #region =============CustomerLoanDetail=============
        /// <summary>
        /// Get Customer Laon Details
        /// </summary>
        /// <returns></returns>
        public List<CustomerLoanDetail> GetCustomerLoanDetails()
        {
            return frmCustomerloansDA.GetCustomerLoanDetails();
        }

        /// <summary>
        /// Get Customer laon Details Use by Customer 
        /// </summary>
        /// <param name="_customerId"></param>
        /// <returns></returns>
        public IEnumerable<CustomerLoanDetail> GetCustomerLoanDetails(Guid _customerId)
        {
            //Get All Year Details
            List<CustomerLoanDetail> lstGetCustomerLoanEMI = GetCustomerLoanDetails();

            IEnumerable<CustomerLoanDetail> _lstICLI = null;
            if (lstGetCustomerLoanEMI.ISValidObject())
            {
                _lstICLI = from CustomerLoanDetail in lstGetCustomerLoanEMI
                           where CustomerLoanDetail.CustomerId == _customerId
                           select CustomerLoanDetail;
            }
            return _lstICLI;
        }

        #endregion

        #region ===============CustomerLoanEMI==============

        /// <summary>
        /// Get Customer Loan EMIes
        /// </summary>
        /// <returns></returns>
        public List<CustomerLoanEMI> GetCustomerLoanEMI()
        {
            return frmCustomerloansDA.GetCustomerLoanEMI();
        }
        /// <summary>
        /// Get Customer Loan EMI use By LoanId
        /// </summary>
        /// <param name="LoanId"></param>
        /// <returns></returns>
        public IEnumerable<CustomerLoanEMI> GetCustomerLoanEMI(Guid LoanId)
        {
            //Get All Year Details
            List<CustomerLoanEMI> lstGetCustomerLoanEMI = GetCustomerLoanEMI();

            IEnumerable<CustomerLoanEMI> _lstICLI = null;
            if (lstGetCustomerLoanEMI.ISValidObject())
            {
                _lstICLI = from CustomerLoanEMI in lstGetCustomerLoanEMI
                           where CustomerLoanEMI.LoanId == LoanId
                           select CustomerLoanEMI;
            }
            return _lstICLI;
        }

        /// <summary>
        /// Get Customer loan Emi By Customer
        /// </summary>
        /// <param name="_customerId"></param>
        /// <returns></returns>
        public List<CustomerLoanEMI> GetCustomerLoanEMIByCustomer(Guid _customerId)
        {
            return frmCustomerloansDA.GetCustomerLoanEMIByCustomer(_customerId);
        }

        /// <summary>
        /// Get  Customer Loan Emi Ispaid:(Due List=false,Paid List=True)
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <param name="SocietyLoanSlNo"></param>
        /// <param name="IsPaid"></param>
        /// <returns></returns>
        public List<CustomerLoanEMI> GetCustomerLoanEMI(Guid CustomerId, string SocietyLoanSlNo, bool IsPaid)
        {
            return frmCustomerloansDA.GetCustomerLoanEMI(CustomerId, SocietyLoanSlNo, IsPaid);
        }

        /// <summary>
        /// Delete & Update Paid EMIs
        /// </summary>
        /// <param name="_Transection_ref_No"></param>
        /// <param name="frmCLE"></param>
        /// <returns></returns>
        public bool DeletePaidLoanEMIsWithTransection(string _Transection_ref_No, CustomerLoanEMI frmCLE)
        {
            return frmCustomerloansDA.DeletePaidLoanEMIsWithTransection(_Transection_ref_No, frmCLE);
        }
        #endregion

        #region =====================Bool===================

        public bool IsLoanSlNoExist(Guid _Customerid, string _LoanSlNo)
        {
            bool isExist = false;
            //Get   Details
            List<CustomerLoanDetail> lstCustomerLoanDetail = GetCustomerLoanDetails();

            if (lstCustomerLoanDetail.IsValidList())
            {
                //Query
                IEnumerable<string> lst = from CustomerLoanDetail in lstCustomerLoanDetail
                                          where CustomerLoanDetail.CustomerId == _Customerid
                                         && CustomerLoanDetail.SocietyLoanSlNo == _LoanSlNo
                                          select CustomerLoanDetail.SocietyLoanSlNo;

                if (lst.ISValidIEnumerableList())
                {
                    isExist = true;
                }
            }
            return isExist;
        }
        #endregion

        #region =============Loan Repayment=================
        public bool UpdateCustomerLoanEmiWithTransection(CustomerLoanEMI frmCLE, List<Transection> frmListTransection)
        {
            return frmCustomerloansDA.UpdateCustomerLoanEmiWithTransection(frmCLE, frmListTransection);
        }
        #endregion

        #region ========Transection=========================
        /// <summary>
        /// Generate Loan Transection
        /// </summary>
        /// <param name="frmCLD"></param>
        /// <param name="lstCLE"></param>
        /// <param name="_SocietyMainBankLedgerId"></param>
        /// <param name="_SocitySavingLoanAmLedgerId"></param>
        /// <param name="_ShareDepositLedgerId"></param>
        /// <param name="_InsuranceFromCustomer"></param>
        /// <param name="_InsuranceFromSociety"></param>
        /// <returns></returns>
        public List<Transection> LoanTransection(CustomerLoanDetail frmCLD, List<CustomerLoanEMI> lstCLE,
        [Description("Use For Income Or Expence")]
        Guid _SocietyMainBankLedgerId,
        [Description(" Socity Amount use for Loan")]
        Guid _SocitySavingLoanAmLedgerId,
        [Description("use for Share Deposit Ledger")]
        Guid _ShareDepositLedgerId,
        [Description("use for Insurance From Customer Ledger")]
        Guid _InsuranceFromCustomer,
        [Description("use for Insurance From Society")]
        Guid _InsuranceFromSociety)

        {
            //object type Variable
            List<Transection> lstTransection = new List<Transection>();
            LedgerBA ledgerBA = new LedgerBA();


            //Get Loan and Saving A/c Ledger Id
            #region --Get Customer loan And Saving LedgerId--
            string str_customerLoanLedgerId = string.Empty;
            string str_customerSavingLedgerId = string.Empty;
            ledgerBA.GetLedgerofCustomer(frmCLD.CustomerId.ConvertObjectToString(), out str_customerLoanLedgerId, out str_customerSavingLedgerId);
            //Loan
            Guid _customerLoanLedgerId = Guid.Parse(str_customerLoanLedgerId);
            //Saving
            Guid _customerSavingLedgerId = Guid.Parse(str_customerSavingLedgerId);
            #endregion

            #region ###############First Transection <Socity savingac To Customer Loan Ac> ###############
            //Transection  DR
            lstTransection.Add(new Transection
            {
                TransectionID = Guid.NewGuid(),
                Date = frmCLD.Date,
                No = frmCLD.SocietyLoanSlNo,
                TransectionType = TransectionEnum._TransectionTypeValues.Customer_Loan.GetEnumName(),

                //Ledger
                LedgerIdTo = _SocitySavingLoanAmLedgerId,
                LedgerIdFrom = _customerLoanLedgerId,

                Amount_Dr = frmCLD.SanctionedAmount,
                Narration = frmCLD.Remarks,
                Transection_Ref_No = frmCLD.Transection_Ref_No
            });

            //Transection CR
            lstTransection.Add(new Transection
            {
                TransectionID = Guid.NewGuid(),
                Date = frmCLD.Date,
                No = frmCLD.SocietyLoanSlNo,
                TransectionType = TransectionEnum._TransectionTypeValues.Customer_Loan.GetEnumName(),

                //Ledger
                LedgerIdTo = _customerLoanLedgerId,
                LedgerIdFrom = _SocitySavingLoanAmLedgerId,

                //Amount
                Amount_Cr = frmCLD.SanctionedAmount,
                Narration = frmCLD.Remarks,
                Transection_Ref_No = frmCLD.Transection_Ref_No
            });
            #endregion

            #region ###############Second Transection <Customer Loan  To Customer Saving Ac>###############
            //Transection  DR
            lstTransection.Add(new Transection
            {
                TransectionID = Guid.NewGuid(),
                Date = frmCLD.Date,
                No = frmCLD.SocietyLoanSlNo,
                TransectionType = TransectionEnum._TransectionTypeValues.Customer_Loan.GetEnumName(),

                //Ledger
                LedgerIdTo = _customerLoanLedgerId,
                LedgerIdFrom = _customerSavingLedgerId,

                Amount_Dr = frmCLD.SanctionedAmount,
                Narration = frmCLD.Remarks,
                Transection_Ref_No = frmCLD.Transection_Ref_No

            });

            //Transection CR
            lstTransection.Add(new Transection
            {
                TransectionID = Guid.NewGuid(),
                Date = frmCLD.Date,
                No = frmCLD.SocietyLoanSlNo,
                TransectionType = TransectionEnum._TransectionTypeValues.Customer_Loan.GetEnumName(),

                //Ledger
                LedgerIdTo = _customerSavingLedgerId,
                LedgerIdFrom = _customerLoanLedgerId,

                //Amount
                Amount_Cr = frmCLD.SanctionedAmount,
                Narration = frmCLD.Remarks,
                Transection_Ref_No = frmCLD.Transection_Ref_No
            });
            #endregion

            #region ###############Third Transection < Customer Saving Ac To Share Deposit A/C>###############
            //Transection  DR
            lstTransection.Add(new Transection
            {
                TransectionID = Guid.NewGuid(),
                Date = frmCLD.Date,
                No = frmCLD.SocietyLoanSlNo,
                TransectionType = TransectionEnum._TransectionTypeValues.Customer_Loan.GetEnumName(),

                //Ledger
                LedgerIdTo = _customerSavingLedgerId,
                LedgerIdFrom = _ShareDepositLedgerId,

                Amount_Dr = frmCLD.ShareAmount,
                Narration = frmCLD.Remarks,
                Transection_Ref_No = frmCLD.Transection_Ref_No
            });

            //Transection CR
            lstTransection.Add(new Transection
            {
                TransectionID = Guid.NewGuid(),
                Date = frmCLD.Date,
                No = frmCLD.SocietyLoanSlNo,
                TransectionType = TransectionEnum._TransectionTypeValues.Customer_Loan.GetEnumName(),

                //Ledger
                LedgerIdTo = _ShareDepositLedgerId,
                LedgerIdFrom = _customerSavingLedgerId,

                //Amount
                Amount_Cr = frmCLD.ShareAmount,
                Narration = frmCLD.Remarks,
                Transection_Ref_No = frmCLD.Transection_Ref_No
            });
            #endregion

            #region ###############Four-th Transection < Customer Saving Ac To Insurance from Customer A/C>###############
            //Transection  DR
            lstTransection.Add(new Transection
            {
                TransectionID = Guid.NewGuid(),
                Date = frmCLD.Date,
                No = frmCLD.SocietyLoanSlNo,
                TransectionType = TransectionEnum._TransectionTypeValues.Customer_Loan.GetEnumName(),

                //Ledger
                LedgerIdTo = _customerSavingLedgerId,
                LedgerIdFrom = _InsuranceFromCustomer,

                Amount_Dr = frmCLD.InsuranceAmount,
                Narration = frmCLD.Remarks,
                Transection_Ref_No = frmCLD.Transection_Ref_No
            });

            //Transection CR
            lstTransection.Add(new Transection
            {
                TransectionID = Guid.NewGuid(),
                Date = frmCLD.Date,
                No = frmCLD.SocietyLoanSlNo,
                TransectionType = TransectionEnum._TransectionTypeValues.Customer_Loan.GetEnumName(),

                //Ledger
                LedgerIdTo = _InsuranceFromCustomer,
                LedgerIdFrom = _customerSavingLedgerId,

                //Amount
                Amount_Cr = frmCLD.InsuranceAmount,
                Narration = frmCLD.Remarks,
                Transection_Ref_No = frmCLD.Transection_Ref_No
            });
            #endregion

            #region ###############Five-th Transection <Socity Bank  To Insurance from Socity A/C>###############
            //Transection  DR
            lstTransection.Add(new Transection
            {
                TransectionID = Guid.NewGuid(),
                Date = frmCLD.Date,
                No = frmCLD.SocietyLoanSlNo,
                TransectionType = TransectionEnum._TransectionTypeValues.Customer_Loan.GetEnumName(),

                //Ledger
                LedgerIdTo = _SocietyMainBankLedgerId,
                LedgerIdFrom = _InsuranceFromSociety,

                Amount_Dr = frmCLD.InsuranceAmount,
                Narration = frmCLD.Remarks,
                Transection_Ref_No = frmCLD.Transection_Ref_No
            });

            //Transection CR
            lstTransection.Add(new Transection
            {
                TransectionID = Guid.NewGuid(),
                Date = frmCLD.Date,
                No = frmCLD.SocietyLoanSlNo,
                TransectionType = TransectionEnum._TransectionTypeValues.Customer_Loan.GetEnumName(),

                //Ledger
                LedgerIdTo = _InsuranceFromSociety,
                LedgerIdFrom = _SocietyMainBankLedgerId,

                //Amount
                Amount_Cr = frmCLD.InsuranceAmount,
                Narration = frmCLD.Remarks,
                Transection_Ref_No = frmCLD.Transection_Ref_No
            });
            #endregion

            return lstTransection;
        }

        public List<Transection> LoanRepaymentTransection(string _customerId, CustomerLoanEMI frmCLE,
            [Description(" Socity Saving/Current Account Ledger")]
            Guid _socitySavingAcledger)
        {
            //object type Variable
            List<Transection> lstTransection = new List<Transection>();
            LedgerBA ledgerBA = new LedgerBA();


            //Get Customer Loan and Saving A/c Ledger Id
            #region ---------------------Get Customer loan And Saving LedgerId--------------------------
            string str_customerLoanLedgerId = string.Empty;
            string str_customerSavingLedgerId = string.Empty;
            ledgerBA.GetLedgerofCustomer(_customerId, out str_customerLoanLedgerId, out str_customerSavingLedgerId);
            //Loan
            //Guid _customerLoanLedgerId = Guid.Parse(str_customerLoanLedgerId);
            //Saving
            Guid _customerSavingLedgerId = Guid.Parse(str_customerSavingLedgerId);
            #endregion


            #region ---- _Loan_Against_Deposit_Ledger,_Loan_Against_Interest_Collection,_Loan_Against_Principal_Collection ---
            Guid _Loan_Against_Deposit_Ledger = ledgerBA.GetLedger(LedgerEnum._FixedLedgerName.Loan_Against_Deposit_From_Customer).LedgerId;
            Guid _Loan_Against_Interest_Collection = ledgerBA.GetLedger(LedgerEnum._FixedLedgerName.Loan_Against_Interest_Collection_From_Customer).LedgerId;
            Guid _Loan_Against_Principal_Collection = ledgerBA.GetLedger(LedgerEnum._FixedLedgerName.Loan_Against_Principal_Collection_From_Customer).LedgerId;

            #endregion


            #region ###############First Transection <Customer savingac To _Loan_Against_Principal_Collection> ###############
            //Transection  DR
            lstTransection.Add(new Transection
            {
                TransectionID = Guid.NewGuid(),
                Date = frmCLE.PaidDate.ConvertObjectToDateTime(),
                No = frmCLE.VoucherNo.ConvertObjectToString(),
                TransectionType = TransectionEnum._TransectionTypeValues.Customer_Loan_Repayment.GetEnumName(),

                //Ledger
                LedgerIdTo = _customerSavingLedgerId,
                LedgerIdFrom = _Loan_Against_Principal_Collection,

                //Amount
                Amount_Dr = frmCLE.PrincipalAmount,
                Narration = frmCLE.Remarks,
                Transection_Ref_No = frmCLE.Transection_Ref_No
            });

            //Transection CR
            lstTransection.Add(new Transection
            {
                TransectionID = Guid.NewGuid(),
                Date = frmCLE.PaidDate.ConvertObjectToDateTime(),
                No = frmCLE.VoucherNo.ConvertObjectToString(),
                TransectionType = TransectionEnum._TransectionTypeValues.Customer_Loan_Repayment.GetEnumName(),

                //Ledger
                LedgerIdTo = _Loan_Against_Principal_Collection,
                LedgerIdFrom = _customerSavingLedgerId,

                //Amount
                Amount_Cr = frmCLE.PrincipalAmount,
                Narration = frmCLE.Remarks,
                Transection_Ref_No = frmCLE.Transection_Ref_No
            });
            #endregion

            #region ###############Second Transection <Customer savingac To _Loan_Against_Interest_Collection> ###############
            //Transection  DR
            lstTransection.Add(new Transection
            {
                TransectionID = Guid.NewGuid(),
                Date = frmCLE.PaidDate.ConvertObjectToDateTime(),
                No = frmCLE.VoucherNo.ConvertObjectToString(),
                TransectionType = TransectionEnum._TransectionTypeValues.Customer_Loan_Repayment.GetEnumName(),

                //Ledger
                LedgerIdTo = _customerSavingLedgerId,
                LedgerIdFrom = _Loan_Against_Interest_Collection,

                //Amount
                Amount_Dr = frmCLE.InterestAmount,
                Narration = frmCLE.Remarks,
                Transection_Ref_No = frmCLE.Transection_Ref_No
            });

            //Transection CR
            lstTransection.Add(new Transection
            {
                TransectionID = Guid.NewGuid(),
                Date = frmCLE.PaidDate.ConvertObjectToDateTime(),
                No = frmCLE.VoucherNo.ConvertObjectToString(),
                TransectionType = TransectionEnum._TransectionTypeValues.Customer_Loan_Repayment.GetEnumName(),

                //Ledger
                LedgerIdTo = _Loan_Against_Interest_Collection,
                LedgerIdFrom = _customerSavingLedgerId,

                //Amount
                Amount_Cr = frmCLE.InterestAmount,
                Narration = frmCLE.Remarks,
                Transection_Ref_No = frmCLE.Transection_Ref_No
            });
            #endregion

            #region ###############Third Transection < _Loan_Against_Deposit_Ledger To _socitySavingAcledger> ###############
            double _total_P_I = (frmCLE.PrincipalAmount + frmCLE.InterestAmount);
            //Transection  DR
            lstTransection.Add(new Transection
            {
                TransectionID = Guid.NewGuid(),
                Date = frmCLE.PaidDate.ConvertObjectToDateTime(),
                No = frmCLE.VoucherNo.ConvertObjectToString(),
                TransectionType = TransectionEnum._TransectionTypeValues.Customer_Loan_Repayment.GetEnumName(),

                //Ledger
                LedgerIdTo = _Loan_Against_Deposit_Ledger,
                LedgerIdFrom = _socitySavingAcledger,

                //Amount
                Amount_Dr = _total_P_I,
                Narration = frmCLE.Remarks,
                Transection_Ref_No = frmCLE.Transection_Ref_No
            });

            //Transection CR
            lstTransection.Add(new Transection
            {
                TransectionID = Guid.NewGuid(),
                Date = frmCLE.PaidDate.ConvertObjectToDateTime(),
                No = frmCLE.VoucherNo.ConvertObjectToString(),
                TransectionType = TransectionEnum._TransectionTypeValues.Customer_Loan_Repayment.GetEnumName(),

                //Ledger
                LedgerIdTo = _socitySavingAcledger,
                LedgerIdFrom = _Loan_Against_Deposit_Ledger,

                //Amount
                Amount_Cr = _total_P_I,
                Narration = frmCLE.Remarks,
                Transection_Ref_No = frmCLE.Transection_Ref_No
            });
            #endregion

            return lstTransection;
        }
        #endregion


        #region =================All Mixer==================
        /// <summary>
        /// /Insert customer Loan Details With EMI And Insert Loan Transection
        /// </summary>
        /// <param name="frmCLD"></param>
        /// <param name="frmlstCLE"></param>
        /// <param name="frmListTransection"></param>
        /// <returns></returns>
        public bool InsertCustomerLoanWithLoanEMI(CustomerLoanDetail frmCLD, List<CustomerLoanEMI> frmlstCLE, List<Transection> frmlstTransection)
        {
            return frmCustomerloansDA.InsertCustomerLoanWithLoanEMI(frmCLD, frmlstCLE, frmlstTransection);
        }



        /// <summary>
        /// Get Due Loan Amount Use By Customer
        /// </summary>
        /// <param name="_customerId"></param>
        /// <param name="_duePrincipleAm"></param>
        /// <param name="_dueInterestLoanAm"></param>
        /// <returns></returns>
        public double GetDueLoanAmount(Guid _customerId, out double _duePrincipleAm, out double _dueInterestLoanAm)
        {
            //out Var
            _duePrincipleAm = 0;
            _dueInterestLoanAm = 0;
            double _totalDue = 0;

            //Main List
            List<CustomerLoanEMI> lstCusEmi = GetCustomerLoanEMIByCustomer(_customerId);
            //Logic

            // ==Due Principle Amount==
            IEnumerable<double> _pAmountlist = from CustomerLoanEMI in lstCusEmi
                                               where (CustomerLoanEMI.IsPaid.ConvertObjectToBool()) != true
                                               select CustomerLoanEMI.PrincipalAmount;
            _duePrincipleAm = _pAmountlist.Sum();

            //== Due Interest Amount==
            _dueInterestLoanAm = (from CustomerLoanEMI in lstCusEmi
                                  where (CustomerLoanEMI.IsPaid.ConvertObjectToBool()) != true
                                  select CustomerLoanEMI.InterestAmount).Sum();


            //return Total Due Amount
            _totalDue = _duePrincipleAm + _dueInterestLoanAm;
            return _totalDue;
        }

        public long GetMaxVoucherNo()
        {
            List<CustomerLoanEMI> lstCLE = GetCustomerLoanEMI();
            var _voucherNo = (from CustomerLoanEMI in lstCLE
                              select CustomerLoanEMI).Max(x => x.VoucherNo);
            return _voucherNo.ConvertObjectToInt();
        }

        /// <summary>
        /// Get Customer details With loan Details 
        /// </summary>
        /// <returns></returns>
        public List<GetSetValues<CustomerLoanDetail, CustomerList>> GetCustomerLoanDetailsWithCustomer(DateTime from, DateTime to)
        {
            return frmCustomerloansDA.GetCustomerLoanDetailsWithCustomer(from, to);
        }

        #endregion

        #region ===================generate=================
        public List<CustomerLoanStatement_Properties> GenerateCustometLoanStatement(DateTime from, DateTime to)
        {
            return frmCustomerloansDA.GenerateCustometLoanStatement(from, to);
        }
        #endregion

        #region ===================Others=====================
        /// <summary>
        /// Calculate Total Loan of Emi (There are present Paid and Due Total)
        /// </summary>
        /// <param name="lstDetails"></param>
        public CustomerEMIViewForTotal_Properties CalculateTotalofLoanEmi(List<CustomerLoanEMI> lstDetails)
        {
            CustomerEMIViewForTotal_Properties _t = new CustomerEMIViewForTotal_Properties();
            //Paid
            _t.TotalPaidPrinciple = lstDetails.Where(p => p.IsPaid == true).Select(q => q.PrincipalAmount).Sum();
            _t.TotalPaidInterest = lstDetails.Where(p => p.IsPaid == true).Select(q => q.InterestAmount).Sum();
            _t.TotalPaidNoofEMI = lstDetails.Where(p => p.IsPaid == true).Count();

            //Due
            _t.TotalDuePrinciple = lstDetails.Where(p => p.IsPaid != true).Select(q => q.PrincipalAmount).Sum();
            _t.TotalDueInterest = lstDetails.Where(p => p.IsPaid != true).Select(q => q.InterestAmount).Sum();
            _t.TotalDueNoofEMI = lstDetails.Where(p => p.IsPaid != true).Count();
            return _t;
        }
        #endregion
    }
}
