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
        private List<FullEmployee> employees;
        public EmployeeManager()
        {
            InitializeComponent();
            var source = new BindingSource();
            employees = GlobalConfig.Connections[0].GetAllFullEmployees();
            source.DataSource = employees;
            GVEmployee.AutoGenerateColumns = false;

            GVEmployee.DataSource = source;
        }

        private void EmployeeManager_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            EmployeeEdit.Show();
        }
    }
}
