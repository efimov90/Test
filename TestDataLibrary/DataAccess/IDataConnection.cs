using System;
using System.Collections.Generic;
using System.Text;
using TestDataLibrary.Models;

namespace TestDataLibrary.DataAccess
{
    public interface IDataConnection
    {
        EmployeeModel CreateEmployee(EmployeeModel employee);
        AddressModel CreateAddress(AddressModel address);
        List<FullEmployee> GetAllFullEmployees();
        EmployeeModel GetEmployee(int employeeId);
        AddressModel GetAddressByEmployeeId(int employeeId);
        void UpdateEmployee(EmployeeModel employee);
        void UpdateAddress(AddressModel address);
        void DeleteEmployee(int employeeId);
        void DeleteAddressByEmployeeId(int employeeId);
    }
}
