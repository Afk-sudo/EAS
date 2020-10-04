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
    /// Логика взаимодействия для AdditionalEmployee.xaml
    /// </summary>
    public partial class AdditionalEmployee : Window
    {
        private BindingList<Employee> _employeesDataList;
        private Employee additedEmployee;
        private Adress employeeAdress;
        public AdditionalEmployee(BindingList<Employee> employesDataList)
        {
            InitializeComponent();
            _employeesDataList = employesDataList;
        }
        private void Label_Loaded(object sender, RoutedEventArgs e)
        {
            additedEmployee = new Employee();
            employeeAdress = new Adress();
            additedEmployee.EmployeeAdress = employeeAdress;    
            MaleButton.Checked += OnMaleButtonChecked;
            FemaleButton.Checked += OnFemaleButtonChecked;
            MaleButton.Unchecked += OnMaleButtonUnchecked;
            FemaleButton.Unchecked += OnFemaleButtonUnchecked;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Employee additedEmployee = WriteResivedData();            
                _employeesDataList.Add(additedEmployee);
                this.Close();
            }
            catch (Exception exception)
            {
                this.DataContext = additedEmployee;
                MessageBox.Show(exception.Message);
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

            Employee additedEmployee = new Employee(employeeName, employeePhone, employeeAdress, sex);
            return additedEmployee;
        }
    }
}
