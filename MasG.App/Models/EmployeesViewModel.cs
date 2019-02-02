using MasGlobal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasG.App.Models
{
    public class EmployeesViewModel
    {
        public int id { get; set; }
        public List<Employee> employeesList { get; set; }
    }
}
