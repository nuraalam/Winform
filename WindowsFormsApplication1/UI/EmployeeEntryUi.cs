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
    public partial class EmployeeEntryUi : Form
    {
        public EmployeeEntryUi()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            EmployeeManager aManager=new EmployeeManager();
            Employee aEmployee=new Employee(emplyeeNameTextBox.Text,designationTextBox.Text, managerComboBox.Text);
            string msg = aManager.SaveEmployee(aEmployee);
            MessageBox.Show(msg);
        }
    }
}
