using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EmployeeAccounting.Models
{
    public class Adress: IDataErrorInfo
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string Home { get; set; }
        public int Apartment { get; set; }

        public string Value
        {
            get
            {
                return $"{City}, {Street}, {Home}, {Apartment}";
            }
        }

        public string Error => null;

        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch(columnName)
                {
                    case "City":
                        if (string.IsNullOrEmpty(City))
                        {
                            error = "City cannot be empty";
                        }
                        break;
                    case "Street":
                        if (string.IsNullOrEmpty(Street))
                        {
                            error = "Street cannot be empty";
                        }
                        break;
                    case "Home":
                        if (string.IsNullOrEmpty(Home))
                        {
                            error = "Home cannot be empty";
                        }
                        break;
                    case "Apartment":
                        if (Apartment <= 0)
                        {
                            error = "The apartment number cannot be less or equal to 0";
                        }
                        break;
                }
                return error;
            }
        }

        public Adress(string city, string street, string home, int apartment)
        {
            City = city;
            Street = street;
            Home = home;
            Apartment = apartment;
        }
        public Adress(){ }
       
    }
}
