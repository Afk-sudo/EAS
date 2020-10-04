using EmployeeAccounting.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EmployeeAccounting.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditingEmployee.xaml
    /// </summary>
    public partial class EditingEmployee : Window
    {
        private BindingList<Employee> _employesDataList;
        private int _indexEditedEmployee;
        private DataGrid _dataGrid;
        public EditingEmployee(BindingList<Employee> employesDataList, int indexEditedEmployee, DataGrid dataGrid)
        {
            InitializeComponent();
            _employesDataList = employesDataList;
            _indexEditedEmployee = indexEditedEmployee;
            _dataGrid = dataGrid;
        }

        private void OnClickConfirmEditingButton(object sender, RoutedEventArgs eventArgs)
        {
            try
            {
                Employee editableEmployee = WriteResivedData();
                _employesDataList[_indexEditedEmployee] = editableEmployee;
                _dataGrid.Items.Refresh();
                this.Close();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void OnClickCancleEditingButton(object sender, RoutedEventArgs eventArgs)
        {
            this.Close();
        }
        private void Window_Loaded(object sender, RoutedEventArgs eventArgs)
        {
            Employee editedEmployee = _employesDataList[_indexEditedEmployee];
            this.DataContext = editedEmployee;
            SetUpFieldsSwapedValues(editedEmployee);
            ConfirmEditing.Click += OnClickConfirmEditingButton;
            CancleEditing.Click += OnClickCancleEditingButton;
            MaleButton.Checked += OnMaleButtonChecked;
            FemaleButton.Checked += OnFemaleButtonChecked;
            MaleButton.Unchecked += OnMaleButtonUnchecked;
            FemaleButton.Unchecked += OnFemaleButtonUnchecked;
        }
        private void OnTextBoxValidationError(object sender, ValidationErrorEventArgs eventArgs)
        {
            ConfirmEditing.IsEnabled = false;
        }
        private void SetUpFieldsSwapedValues(Employee editedEmployee)
        {

            if(editedEmployee.Gender == "Male")
            {
                MaleButton.IsChecked = true;
                FemaleButton.IsChecked = false;
            }
            else
            {
                MaleButton.IsChecked = false;
                FemaleButton.IsChecked = true;
            }
        }
        private void OnMaleButtonChecked(object sender, RoutedEventArgs e)
        {
            FemaleButton.IsChecked = false;
        }
        private void OnFemaleButtonChecked(object sender, RoutedEventArgs e)
        {
            MaleButton.IsChecked = false;
        }
        private void OnMaleButtonUnchecked(object sender, RoutedEventArgs e)
        {
            FemaleButton.IsChecked = true;
        }
        private void OnFemaleButtonUnchecked(object sender, RoutedEventArgs e)
        {
            MaleButton.IsChecked = true;
        }
        private Employee WriteResivedData()
        {
            if (String.IsNullOrEmpty(EmployeeName.Text) || String.IsNullOrEmpty(EmployeePhone.Text) || EmployeePhone.Text.Length < 11 || String.IsNullOrEmpty(EmployeeCity.Text) || String.IsNullOrEmpty(EmployeeStreet.Text) || String.IsNullOrEmpty(EmployeeHome.Text) || String.IsNullOrEmpty(EmployeeApartmet.Text))
            {
                throw new Exception("Данные введены некорректно, попробуйте еще раз");
            }
            string employeeName = EmployeeName.Text;
            long employeePhone = long.Parse(EmployeePhone.Text);
            Adress employeeAdress = new Adress(EmployeeCity.Text, EmployeeStreet.Text, EmployeeHome.Text, int.Parse(EmployeeApartmet.Text));
            string sex;
            if (MaleButton.IsChecked == true)
                sex = "Male";
            else
                sex = "Female";

            Employee editableEmployee = new Employee(employeeName, employeePhone, employeeAdress, sex);
            return editableEmployee;
        }
    }
}
