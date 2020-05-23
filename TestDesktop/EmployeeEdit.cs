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
        public EmployeeEdit()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
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
                
                employee = db.CreateEmployee(employee);

                address.EmployeeId = employee.Id;

                address = db.CreateAddress(address);
                
            }
        }

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
