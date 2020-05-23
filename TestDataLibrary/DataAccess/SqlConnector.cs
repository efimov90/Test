using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using TestDataLibrary.Models;

namespace TestDataLibrary.DataAccess
{
    class SqlConnector : IDataConnection
    {
        public AddressModel CreateAddress(AddressModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("TestDesktop.Properties.Settings.TestConnection")))
            {
                
                SqlCommand cmd = new SqlCommand("spAddresses_Insert", connection as SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@EmployeeId", model.EmployeeId));
                cmd.Parameters.Add(new SqlParameter("@Country", model.Country));
                cmd.Parameters.Add(new SqlParameter("@Region", model.Region));
                cmd.Parameters.Add(new SqlParameter("@City", model.City));
                cmd.Parameters.Add(new SqlParameter("@StreetAddress", model.StreetAddress));
                cmd.Parameters.Add(new SqlParameter("@PostalCode", model.PostalCode));

                connection.Open();
                model.Id = (Int32)cmd.ExecuteScalar();
                return model;
            }
        }

        public EmployeeModel CreateEmployee(EmployeeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("TestDesktop.Properties.Settings.TestConnection")))
            {
                SqlCommand cmd = new SqlCommand("spEmployees_Insert", connection as SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@FirstName", model.FirstName));
                cmd.Parameters.Add(new SqlParameter("@MiddleName", model.MiddleName));
                cmd.Parameters.Add(new SqlParameter("@LastName", model.LastName));
                cmd.Parameters.Add(new SqlParameter("@DateOfBirth", model.DateOfBirth));
                cmd.Parameters.Add(new SqlParameter("@Department", model.Department));
                cmd.Parameters.Add(new SqlParameter("@About", model.About));

                connection.Open();
                model.Id = (Int32)cmd.ExecuteScalar();
                return model;
            }
        }
    }
}
