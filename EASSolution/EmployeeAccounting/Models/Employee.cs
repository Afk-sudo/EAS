using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmployeeAccounting.Models
{
    public class Employee : INotifyPropertyChanged, IDataErrorInfo
    {
        public string Name 
        {
            get => _name;
            set
            {
                if (_name == value)
                    return;
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        private string _name;
        public long Phone 
        {
            get => _phone;
            set
            {
                if (_phone == value)
                    return;
                _phone = value;
                OnPropertyChanged("Phone");
            }
        }
        private long _phone;

        public Adress EmployeeAdress {
            get => _employeeAdress;
            set
            {
                _employeeAdress = value;
                OnPropertyChanged("Adress");
            }

        }
        private Adress _employeeAdress;
        public string Gender { get; set; }

        public string Error => null;

        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch(columnName)
                {
                    case "Name":
                        if (string.IsNullOrWhiteSpace(Name))
                        {
                            error = "Name cannot be empty";
                        }
                        break;
                    case "Phone":
                        if(Phone.ToString().Length < 11)
                        {
                            error = "This signature does not look like a phone number";
                        }
                        break;
                    case "Gender":
                        break;
                }
                return error;
            }
        }

        public Employee(string name, long phone,Adress adress, string gender)
        {
            Name = name;
            _employeeAdress = adress;
            Phone = phone;
            Gender = gender;
        }
        public Employee() { }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }       
    }
}
