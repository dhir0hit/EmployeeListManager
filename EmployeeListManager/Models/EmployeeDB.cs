using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeListManager.Models
{
    public class EmployeeDB
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeAge { get; set; }
        public string DeptID { get; set; }
        public string City { get; set; }
        public int yearsExp { get; set; }
        public Dept EmployeeDept { get; set; }
        public int EmployeeCompanyID { get; set; }
        public EmployeeCompany EmployeeCompanyName { get; set; }

        public EmployeeDB()
        {
            EmployeeDept = new Dept();
            EmployeeCompanyName = new EmployeeCompany();
        }
        public class Dept
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public Dept() { }
            public Dept(int id, string name)
            {
                ID = id;
                Name = name;
            }
        }
    }
    public class EmployeeCompany
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }
}