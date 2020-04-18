using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8GroupAssignment.Main
{
    class clsMainSQL
    {
        /// <summary>

        /// This SQL gets all data on an invoice for a given InvoiceID.

        /// </summary>

        /// <param name="sInvoiceID">The InvoiceID for the invoice to retrieve all data.</param>

        /// <returns>All data for the given invoice.</returns>

        public string SelectInvoiceData(string sInvoiceID)

        {

            string sSQL = "SELECT * FROM Invoices WHERE InvoiceNum = " + sInvoiceID;

            return sSQL;

        }

        /*
            SQL statements from file provided by professor
        */




            /// <summary>
            /// Update Invoice with Total Cost
            /// </summary>
            /// <param name="sInvoiceID"></param>
            /// <returns></returns>

        public string UpdateCost(double cost, string sInvoiceID)

        {

            string sSQL = "UPDATE Invoices SET TotalCost = " + cost + "WHERE InvoiceNum = " + sInvoiceID;

            return sSQL;

        }

        /// <summary>
        /// 
        /// DELETE item from invoice
        /// </summary>
        /// <param name="sInvoiceID"></param>
        /// <returns></returns>

        public string DeleteLineItem (string sInvoiceID)

        {

            string sSQL = "DELETE From LineItems WHERE InvoiceNum =  " + sInvoiceID;

            return sSQL;

        }

        /// <summary>
        /// DELETE Invoice
        /// </summary>
        /// <param name="sInvoiceID"></param>
        /// <returns></returns>

        public string DeleteInvoice(string sInvoiceID)

        {

            string sSQL = "DELETE From Invoices WHERE InvoiceNum = " + sInvoiceID;

            return sSQL;

        }

        /// <summary>
        /// INSERT INTO LineItems(InvoiceNum, LineItemNum, ItemCode) Values(123, 1, 'AA')
        /// </summary>
        /// <param name="sInvoiceID"></param>
        /// <returns></returns>

        public string InsertIntoLineItems(string sInvoiceID, int LineItemNum, string ItemCode)

        {

            string sSQL = "INSERT INTO LineItems( InvoiceNum, LineItemNum, ItemCode) Values(" + sInvoiceID + ", " + LineItemNum + ", " + ItemCode + ")";

            return sSQL;

        }

        /// <summary>
        /// INSERT Invoice with cost
        /// </summary>
        /// <param name="sInvoiceID"></param>
        /// <returns></returns>

        public string NewInvoice(string sInvoiceID, double cost)

        {

            string sSQL = "INSERT INTO Invoices(InvoiceDate, TotalCost) Values(" + sInvoiceID + ", " + cost + ")";

            return sSQL;

        }

        /// <summary>
        /// SELECT Invoice from one sent
        /// </summary>
        /// <param name="sInvoiceID"></param>
        /// <returns></returns>

        public string SelectInvoice(string sInvoiceID)

        {

            string sSQL = "SELECT InvoiceNum, InvoiceDate, TotalCost FROM Invoices WHERE InvoiceNum = " + sInvoiceID;

            return sSQL;

        }

        /// <summary>
        /// select ItemCode, ItemDesc, Cost from ItemDesc
        /// </summary>
        /// <param name="sInvoiceID"></param>
        /// <returns></returns>


        public string SelectItemData()

        {

            string sSQL = "SELECT ItemCode, ItemDesc, Cost from ItemDesc";

            return sSQL;

        }

        /// <summary>
        /// SELECT LineItems.ItemCode, ItemDesc.ItemDesc, ItemDesc.Cost FROM LineItems, ItemDesc Where LineItems.ItemCode = ItemDesc.ItemCode And LineItems.InvoiceNum = 5000
        /// </summary>
        /// <param name="sInvoiceID"></param>
        /// <returns></returns>


        public string GetItemizedInvoices(string sInvoiceID)

        {

            string sSQL = "SELECT LineItems.ItemCode, ItemDesc.ItemDesc, ItemDesc.Cost FROM LineItems, ItemDesc Where LineItems.ItemCode = ItemDesc.ItemCode And LineItems.InvoiceNum = " + sInvoiceID;

            return sSQL;

        }










    }
}
