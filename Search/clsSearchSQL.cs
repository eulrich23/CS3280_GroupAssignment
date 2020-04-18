using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Group_Project_Assignment
{
    class clsSearchSQL
    {
        
        
        /// <summary>
        /// This SQL gets all data on an invoice for a given InvoiceID.
        /// </summary>
        /// <param name="sInvoiceID">The InvoiceID for the invoice to retrieve all data.</param>
        /// <returns>All data for the given invoice.</returns>
        public string SelectInvoiceNum(string sInvoiceID)
        {
            try
            {
                string sSQL = "SELECT * FROM Invoices WHERE InvoiceNum = " + sInvoiceID;
                return sSQL;
            }
            catch (Exception ex)
            {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            
        }

        /// <summary>
        /// This SQL gets all data on an invoice for a given InvoiceID and InvoiceDate.
        /// </summary>
        /// <param name="sInvoiceID"></param>
        /// <param name="sInvoiceDate"></param>
        /// <returns>All data for the given invoice.</returns>
        public string SelectInvoiceNumAndDate(string sInvoiceID, string sInvoiceDate)
        {
            try
            {
                string sSQL = "SELECT* FROM Invoices WHERE InvoiceNum = " + sInvoiceID + " AND InvoiceDate = #" + sInvoiceDate + "#";
                return sSQL;
            }
            catch (Exception ex)
            {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            
        }
        /// <summary>
        /// This SQL gets all data on an invoice for a given InvoiceID, InvoiceDate, and TotalCost.
        /// </summary>
        /// <param name="sInvoiceID"></param>
        /// <param name="sInvoiceDate"></param>
        /// <param name="sTotalCost"></param>
        /// <returns>All data for the given invoice.</returns>
        public string SelectInvoiceNumAndDateAndCost(string sInvoiceID, string sInvoiceDate, string sTotalCost)
        {
            try
            {
                string sSQL = "SELECT * FROM Invoices WHERE InvoiceNum = " + sInvoiceID + " AND InvoiceDate = #" + sInvoiceDate + "# AND TotalCost = " + sTotalCost;
                return sSQL;
            }
            catch (Exception ex)
            {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            
        }
        /// <summary>
        /// This SQL gets all data on an invoice for a given TotalCost.
        /// </summary>
        /// <param name="sTotalCost"></param>
        /// <returns>All data for the given invoice.</returns>
        public string SelectInvoiceCost(string sTotalCost)
        {
            try
            {
                string sSQL = "SELECT * FROM Invoices WHERE TotalCost = " + sTotalCost;
                return sSQL;
            }
            catch (Exception ex)
            {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            
        }
        /// <summary>
        /// This SQL gets all data on an invoice for a given InvoiceDate, and TotalCost.
        /// </summary>
        /// <param name="sInvoiceDate"></param>
        /// <param name="sTotalCost"></param>
        /// <returns>All data for the given invoice.</returns>
        public string SelectInvoiceDateAndCost(string sInvoiceDate, string sTotalCost)
        {
            try
            {
                string sSQL = "SELECT * FROM Invoices WHERE TotalCost = " + sTotalCost + "and InvoiceDate = #" + sInvoiceDate + "#";
                return sSQL;
            }
            catch (Exception ex)
            {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            
        }
        /// <summary>
        /// This SQL gets all data on an invoice for a given InvoiceDate.
        /// </summary>
        /// <param name="sInvoiceDate"></param>
        /// <returns>All data for the given invoice.</returns>
        public string SelectInvoiceDate(string sInvoiceDate)
        {
            try
            {
                string sSQL = "SELECT * FROM Invoices WHERE InvoiceDate = #" + sInvoiceDate + "#";
                return sSQL;
            }
            catch (Exception ex)
            {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            
        }
    }

//    - SELECT * FROM Invoices
//- SELECT* FROM Invoices WHERE InvoiceNum = 5000
//- SELECT* FROM Invoices WHERE InvoiceNum = 5000 AND InvoiceDate = #4/13/2018#
//-SELECT * FROM Invoices WHERE InvoiceNum = 5000 AND InvoiceDate = #4/13/2018# AND TotalCost = 120
//-SELECT * FROM Invoices WHERE TotalCost = 1200
//- SELECT* FROM Invoices WHERE TotalCost = 1300 and InvoiceDate = #4/13/2018# 
//-SELECT * FROM Invoices WHERE InvoiceDate = #4/13/2018#


}
