using System;
using System.Windows;
using System.Windows.Controls;
using System.Reflection;
//using namespace CS3280GroupProject.Main
//using namespace Group_Project_Assignment.Main.

namespace Group_Project_Assignment
{

    /// <summary>
    /// This window will be passed in the main window
    /// </summary>
    public partial class wndSearch : Window
    {
        /// <summary>
        /// Boolean that indicates whether an invoice has been selected
        /// </summary>
        public bool invoiceSelected = false;
        CS3280GroupProject.Main.wndMain parentWindow; 
        /// <summary>
        ///Constructor for the wndSearch Window 
        /// </summary>
        public wndSearch(CS3280GroupProject.Main.wndMain parent)
        {
            
            InitializeComponent();
            parentWindow = parent;
            clsDataAccess Data = new clsDataAccess();
            
           
            
        }
        /// <summary>
        /// Event Handler for the Invoice Number ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbInvoiceNumber_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                //This is the top level method so we want to handle the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
            finally
            {
                //This code will always execute
            }
        }
        /// <summary>
        /// Event Handler for the Invoice Date ComboBox that will update the datagrid appropriately
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbInvoiceDate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                //This is the top level method so we want to handle the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
            finally
            {
                //This code will always execute
            }
        }
        /// <summary>
        /// Event Handler for the Total Charge ComboBox that will update the datagrid appropriately
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTotalCharge_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                //This is the top level method so we want to handle the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
            finally
            {
                //This code will always execute
            }
        }
        /// <summary>
        /// onClick handler for the Select button that will return the selected invoiceID if one is selected. If not then nothing happens.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                
                this.Hide();
                parentWindow.Show();
            }
            catch (Exception ex)
            {
                //This is the top level method so we want to handle the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
            finally
            {
                //This code will always execute
            }
        }
        /// <summary>
        /// An onClick handler that clears the current selection for the Search Window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearSelection_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                //This is the top level method so we want to handle the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
            finally
            {
                //This code will always execute
            }
        }
        /// <summary>
        /// An onClick handler that hides the Search Window and returns to the Main Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                this.Hide();
                parentWindow.Show();
            }
            catch (Exception ex)
            {
                //This is the top level method so we want to handle the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
            finally
            {
                //This code will always execute
            }
        }
        /// <summary>
        /// An error handling method
        /// </summary>
        /// <param name="sClass"></param>
        /// <param name="sMethod"></param>
        /// <param name="sMessage"></param>
        private void HandleError(string sClass, string sMethod, string sMessage)
        {
            try
            {
                //Would write to a file or database here.
                MessageBox.Show(sClass + "." + sMethod + " -> " + sMessage);
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("C:\\Error.txt", Environment.NewLine +
                                             "HandleError Exception: " + ex.Message);
            }
        }
        /// <summary>
        /// A method that fills the combo boxes when the Search window is first loaded.
        /// </summary>
        private void FillComboBoxes()
        {
            try
            {
                //cmbInvoiceNumber.
            }
            catch (Exception ex)
            {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        /// <summary>
        /// An Event Handler that returns to the main window on exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wndSearchWindow_Closed(object sender, EventArgs e)
        {
            try
            {

                this.Hide();
                parentWindow.Show();
            }
            catch (Exception ex)
            {
                //This is the top level method so we want to handle the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
            finally
            {
                //This code will always execute
            }
        }
    }
}
