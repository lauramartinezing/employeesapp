using MasGlobal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal.Core
{
    public partial interface IEmployeeService
    {
        List<Employee> GetEmployees();

        Employee GetEmployeeById(int id);
    }
}
