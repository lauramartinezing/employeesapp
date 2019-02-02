
using MasGlobal.DAO.Repository;
using MasGlobal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal.Core
{
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> GetEmployees()
        {
            
            EmployeeRepository repository = new EmployeeRepository();
            var listEmployees = repository.GetEmployees();
           
            return listEmployees;
        }
        public Employee GetEmployeeById(int id)
        {
            EmployeeRepository repository = new EmployeeRepository();
            var employee= repository.GetEmployeeById(id);
            
            return employee;
        }
    }
}
