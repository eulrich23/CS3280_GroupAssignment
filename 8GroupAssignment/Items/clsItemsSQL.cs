using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _8GroupAssignment.Items
{
    class clsItemsSQL
    {
        /// <summary>
        /// DataSet to hold values after SQL statements
        /// </summary>
        private DataSet ds;
        /// <summary>
        /// List of clsItems to hold values from DataSet
        /// </summary>
        private List<clsItem> ItemsList;
        /// <summary>
        /// String to hold the needed SQL statement
        /// </summary>
        private string sSQL;
        /// <summary>
        /// int for the return value of the nuber of results from a Query
        /// </summary>
        private int iRetVal;

        /// <summary>
        /// method to get a List of Items from the database
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public List<clsItem> GetItems(clsDataAccess db)
        {
            try
            {
                ItemsList = new List<clsItem>();
                sSQL = "select ItemCode, ItemDesc, Cost from ItemDesc";
                ds = db.ExecuteSQLStatement(sSQL, ref iRetVal);

                for(int i = 0; i < iRetVal; i++)
                {
                    clsItem Item = new clsItem();

                    Item.Code = (string)ds.Tables[0].Rows[i][0];
                    Item.Description = (string)ds.Tables[0].Rows[i][1];
                    Item.Cost =  float.Parse(ds.Tables[0].Rows[i][2].ToString());

                    ItemsList.Add(Item);
                }

                return ItemsList;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method to check if an item is contained in any invoice
        /// </summary>
        /// <param name="db"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public string ItemInvoice(clsDataAccess db, string code)
        {
            try
            {
                string sInvoices = "";
                sSQL = "select distinct(InvoiceNum) from LineItems where ItemCode = '"+ code +"'";
                ds = db.ExecuteSQLStatement(sSQL, ref iRetVal);

                for(int i = 0; i <  iRetVal; i++)
                {
                    sInvoices += string.Concat(ds.Tables[0].Rows[i][0].ToString());

                    if((i + 1) != iRetVal)
                        sInvoices = string.Concat(", ");

                }

                return sInvoices;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// method to update an item with the outlined variables
        /// </summary>
        /// <param name="db"></param>
        /// <param name="code"></param>
        /// <param name="cost"></param>
        /// <param name="description"></param>
        public void Updateitem(clsDataAccess db, string code, float cost, string description)
        {
            try
            {
                sSQL = "Update ItemDesc Set ItemDesc = '" + description + "', Cost = " + cost + " where ItemCode = '" + code + "'";
                db.ExecuteNonQuery(sSQL);

            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }


        /// <summary>
        /// method to execute an insert statement with the given variables
        /// </summary>
        /// <param name="db"></param>
        /// <param name="code"></param>
        /// <param name="cost"></param>
        /// <param name="description"></param>
        public void InsertItem(clsDataAccess db, string code, float cost, string description)
        {
            try
            {
                sSQL = "Insert into ItemDesc (ItemCode, ItemDesc, Cost) Values ('" + code + "', '" + description + "', " + cost + ")";
                db.ExecuteNonQuery(sSQL);
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// method to Delete an item with the given code from the database
        /// </summary>
        /// <param name="db"></param>
        /// <param name="code"></param>
        public void DeleteItem(clsDataAccess db, string code)
        {
            try
            {
                sSQL = "Delete from ItemDesc Where ItemCode = '" + code + "'";
                db.ExecuteNonQuery(sSQL);
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// method to check if an item exists with the given code
        /// </summary>
        /// <param name="db"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public int CheckItemCode(clsDataAccess db, string code)
        {
            try
            {
                sSQL = "select distinct(InvoiceNum) from LineItems where ItemCode = '" + code + "'";
                ds = db.ExecuteSQLStatement(sSQL, ref iRetVal);

                return iRetVal;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
    }
}
