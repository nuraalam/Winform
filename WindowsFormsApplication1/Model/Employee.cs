using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    class Employee
    {
        public int EmployeeId { set; get; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public string ManageName { get; set; }
        public string ManagerId { set; get; }

        public Employee(string employeeName, string designation,string managerName)
        {
           
            EmployeeName = employeeName;
            Designation = designation;
            ManageName = managerName;
        }

        public Employee()
        {
        }
    }
}
