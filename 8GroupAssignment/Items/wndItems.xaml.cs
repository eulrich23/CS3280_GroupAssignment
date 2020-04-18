using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for wndItems.xaml
    /// </summary>
    public partial class wndItems : Window
    {
        /// <summary>
        /// Class to access the database
        /// </summary>
        clsDataAccess clsData;
        /// <summary>
        /// List of Items for the DataGrid
        /// </summary>
        List<clsItem> clsItemList;
        /// <summary>
        /// clsItem used when adding a new item to window
        /// </summary>
        clsItem clsItem;
        /// <summary>
        /// class to hold all the SQL statements
        /// </summary>
        clsItemsSQL clsItemsSQL;

        /// <summary>
        /// Constructor for the Item window
        /// </summary>
        public wndItems()
        {
            try
            {
                InitializeComponent();

                clsData = new clsDataAccess();
                clsItemsSQL = new clsItemsSQL();


                LoadItemGrid();
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Event handler to hand errors and display where
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
        /// button to close the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
            }
            catch (System.Exception ex)
            {
                System.IO.File.AppendAllText(@"C:\Error.txt", Environment.NewLine + "HandleError Exception: " + ex.Message);
            }
        }

        /// <summary>
        /// Event handler for when delete button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Check to see if an item is selected and display corresponding message
                if (dgItemView.SelectedIndex >= 0)
                {
                    string invoices = clsItemsSQL.ItemInvoice(clsData, ((clsItem)dgItemView.SelectedItem).Code);
                    string sDeleteMessage;

                    //if item is contained in an invoice, prompt user for confirmation
                    if (invoices == "")
                    {
                        sDeleteMessage = ((clsItem)dgItemView.SelectedItem).Description +
                            " is not contained in any invoice.\nAre you sure you want to delete it?";
                    }
                    else
                    {
                        sDeleteMessage = ((clsItem)dgItemView.SelectedItem).Description +
                            " is contained in the following invoices : \n" + invoices +
                            "\n Are you sure you want to delete it?";
                    }

                    MessageBoxResult deleteResult = System.Windows.MessageBox.Show(sDeleteMessage, "Delete Confirmation", MessageBoxButton.OKCancel);

                    if (deleteResult == MessageBoxResult.OK)
                    {
                        clsItemsSQL.DeleteItem(clsData, ((clsItem)dgItemView.SelectedItem).Code);

                        LoadItemGrid();
                    }

                }
                else
                {
                    string sSelectMessage = "Please select an item to delete.";
                    System.Windows.MessageBox.Show(sSelectMessage, "Error");
                }
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// method to load and reload the ItemGrid
        /// </summary>
        private void LoadItemGrid()
        {
            try
            {
                //query database for new list
                clsItemList = clsItemsSQL.GetItems(clsData);
                foreach (var item in clsItemList)
                {
                    item.PropertyChanged += ItemPropertyChanged;
                }
                dgItemView.ItemsSource = clsItemList;
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// method for when a property is changed, updates the changed value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ItemPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            try
            {
                if (!(sender is clsItem)) return;
                var item = (clsItem)sender;

                switch (args.PropertyName)
                {
                    case "Code":

                        break;
                    case "Description":
                    case "Cost":
                        clsItemsSQL.Updateitem(clsData, item.Code, item.Cost, item.Description);
                        break;
                }
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// method for when Add item button is clicked, opens new window for more information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _8GroupAssignment.Items.wndNewItem wndNewItem = new wndNewItem(clsData);

                wndNewItem.ShowDialog();

                if (!wndNewItem.bItemAdded)
                {
                    return;
                }
                clsItem = new clsItem();
                clsItem.Code = wndNewItem.sCode;
                clsItem.Cost = wndNewItem.fCost;
                clsItem.Description = wndNewItem.sDescription;

                clsItemsSQL.InsertItem(clsData, clsItem.Code, clsItem.Cost, clsItem.Description);
                LoadItemGrid();
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
    }
}
