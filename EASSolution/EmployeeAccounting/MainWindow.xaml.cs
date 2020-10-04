using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EmployeeAccounting.Models;
using System.ComponentModel;
using EmployeeAccounting.Services;
using EmployeeAccounting.Pages;
namespace EmployeeAccounting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string PATH = $"{Environment.CurrentDirectory}\\employeeDataJson.json";
        private BindingList<Employee> _employeesDataList;
        private SaveAndLoad _saveAndLoad;
        private Window _aditionalEmployee;
        private int indexSelectedRow;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            _saveAndLoad = new SaveAndLoad(PATH);
            try
            {
                _employeesDataList = _saveAndLoad.LoadData();

            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                Close();
            }
            dataGrid.ItemsSource = _employeesDataList;
            _employeesDataList.ListChanged += EmployeDataListChanged;
            AddingButton.Click += OnClickAddingButton;
            DeleteEmployee.Click += OnClickDeleteEmployeeButton;
            DeleteEmployee.IsEnabled = false;
            EditingEmployee.Click += OnClickEditingEmployee;
            EditingEmployee.IsEnabled = false;
            dataGrid.Items.Refresh();

        }

        private void OnClickAddingButton(object sender, RoutedEventArgs e)
        {
            _aditionalEmployee = new AdditionalEmployee(_employeesDataList);
            _aditionalEmployee.ShowDialog();
            DeleteEmployee.IsEnabled = false;
            EditingEmployee.IsEnabled = false;
        }
        private void OnClickDeleteEmployeeButton(object sender, RoutedEventArgs e)
        {
            _employeesDataList.RemoveAt(indexSelectedRow);
            DeleteEmployee.IsEnabled = false;
            EditingEmployee.IsEnabled = false;

        }

        private void EmployeDataListChanged(object sender, ListChangedEventArgs eventArgs)
        {
            if (eventArgs.ListChangedType == ListChangedType.ItemAdded || eventArgs.ListChangedType == ListChangedType.ItemDeleted || eventArgs.ListChangedType == ListChangedType.ItemChanged)
            {
                try
                {
                    _saveAndLoad.SaveData(sender);
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    Close();
                }
            }
        }
        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            indexSelectedRow = dataGrid.SelectedIndex;
            DeleteEmployee.IsEnabled = true;
            EditingEmployee.IsEnabled = true;
        }

        private void OnClickEditingEmployee(object sender, RoutedEventArgs e)
        {
            Window editingWindow = new EditingEmployee(_employeesDataList, indexSelectedRow, dataGrid);
            editingWindow.ShowDialog();
            DeleteEmployee.IsEnabled = false;
            EditingEmployee.IsEnabled = false;
        }
    }
}