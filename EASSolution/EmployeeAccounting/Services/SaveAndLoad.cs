using EmployeeAccounting.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace EmployeeAccounting.Services
{
    class SaveAndLoad
    {
        private readonly string PATH;
        
        public BindingList<Employee> LoadData()
        {
            var fileExists = File.Exists(PATH);
            if(fileExists == false)
            {
                File.Create(PATH);
                return new BindingList<Employee>();
            }
            using (var reader = File.OpenText(PATH))
            {
                var fileText = reader.ReadToEnd();  
                return JsonConvert.DeserializeObject<BindingList<Employee>>(fileText);
            }
        }
        public void SaveData(object  employeeDataList)
        {
            using (StreamWriter writer = File.CreateText(PATH))
            {
                string output = JsonConvert.SerializeObject(employeeDataList);
                writer.Write(output);
            }
        }
        public SaveAndLoad(string path)
        {
            PATH = path;
        }

    }
}
