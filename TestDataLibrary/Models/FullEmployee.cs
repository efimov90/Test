using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataLibrary.Models
{
    public class FullEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FullAddress { get; set; }
        public string Department { get; set; }
        public string About { get; set; }

        public FullEmployee(int Id, string FirstName, string MiddleName, string LastName, DateTime DateOfBirth, string FullAddress, string Department, string About)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.FullAddress = FullAddress;
            this.Department = Department;
            this.About = About;
        }
    }
}
