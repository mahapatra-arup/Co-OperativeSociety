using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities._enum
{
    public static class TransectionEnum
    {
        public enum _TransectionTypeValues
        {
            Society_Loan,
            Society_Loan_Repayment,
            Customer_Loan,
            Customer_Loan_Repayment,
            Income,
            Expense
        }

        public enum _TransectionAttributes
        {
            id,
            TransectionID,
            Date,
            No,
            TransectionType,
            LedgerIdFrom,
            LedgerIdTo,
            Amount_Dr,
            Amount_Cr,
            Mode,
            BankName,
            ChequeNo,
            ChequeDate,
            Narration,
            Status,
            Transection_Ref_No
        }
    }
}
