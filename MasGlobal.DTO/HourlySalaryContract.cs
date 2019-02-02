using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal.Core
{
    class HourlySalaryContract : Contract
    {
        private double _salary;
        public HourlySalaryContract(double salary)
        {
            _salary = salary;
        }
        public override double GetcalculatedAnnualSalary()
        {
            return 120 * _salary * 12 ;
        }
    }
}
