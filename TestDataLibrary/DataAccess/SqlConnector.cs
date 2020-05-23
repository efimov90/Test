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
        private const string connectionStringName = "TestDesktop.Properties.Settings.TestConnection";

        public AddressModel CreateAddress(AddressModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(connectionStringName)))
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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(connectionStringName)))
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

        public List<FullEmployee> GetAllFullEmployees()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(connectionStringName)))
            {
                List<FullEmployee> listOfModels = new List<FullEmployee>();

                SqlCommand cmd = new SqlCommand("FullEmployee", connection as SqlConnection);
                cmd.CommandType = CommandType.TableDirect;

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listOfModels.Add(new FullEmployee(
                            (int)reader["Id"],
                            (string)reader["FirstName"],
                            (string)reader["MiddleName"],
                            (string)reader["LastName"],
                            (DateTime)reader["DateOfBirth"],
                            (string)reader["FullAddress"],
                            (string)reader["Department"],
                            (string)reader["About"]));
                    }
                }

                return listOfModels;
            }
        }
    }
}
