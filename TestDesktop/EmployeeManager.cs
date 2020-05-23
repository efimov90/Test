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
    public partial class EmployeeManager : Form
    {
        private EmployeeEdit EmployeeEdit = new EmployeeEdit();
        private List<FullEmployee> Employees;
        public EmployeeManager()
        {
            InitializeComponent();
            GVEmployee.AutoGenerateColumns = false;
            refreshEmployees();
        }

        private void EmployeeManager_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshEmployees();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            EmployeeEdit.EmptyForm();
            EmployeeEdit.ShowDialog();

            if (EmployeeEdit.DialogResult == DialogResult.OK)
            {
                refreshEmployees();
            }
        }

        private void refreshEmployees()
        {
            BindingSource DataBindingSource = new BindingSource();

            Employees = GlobalConfig.Connections[0].GetAllFullEmployees();
            DataBindingSource.DataSource = Employees;
            GVEmployee.DataSource = DataBindingSource;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var employeeId = GVEmployee.CurrentRow.Cells["Id"].Value;
            var employee = GlobalConfig.Connections[0].GetEmployee((int)employeeId);
            var address = GlobalConfig.Connections[0].GetAddresByEmployeeId((int)employeeId);

            EmployeeEdit.FillForm(employee, address);
            EmployeeEdit.ShowDialog();

            if (EmployeeEdit.DialogResult == DialogResult.OK)
            {
                refreshEmployees();
            }
        }
    }
}
