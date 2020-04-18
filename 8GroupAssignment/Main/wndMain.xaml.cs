using _8GroupAssignment.Main;

using System;
using System.Reflection;
using System.Windows;
namespace CS3280GroupProject.Main
{
    /// <summary>
    /// Interaction logic for wndMain.xaml
    /// </summary>
    public partial class wndMain : Window
    {

        /// <summary>
        /// Main Logic Object Declaration
        /// </summary>
        private clsMainLogic ML;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public wndMain()
        {
            try
            {
                InitializeComponent();
                ML = new clsMainLogic();

                ///Will need to create invoice object here to send as part of object to search window.
                
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void HandleError(string name1, string name2, string message)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// OnClick handler of the AddInvoice Button
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event object</param>
        private void AddInvoiceBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Make the other grids available
                InvoiceDetailGrid.Visibility = Visibility.Visible;
                NewInvoiceGrid.Visibility = Visibility.Visible;

                //Make style active for Panel
                Style st = (Style)this.FindResource("StackPanelActive");

                InvoiceBtnStack.Style = st;

                AddInvoiceBtn.IsEnabled = false;
                EditInvoiceBtn.IsEnabled = false;
                DeleteInvoiceBtn.IsEnabled = false;


                //Initialise ui elements
                ItemCmb.SelectedIndex = -1;
                QuantityBox.Text = "1";
                DateBox.Text = "";


            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// OnClick handler for the EditInvoice Button
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event object</param>
        private void EditInvoiceBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Toggle disabled status of various ui elements
                NewInvoiceGrid.Visibility = Visibility.Visible;
                ItemListMenu.IsEnabled = false;
                DateBox.IsEnabled = true;
                QuantityBox.IsEnabled = true;
                AddInvoiceBtn.IsEnabled = false;
                EditInvoiceBtn.IsEnabled = false;
                DeleteInvoiceBtn.IsEnabled = false;
                SaveInvoiceBtn.IsEnabled = true;
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Search Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        

            ///HERE WE WILL SEND AN INVOICE OJBECT TO SEARCH WINDOW

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Group_Project_Assignment.wndSearch wndSearch = new Group_Project_Assignment.wndSearch(this);
            wndSearch.Show();
        }

        private void ItemListMenu_Click(object sender, RoutedEventArgs e)
        {
            _8GroupAssignment.Items.wndItems wndItem = new _8GroupAssignment.Items.wndItems();
            wndItem.Show();
        }
    }
}
