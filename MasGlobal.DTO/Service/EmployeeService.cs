
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
            ContractFactory contractFactory =new ConcreteContractFactory();
            EmployeeRepository repository = new EmployeeRepository();
            var listEmployees = repository.GetEmployees();
            foreach (var item in listEmployees)
            {
                item.annualSalary = contractFactory.GetContract(item.contractTypeName, item.hourlySalary,item.monthlySalary).GetcalculatedAnnualSalary();
            }
            return listEmployees;
        }
        public Employee GetEmployeeById(int id)
        {
            ContractFactory contractFactory = new ConcreteContractFactory();
            EmployeeRepository repository = new EmployeeRepository();
            var employee= repository.GetEmployeeById(id);
            employee.annualSalary = contractFactory.GetContract(employee.contractTypeName, employee.hourlySalary, employee.monthlySalary).GetcalculatedAnnualSalary();

            return employee;
        }
    }
}
