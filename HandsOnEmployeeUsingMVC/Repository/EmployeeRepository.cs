using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnEmployeeUsingMVC.Models;

namespace HandsOnEmployeeUsingMVC.Repository
{
    public class EmployeeRepository
    {
        public static List<Employee> list = new List<Employee>()
        {
            new Employee() { EmployeeId="27",Name="Ganesh",Designation="ProgramAnalyst",ProjectName=".net",Pwd="2727"} 
        };
        public EmployeeRepository()
        {

        }
        public void Add(Employee item)
        {
            list.Add(item);//Add user data into list
        }
        public Employee Validate(string Id, string pwd)
        {
            foreach (var item in list)
            {
                if (item.EmployeeId == Id && item.Pwd == pwd)
                {
                    return item;
                }
            }
            return null;
        }

    }
}
