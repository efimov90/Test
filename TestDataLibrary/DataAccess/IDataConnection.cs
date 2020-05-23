using System;
using System.Collections.Generic;
using System.Text;
using TestDataLibrary.Models;

namespace TestDataLibrary.DataAccess
{
    /// <summary>
    /// Интерфейс обеспечивающий возможность подключения к приложению других прослоек между приложением и данными
    /// </summary>
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
