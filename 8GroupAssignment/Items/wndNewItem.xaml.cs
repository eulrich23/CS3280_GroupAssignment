using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _8GroupAssignment.Items
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class wndNewItem : Window
    {
        /// <summary>
        /// class to hold the SQL statements
        /// </summary>
        clsItemsSQL clsItemsSQL;
        /// <summary>
        /// class to hold access to the database
        /// </summary>
        clsDataAccess clsData;
        /// <summary>
        /// string to hold the input code
        /// </summary>
        public string sCode;
        /// <summary>
        /// string to hold the input description
        /// </summary>
        public string sDescription;
        /// <summary>
        /// float to hold the input cost
        /// </summary>
        public float fCost;
        /// <summary>
        /// bool to know if an item was added or not
        /// </summary>
        public bool bItemAdded;

        /// <summary>
        /// constructor for the New Item window
        /// </summary>
        /// <param name="db"></param>
        public wndNewItem(clsDataAccess db)
        {
            try
            {
                InitializeComponent();

                clsItemsSQL = new clsItemsSQL();
                clsData = db;
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// method to handle Errors that have risen
        /// </summary>
        /// <param name="sClass"></param>
        /// <param name="sMethod"></param>
        /// <param name="sMessage"></param>
        private void HandleError(string sClass, string sMethod, string sMessage)
        {
            try
            {
                MessageBox.Show(sClass + "." + sMethod + " -> " + sMessage);
            }
            catch (System.Exception ex)
            {
                System.IO.File.AppendAllText(@"C:\Error.txt", Environment.NewLine + "HandleError Exception: " + ex.Message);
            }
        }
        
        /// <summary>
        /// Event handler for cancel button, closes New Item window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bItemAdded = false;
                this.Hide();
            }
            catch (System.Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
            this.Hide();
        }

        /// <summary>
        /// Event handler for the Save button, verifies input then moves info to class variables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Make sure all fields have been entered in
                if (tbCode.Text == "" || tbCost.Text == "" || tbDescription.Text == "")
                {
                    lblError.Content = "Please enter in a value for all fields.";
                    lblError2.Content = "";
                    return;
                }

                //Make sure Code has not been taken
                if (clsItemsSQL.CheckItemCode(clsData, tbCode.Text) > 0)
                {
                    lblError.Content = "The selected Code is already taken.";
                    lblError2.Content = "Please choose another Code.";
                    return;
                }

                //Move text to class variables
                sCode = tbCode.Text;
                fCost = float.Parse(tbCost.Text);
                sDescription = tbDescription.Text;
                bItemAdded = true;

                this.Hide();
            }
            catch (System.Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Event handler for the Cost textBox, limits input to number keys, decimals, and few other funcitonal keys
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbCost_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //Allow numbers and decimals
                if (!((e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || e.Key == Key.Decimal ||e.Key == Key.OemPeriod || (e.Key >= Key.D0 && e.Key <= Key.D9)))
                {
                    //allow back, delete, tab and enter keys
                    if (!(e.Key == Key.Back || e.Key == Key.Delete || e.Key == Key.Tab || e.Key == Key.Enter))
                    {
                        //all others out
                        e.Handled = true;
                    }
                }
            }
            catch (System.Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
    }
}
