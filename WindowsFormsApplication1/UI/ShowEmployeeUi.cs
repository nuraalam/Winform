using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.UI
{
    public partial class ShowEmployeeUi : Form
    {
        public ShowEmployeeUi()
        {
            InitializeComponent();
        }

        private void showEmployeeButton_Click(object sender, EventArgs e)
        {
            employeelistView.Items.Clear();
            EmployeeManager aEmployeeManager=new EmployeeManager();
            IEnumerable<Employee> employees=aEmployeeManager.ShowEmpoyeeBymanager(managerComboBox.Text);
            foreach (var employee in employees)
            {
                ListViewItem item = new ListViewItem(employee.EmployeeId.ToString());
                item.SubItems.Add(employee.EmployeeName);
                item.SubItems.Add(employee.Designation);
                item.SubItems.Add(employee.ManagerId.ToString());
                employeelistView.Items.Add(item);
            }
           
        }

        private void ShowEmployeeUi_Load(object sender, EventArgs e)
        {

        }
    }
}
