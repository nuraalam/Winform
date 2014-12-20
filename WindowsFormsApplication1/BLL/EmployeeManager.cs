using System.Collections.Generic;
using System.Linq;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.UI
{
    internal class EmployeeManager
    {
        EmployeeGateway aGateway = new EmployeeGateway();
        public string SaveEmployee(Employee aEmployee)
        {
            if (aEmployee.ManageName!=null)
            {
                if (aEmployee.ManageName=="Korim")
                {
                    aEmployee.ManagerId = "1";
                }
                if (aEmployee.ManageName == "Rohim")
                {
                    aEmployee.ManagerId = "2";
                }              
            }
           
            aGateway.Save(aEmployee);
            return "Save Successfully!!";

        }

        public IEnumerable<Employee> ShowEmpoyeeBymanager(string manager)
        {

            List<Employee> employeeList=aGateway.GetAllEmployee();
            foreach (var employee in employeeList)
            {
                if (manager == "Korim")
                    
                    return  employeeList.Where(p => p.ManagerId == "1");
                if (manager == "Rorim")
                    return employeeList.Where(p => p.ManagerId == "2");
            }
            return employeeList;

        }
    }
}