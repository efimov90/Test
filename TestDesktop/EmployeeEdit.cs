using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDataLibrary;
using TestDataLibrary.DataAccess;
using TestDataLibrary.Models;

namespace TestDesktop
{
    public partial class EmployeeEdit : Form
    {
        // Идентификаторы записей в источнике данных
        private int EmployeeId = 0;
        private int AddressId = 0;

        public EmployeeEdit()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Кнопка подтверждения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                // Создание сотрудника и адреса на основе данных формы
                EmployeeModel employee = new EmployeeModel(
                                        TBFirstName.Text,
                                        TBMiddleName.Text,
                                        TBLastName.Text,
                                        dtpDateOfBirth.Value,
                                        TBDapartment.Text,
                                        TBAbout.Text);

                AddressModel address = new AddressModel(
                        TBCountry.Text,
                        TBRegion.Text,
                        TBCity.Text,
                        TBStreetAddress.Text,
                        TBPostalCode.Text
                        );

                IDataConnection db = GlobalConfig.Connections[0];

                if ((this.EmployeeId > 0) && (this.AddressId > 0))
                {
                    employee.Id = this.EmployeeId;
                    address.Id = this.AddressId;
                    address.EmployeeId = this.EmployeeId;

                    db.UpdateEmployee(employee);
                    db.UpdateAddress(address);
                }
                else
                {
                    employee = db.CreateEmployee(employee);

                    address.EmployeeId = employee.Id;

                    db.CreateAddress(address);
                }
                
            }
        }

        public void FillForm(EmployeeModel employee, AddressModel address)
        {
            // Имя и фамилия в заголовке
            this.Text = employee.FirstName + employee.LastName;

            // Заполнение идентификаторов
            this.EmployeeId = employee.Id;
            this.AddressId = address.Id;

            // Заполнение полей сотрудника
            TBFirstName.Text = employee.FirstName;
            TBMiddleName.Text = employee.MiddleName;
            TBLastName.Text = employee.LastName;
            dtpDateOfBirth.Value = employee.DateOfBirth;
            TBDapartment.Text = employee.Department;
            TBAbout.Text = employee.About;

            // Заполнение полей адреса
            TBCountry.Text = address.Country;
            TBRegion.Text = address.Region;
            TBCity.Text = address.City;
            TBStreetAddress.Text = address.StreetAddress;
            TBPostalCode.Text = address.PostalCode;
        }

        public void EmptyForm()
        {
            // Стандартный текст
            this.ResetText();

            // Очистка идентификаторов
            this.EmployeeId = 0;
            this.AddressId = 0;

            // Очистка полей сотрудника
            TBFirstName.Text =
            TBMiddleName.Text =
            TBLastName.Text = "";
            dtpDateOfBirth.Value = DateTime.Today;
            TBDapartment.Text =
            TBAbout.Text = "";

            // Очистка полей адреса
            TBCountry.Text =
            TBRegion.Text =
            TBCity.Text =
            TBStreetAddress.Text =
            TBPostalCode.Text = "";
        }

        /// <summary>
        /// Валидация данных формы
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {
            bool output = true;

            if (TBPostalCode.Text.Length > 10)
            {
                output = false;
            }

            return output;
        }
    }
}
