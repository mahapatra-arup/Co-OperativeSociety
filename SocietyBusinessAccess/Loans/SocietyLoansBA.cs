using BusinessEntities;
using BusinessEntities._enum;
using BusinessEntities.CustomProperties;
using SocietyBusinessAccess.Ledgers;
using SocietyDataAccess.Loans;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace SocietyBusinessAccess.Loans
{
    public class SocietyLoansBA
    {
        SocietyLoansDA frmSocityloansDA = new SocietyLoansDA();

        /// <summary>
        /// Insert Socity Loan Details With EMI and Transection 
        /// </summary>
        /// <param name="frmSLD"></param>
        /// <param name="frmlstSLE"></param>
        /// <param name="frmListTransection"></param>
        /// <returns></returns>
        public bool InsertSocityLoanWithLoanEMI(SocietyLoanDetail frmSLD, List<SocietyLoanEMI> frmlstSLE, List<Transection> frmListTransection)
        {
            return frmSocityloansDA.InsertSocityLoanWithLoanEMI(frmSLD, frmlstSLE, frmListTransection);
        }


        #region ================SocityLoanDetails=========
        /// <summary>
        /// Get Socity loan Details from table : SocietyLoanDetails
        /// </summary>
        /// <returns></returns>
        public List<SocietyLoanDetail> GetSocityLoanDetails()
        {
            return frmSocityloansDA.GetSocityLoanDetails();
        }

        /// <summary>
        /// Get Socity loan Details  use By _LedgerTo(Loan BankLedger)
        /// </summary>
        /// <returns></returns>
        public List<SocietyLoanDetail> GetSocityLoanDetails(Guid _LedgerTo)
        {
            //Get   Details
            List<SocietyLoanDetail> lstSocietyLoanDetail = frmSocityloansDA.GetSocityLoanDetails();
            IEnumerable<SocietyLoanDetail> lst = null;
            if (lstSocietyLoanDetail.IsValidList())
            {
                //Query
                lst = from SocietyLoanDetail in lstSocietyLoanDetail
                      where SocietyLoanDetail.LedgerTo == _LedgerTo
                      select SocietyLoanDetail;
            }
            return lst.ToList();
        }

        public bool IsLoanSlNoExist(string _LoanSlNo)
        {
            bool isExist = false;
            //Get   Details
            List<SocietyLoanDetail> lstSocietyLoanDetail = frmSocityloansDA.GetSocityLoanDetails();

            if (lstSocietyLoanDetail.IsValidList())
            {
                //Query
                IEnumerable<string> lst = from SocietyLoanDetail in lstSocietyLoanDetail
                                          where SocietyLoanDetail.SocietyLoanSlNo == _LoanSlNo
                                          select SocietyLoanDetail.SocietyLoanSlNo;

                if (lst.ISValidIEnumerableList())
                {
                    isExist = true;
                }
            }
            return isExist;
        }

        /// <summary>
        /// Get Socity Loan Details Use By Loan SlNo
        /// </summary>
        /// <param name="_LoanSlNo"></param>
        /// <returns></returns>
        public SocietyLoanDetail GetSocityLoanDetails(string _LoanSlNo)
        {
            //Get   Details
            List<SocietyLoanDetail> lstSocietyLoanDetail = frmSocityloansDA.GetSocityLoanDetails();
            IEnumerable<SocietyLoanDetail> lst = null;
            if (lstSocietyLoanDetail.IsValidList())
            {
                //Query
                lst = from SocietyLoanDetail in lstSocietyLoanDetail
                      where SocietyLoanDetail.SocietyLoanSlNo == _LoanSlNo
                      select SocietyLoanDetail;
            }
            return lst.FirstOrDefault();
        }


        #endregion


        #region =============Socity Loan EMi==============
        /// <summary>
        /// Delete & Update Already Payment Loan Emi Details 
        /// </summary>
        /// <param name="_Transection_ref_No"></param>
        /// <param name="frmSLE"></param>
        /// <returns></returns>
        public bool DeletePaidLoanEMIsWithTransection(string _Transection_ref_No, SocietyLoanEMI frmSLE)
        {
            return frmSocityloansDA.DeletePaidLoanEMIsWithTransection(_Transection_ref_No,  frmSLE);
        }

            /// <summary>
            /// Get Socity loan EMI Details from table : SocietyLoanEMI
            /// </summary>
            /// <returns></returns>
            public List<SocietyLoanEMI> GetSocityLoanEMI()
        {
            return frmSocityloansDA.GetSocityLoanEMI();
        }


        /// <summary>
        /// Get  Socity Loan Emi Ispaid:(false=Due List,True=Paid List)
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <param name="SocietyLoanSlNo"></param>
        /// <param name="IsPaid"></param>
        /// <returns></returns>
        public List<SocietyLoanEMI> GetSocityLoanEMI(string SocietyLoanSlNo, bool IsPaid)
        {
            //Get   Details
            List<SocietyLoanEMI> lstSocietyLoanDetailEMI = GetSocityLoanEMI();
            IEnumerable<SocietyLoanEMI> lst = null;

            if (lstSocietyLoanDetailEMI.IsValidList())
            {
                //Query
                lst = (from SocietyLoanEMI in lstSocietyLoanDetailEMI
                       where SocietyLoanEMI.SocietyLoanSlNo == SocietyLoanSlNo &&
                       SocietyLoanEMI.IsPaid == IsPaid
                       select SocietyLoanEMI);
            }
            return lst.ToList();
        }

        /// <summary>
        /// Get  Socity Loan Emis
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <param name="SocietyLoanSlNo"></param>
        /// <param name="IsPaid"></param>
        /// <returns></returns>
        public List<SocietyLoanEMI> GetSocityLoanEMI(string SocietyLoanSlNo)
        {
            //Get   Details
            List<SocietyLoanEMI> lstSocietyLoanDetailEMI = GetSocityLoanEMI();
            IEnumerable<SocietyLoanEMI> lst = null;

            if (lstSocietyLoanDetailEMI.IsValidList())
            {
                //Query
                lst = (from SocietyLoanEMI in lstSocietyLoanDetailEMI
                       where SocietyLoanEMI.SocietyLoanSlNo == SocietyLoanSlNo
                       select SocietyLoanEMI);
            }
            return lst.ToList();
        }

        #endregion

        #region ===================TranSection============
        public List<Transection> TransectionGenerate(SocietyLoanDetail frmCLD, Guid _loanbankLedgerId, Guid _savingbankLedgerId)
        {
            List<Transection> lstTransection = new List<Transection>();

            //Transection 1 <DR>
            lstTransection.Add(new Transection
            {
                TransectionID = Guid.NewGuid(),
                Date = frmCLD.Date,
                No = frmCLD.SocietyLoanSlNo,
                TransectionType = TransectionEnum._TransectionTypeValues.Society_Loan.GetEnumName(),
                LedgerIdFrom = _savingbankLedgerId,
                LedgerIdTo = _loanbankLedgerId,
                Amount_Dr = frmCLD.SanctionedAmount,
                Mode = "Bank",
                Narration = frmCLD.Remarks,
                Transection_Ref_No = frmCLD.Transection_Ref_No
            });

            //Transection 2 <CR>
            lstTransection.Add(new Transection
            {
                TransectionID = Guid.NewGuid(),
                Date = frmCLD.Date,
                No = frmCLD.SocietyLoanSlNo,
                TransectionType = TransectionEnum._TransectionTypeValues.Society_Loan.GetEnumName(),
                LedgerIdFrom = _loanbankLedgerId,
                LedgerIdTo = _savingbankLedgerId,
                Amount_Cr = frmCLD.SanctionedAmount,
                Mode = "Bank",
                Narration = frmCLD.Remarks,
                Transection_Ref_No = frmCLD.Transection_Ref_No
            });
            return lstTransection;
        }

        public List<Transection> LoanRepaymentTransection(SocietyLoanEMI frmCLE,
          [Description(" Socity Saving/Current Account Ledger")]
          Guid _socitySavingAcledgerId,
          Guid _LoanReceiveBankAcLedgerId)
        {
            //object type Variable
            List<Transection> lstTransection = new List<Transection>();
            LedgerBA ledgerBA = new LedgerBA();


            #region ---- _Loan_Against_Deposit_Ledger,_Loan_Against_Interest_Deposit,_Loan_Against_Principal_Deposit---
            Guid _Loan_Against_Deposit = ledgerBA.GetLedger(LedgerEnum._FixedLedgerName.Loan_Against_Deposit_From_Socity).LedgerId;
            Guid _Loan_Against_Principal_Deposit = ledgerBA.GetLedger(LedgerEnum._FixedLedgerName.Loan_Against_Principal_Deposit_From_Socity).LedgerId;
            Guid _Loan_Against_Interest_Deposit = ledgerBA.GetLedger(LedgerEnum._FixedLedgerName.Loan_Against_Interest_Deposit_From_Socity).LedgerId;

            #endregion


            #region ###############First Transection <Socity savingac To _Loan_Against_Principal_Deposit> ###############
            //Transection  DR
            lstTransection.Add(new Transection
            {
                TransectionID = Guid.NewGuid(),
                Date = frmCLE.PaidDate.ConvertObjectToDateTime(),
                No = frmCLE.VoucherNo.ConvertObjectToString(),
                TransectionType = TransectionEnum._TransectionTypeValues.Society_Loan_Repayment.GetEnumName(),

                //Ledger
                LedgerIdTo = _socitySavingAcledgerId,
                LedgerIdFrom = _Loan_Against_Principal_Deposit,

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
                TransectionType = TransectionEnum._TransectionTypeValues.Society_Loan_Repayment.GetEnumName(),

                //Ledger
                LedgerIdTo = _Loan_Against_Principal_Deposit,
                LedgerIdFrom = _socitySavingAcledgerId,

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
                TransectionType = TransectionEnum._TransectionTypeValues.Society_Loan_Repayment.GetEnumName(),

                //Ledger
                LedgerIdTo = _socitySavingAcledgerId,
                LedgerIdFrom = _Loan_Against_Interest_Deposit,

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
                TransectionType = TransectionEnum._TransectionTypeValues.Society_Loan_Repayment.GetEnumName(),

                //Ledger
                LedgerIdTo = _Loan_Against_Interest_Deposit,
                LedgerIdFrom = _socitySavingAcledgerId,

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
                TransectionType = TransectionEnum._TransectionTypeValues.Society_Loan_Repayment.GetEnumName(),

                //Ledger
                LedgerIdTo = _Loan_Against_Deposit,
                LedgerIdFrom = _LoanReceiveBankAcLedgerId,

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
                TransectionType = TransectionEnum._TransectionTypeValues.Society_Loan_Repayment.GetEnumName(),

                //Ledger
                LedgerIdTo = _LoanReceiveBankAcLedgerId,
                LedgerIdFrom = _Loan_Against_Deposit,

                //Amount
                Amount_Cr = _total_P_I,
                Narration = frmCLE.Remarks,
                Transection_Ref_No = frmCLE.Transection_Ref_No
            });
            #endregion

            return lstTransection;
        }
        #endregion

        #region =========Generate View====================
        public List<SocietyLoanStatement_Properties> GenerateSocityLoanStatement(DateTime from, DateTime to)
        {
            return frmSocityloansDA.GenerateSocityLoanStatement(from, to);
        }
        #endregion

        #region =============Loan Repayment===============
        public bool UpdateSocityLoanEmiWithTransection(SocietyLoanEMI frmSLE, List<Transection> frmListTransection)
        {
            return frmSocityloansDA.UpdateSocityLoanEmiWithTransection(frmSLE, frmListTransection);
        }
        #endregion

        #region ===================Others=================
        /// <summary>
        /// Calculate Total Loan of Emi (There are present Paid and Due Total)
        /// </summary>
        /// <param name="lstDetails"></param>
        public SocityEMIViewForTotal_Properties CalculateTotalofLoanEmi(List<SocietyLoanEMI> lstDetails)
        {
            SocityEMIViewForTotal_Properties _t = new SocityEMIViewForTotal_Properties();
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
