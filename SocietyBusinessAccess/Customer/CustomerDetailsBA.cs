using BusinessEntities;
using SocietyDataAccess.Customer;
using System.Collections.Generic;


namespace SocietyBusinessAccess.Customer
{
    public class CustomerDetailsBA
    {

        CustomerDetailsDA frmCustomerDetailsDA = new CustomerDetailsDA();

        #region ========================Insert /Update=====================
        /// <summary>
        /// Insert Customer Details With Address and bank details 
        /// </summary>
        /// <param name="frmCD"></param>
        /// <param name="frmCAD"></param>
        /// <param name="frmCBD"></param>
        /// <param name="frmlstLedger">Customer Ledger(like Parent and loan ledger)</param>
        /// <returns></returns>
        public bool InsertCustomerDetails(CustomerDetail frmCD, CustomerAddressDetail frmCAD, CustomerBankDetail frmCBD, List<Ledger> frmlstLedger)
        {
            return frmCustomerDetailsDA.InsertCustomerDetails(frmCD, frmCAD, frmCBD, frmlstLedger);
        }

        /// <summary>
        /// update Customer Details With Address and bank details 
        /// </summary>
        /// <param name="frmCD"></param>
        /// <param name="frmCAD"></param>
        /// <param name="frmCBD"></param>
        /// <param name="frmlstLedger">only LedgerID,LedgerName are Acceptable</param>
        /// <returns></returns>
        public bool UpdateCustomerDetails(CustomerDetail frmCD, CustomerAddressDetail frmCAD, CustomerBankDetail frmCBD, List<Ledger> frmlstLedger)
        {
            return frmCustomerDetailsDA.UpdateCustomerDetails(frmCD, frmCAD, frmCBD, frmlstLedger);
        }

        #endregion

        #region =========================Get===============================

        /// <summary>
        /// Get Customer Details With Address and Bank Details
        /// </summary>
        /// <returns></returns>
        public List<CustomerList> GetCustomerList()
        {
            return frmCustomerDetailsDA.GetCustomerList();
        }



        /// <summary>
        /// Get Customer Details With Address and Bank Details 
        /// </summary>
        /// <param name="CustomerId">Use By [CustomerId]</param>
        /// <returns></returns>
        public CustomerList GetCustomerList(object CustomerId)
        {
            return frmCustomerDetailsDA.GetCustomerList(CustomerId);
        }

        /// <summary>
        /// Use CustomerList Table
        /// </summary>
        /// <param name="_CustomerName"></param>
        /// <param name="_CustomerPhNo"></param>
        /// <param name="_OtherQuery">Like : CustomerID!=1 </param>
        /// <returns></returns>
        public bool IsAlreadyExist(object _CustomerName, object _CustomerPhNo, string _OtherQuery)
        {
            return frmCustomerDetailsDA.IsAlreadyExist(_CustomerName, _CustomerPhNo,  _OtherQuery);
        } 
        #endregion
    }
}
