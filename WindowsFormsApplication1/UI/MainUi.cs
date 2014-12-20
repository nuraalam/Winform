using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.UI;

namespace WindowsFormsApplication1
{
    public partial class MainUi : Form
    {
        public MainUi()
        {
            InitializeComponent();
        }

        private void employeeEntryButton_Click(object sender, EventArgs e)
        {
            EmployeeEntryUi aEmployeeEntryUi = new EmployeeEntryUi();
            aEmployeeEntryUi.ShowDialog();
        }

        private void showEmployeeButton_Click(object sender, EventArgs e)
        {
            ShowEmployeeUi aShowEmployeeUi=new ShowEmployeeUi();
            aShowEmployeeUi.ShowDialog();
        }
    }
}
