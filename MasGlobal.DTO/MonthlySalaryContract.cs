using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal.Core
{
    class MonthlySalaryContract : Contract
    {
        private int _salary;
        public MonthlySalaryContract(int salary)
        {
            _salary = salary;
        }
        public override int GetcalculatedAnnualSalary()
        {
            return _salary * 12;
        }
    }
}
