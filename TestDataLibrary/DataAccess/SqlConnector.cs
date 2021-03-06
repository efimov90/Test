﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using TestDataLibrary.Models;

namespace TestDataLibrary.DataAccess
{
    /// <summary>
    /// Прослойка между базой данных и приложением, реализующая операции работы с базой
    /// </summary>
    class SqlConnector : IDataConnection
    {
        private const string connectionStringName = "TestDesktop.Properties.Settings.TestConnection";

        /// <summary>
        /// Создает строку в таблице адресов
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
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
                model.Id = (int)cmd.ExecuteScalar();
                return model;
            }
        }

        /// <summary>
        /// Обновляет строку в таблице адресов
        /// </summary>
        /// <param name="model"></param>
        public void UpdateAddress(AddressModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(connectionStringName)))
            {
                SqlCommand cmd = new SqlCommand("spAddresses_Update", connection as SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Id", model.Id));
                cmd.Parameters.Add(new SqlParameter("@EmployeeId", model.EmployeeId));
                cmd.Parameters.Add(new SqlParameter("@Country", model.Country));
                cmd.Parameters.Add(new SqlParameter("@Region", model.Region));
                cmd.Parameters.Add(new SqlParameter("@City", model.City));
                cmd.Parameters.Add(new SqlParameter("@StreetAddress", model.StreetAddress));
                cmd.Parameters.Add(new SqlParameter("@PostalCode", model.PostalCode));

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Запрашевает в базе строку адреса по идентификатору стотрудника
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public AddressModel GetAddressByEmployeeId(int employeeId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(connectionStringName)))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Address WHERE EmployeeId=@Id", connection as SqlConnection);
                cmd.Parameters.Add(new SqlParameter("@Id", employeeId));
                cmd.CommandType = CommandType.Text;
                
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();

                    return new AddressModel(
                        (int)reader["Id"],
                        (int)reader["EmployeeId"],
                        reader["Country"].ToString(),
                        reader["Region"].ToString(),
                        reader["City"].ToString(),
                        reader["StreetAddress"].ToString(),
                        reader["PostalCode"].ToString()
                        );
                }
            }
        }

        /// <summary>
        /// Удаляет строку адреса по идентификатору сотрудника
        /// </summary>
        /// <param name="employeeId"></param>
        public void DeleteAddressByEmployeeId(int employeeId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(connectionStringName)))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Address WHERE EmployeeId=@Id", connection as SqlConnection);
                cmd.Parameters.Add(new SqlParameter("@Id", employeeId));
                cmd.CommandType = CommandType.Text;

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Создает строку в таблице сотрудников
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
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
                model.Id = (int)cmd.ExecuteScalar();
                return model;
            }
        }


        /// <summary>
        /// Обновляет строку в таблице сотрудников
        /// </summary>
        /// <param name="model"></param>
        public void UpdateEmployee(EmployeeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(connectionStringName)))
            {
                SqlCommand cmd = new SqlCommand("spEmployees_Update", connection as SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Id", model.Id));
                cmd.Parameters.Add(new SqlParameter("@FirstName", model.FirstName));
                cmd.Parameters.Add(new SqlParameter("@MiddleName", model.MiddleName));
                cmd.Parameters.Add(new SqlParameter("@LastName", model.LastName));
                cmd.Parameters.Add(new SqlParameter("@DateOfBirth", model.DateOfBirth));
                cmd.Parameters.Add(new SqlParameter("@Department", model.Department));
                cmd.Parameters.Add(new SqlParameter("@About", model.About));

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Получает строку из таблицы сотрудников по идентификатору
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public EmployeeModel GetEmployee(int employeeId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(connectionStringName)))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE Id=@Id", connection as SqlConnection);
                cmd.Parameters.Add(new SqlParameter("@Id", employeeId));
                cmd.CommandType = CommandType.Text;

                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();

                    return new EmployeeModel(
                        (int)reader["Id"],
                        reader["FirstName"].ToString(),
                        reader["MiddleName"].ToString(),
                        reader["LastName"].ToString(),
                        DateTime.Parse(reader["DateOfBirth"].ToString()),
                        reader["Department"].ToString(),
                        reader["About"].ToString()
                        );
                }
            }
        }

        /// <summary>
        /// Удаляет строку из таблицы сотрудников по идентификатору
        /// </summary>
        /// <param name="employeeId"></param>
        public void DeleteEmployee(int employeeId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(connectionStringName)))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE Id=@Id", connection as SqlConnection);
                cmd.Parameters.Add(new SqlParameter("@Id", employeeId));
                cmd.CommandType = CommandType.Text;

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Получает весь список сотрудников в сокращенном виде
        /// </summary>
        /// <returns></returns>
        public List<FullEmployee> GetAllFullEmployees()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(connectionStringName)))
            {
                List<FullEmployee> listOfModels = new List<FullEmployee>();

                SqlCommand cmd = new SqlCommand("SELECT * FROM FullEmployee", connection as SqlConnection);
                cmd.CommandType = CommandType.Text;
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var t = reader["DateOfBirth"].ToString();
                        DateTime.Parse(reader["DateOfBirth"].ToString());

                        var e = new FullEmployee(
                            (int)reader["EmployeeId"],
                            reader["FirstName"].ToString(),
                            reader["MiddleName"].ToString(),
                            reader["LastName"].ToString(),
                            (DateTime)reader["DateOfBirth"],
                            reader["FullAddress"].ToString(),
                            reader["Department"].ToString(),
                            reader["About"].ToString());
                        listOfModels.Add(e);
                    }
                }

                return listOfModels;
            }
        }
    }
}
