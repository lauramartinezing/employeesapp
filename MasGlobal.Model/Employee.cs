using System;

namespace MasGlobal.Model
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int roleId { get; set; }
        public string roleName { get; set; }
        public string roleDescription { get; set; }
        public string contractTypeName { get; set; }
        public double hourlySalary { get; set; }
        public double monthlySalary { get; set; }

        public double annualSalary { get; set; }
    }
}
