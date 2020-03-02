using System;
using System.ComponentModel.DataAnnotations;


namespace BusinessEntities._enum
{
    public class LedgerEnum
    {
        /// <summary>
        /// Columns of [ledgers] Entity
        /// </summary>
        public enum _LedgerAttributes
        {
            Id,
            LedgerId,
            LedgerName,
            TemplateName,
            Category,
            SubAccount,
            ParentLedgerId,
            Type
        }

        /// <summary>
        /// Ledger category columns Values
        /// </summary>
        public enum _LedgerCategoryValues
        {
            Society_Loan_AC,
            Society_Saving_AC,
            Society_Current_AC,
            Insurance,
            Interest,
            ShareDeposit,
            Cash,

            Bank,
            Customer,
            Customer_Loan_AC,
            Customer_Saving_AC,
            Loan_Collection,
            Loan_Deposit,
            //--------==Custom===-----
            //Ref:https://accounting-simplified.com/financial/bank-reconciliation/errors-in-cash-book.html


            Others_Income,
            Others_Expence
        }

        /// <summary>
        /// Fixed ledger Name
        /// use  [Display [Name]]
        /// </summary>
        public enum _FixedLedgerName
        {
            //Do Not Change This <Display [Name]> Because This Is The Fixed ledger Name

            //---------==Society==-------------
            [Display(Name = "CASH A/C")]
            CASH_AC,

            // Give The Some Insurance Amount when Customer Take a Loan
            [Display(Name = "Insurance From Socity")]
            Insurance_From_Socity,

            //Loan Against Principal Deposit From Socity use when Socity Paid Loan
            [Display(Name = "Loan Against Principal Deposit From Socity")]
            Loan_Against_Principal_Deposit_From_Socity,
            //Loan Against Interest Deposit From Socity use when Socity Paid Loan
            [Display(Name = "Loan Against Interest Deposit From Socity")]
            Loan_Against_Interest_Deposit_From_Socity,
            //Loan Against Deposit From Socity use when Socity Paid Loan
            [Display(Name = "Loan Against Deposit From Socity")]
            Loan_Against_Deposit_From_Socity,

            //[Display(Name = "Interest Of Share Deposit A/C")]
            //Interest_Of_Share_Deposit_AC


            //-----------------------==Customer==-----------------
            //Get Insurance From Customer when Customer Take a loan
            [Display(Name = "Insurance From Customer")]
            Insurance_From_Customer,

            //Get [Share Deposit] From Customer when Customer Take a loan
            [Display(Name = "Share Deposit from Customer")]
            Share_Deposit_from_Customer,

            // when Customer Re-Payment Loan
            [Display(Name = "Loan Against Interest Collection From Customer")]
            Loan_Against_Interest_Collection_From_Customer,

            // when Customer Re-Payment Loan
            [Display(Name = "Loan Against Principal Collection From Customer")]
            Loan_Against_Principal_Collection_From_Customer,

            // when Customer Re-Payment Loan
            [Display(Name = "Loan Against Deposit From Customer")]
            Loan_Against_Deposit_From_Customer,
        }

        /// <summary>
        ///Value of Ledger [SubAccount]
        ///use  [Display [Name]]
        /// </summary>
        public enum _LedgerSubAccount
        {
            //Do Not Change This <Display [Name]> Because This Is The Fixed ledger Name
            [Display(Name = "Current Assets")]
            Current_Assets,
            [Display(Name = "Current Liability")]
            Current_Liability,
            [Display(Name = "Capital A/C")]
            Capital_AC,
            [Display(Name = "Direct Expense")]
            Direct_Expense,
            [Display(Name = "Indirect Expense")]
            Indirect_Expense,
            [Display(Name = "Direct Income")]
            Direct_Income,
            [Display(Name = "Indirect Income")]
            Indirect_Income,
            [Display(Name = "Investment")]
            Investment,
            [Display(Name = "Loans(Liability)")]
            Loans_Liability,
            [Display(Name = "Fixed Assets")]
            Fixed_Assets,
            [Display(Name = "Duties & Tax")]
            Duties_and_Tax,
            [Display(Name = "Bank A/C")]
            Bank_AC,
            [Display(Name = "Cash A/C")]
            Cash_AC,
            [Display(Name = "Load & Advances")]
            Load_And_Advances,
            [Display(Name = "Stock in Hand")]
            Stock_in_Hand,
            [Display(Name = " Sundry Creditors")]
            Sundry_Creditors,
            [Display(Name = "Sundry Debtors")]
            Sundry_Debtors,
            [Display(Name = "Check in Hand")]
            Check_in_Hand

        }

        /// <summary>
        /// Value of Lesger [Type] Attribute
        /// </summary>
        public enum _LedgerTypeValues
        {

            Assets,
            Liabilities,
            Expense,
            Income,
            Revenue

            //                1. Asset accounts: Resources of value the business owns and uses. 
            //     Example: Cash on hand.
            //     Example: Accounts Receivable.
            //2. Liability accounts: Debts the business owes.
            //     Example: Accounts Payable.
            //     Example: Salaries Payable.
            //3. Equity accounts: The owner's claim to business assets.
            //     Example: Owner Capital.
            //     Example: Retained Earnings.

            //Secondly, There Are "Income Statement" Account Categories:

            //4. Revenue accounts:  These can be, for example, earnings from selling goods and services, or investment income, or extraordinary income.
            //     Example: Product Sales Revenues.
            //     Example: Interest Earned Revenues.
            //5. Expense accounts: Expenses incurred in the course of business.
            //     Example: Direct Labor Costs.
            //     Example: Advertising Expenses.

        }
    }
}
