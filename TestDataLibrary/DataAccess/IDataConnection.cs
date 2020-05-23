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
    }
}
