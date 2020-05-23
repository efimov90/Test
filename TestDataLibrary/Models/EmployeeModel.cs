using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataLibrary.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
        public string About { get; set; }

        public EmployeeModel(string FirstName, string MiddleName, string LastName, DateTime DateOfBirth, string Department, string About)
        {
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Department = Department;
            this.About = About;
        }
    }
}
