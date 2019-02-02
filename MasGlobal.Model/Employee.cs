using System;

namespace MasGlobal.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Rol Rol { get; set; }
        public string contractTypeName { get; set; }
        public int hourlySalary { get; set; }
        public int monthlySalary { get; set; }
        public int annualSalary { get; set; }
    }
}
