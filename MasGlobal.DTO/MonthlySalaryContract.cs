using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal.Core
{
    class MonthlySalaryContract : Contract
    {
        private double _salary;
        public MonthlySalaryContract(double salary)
        {
            _salary = salary;
        }
        public override double GetcalculatedAnnualSalary()
        {
            return _salary * 12;
        }
    }
}
