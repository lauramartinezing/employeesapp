using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal.Core
{
    class HourlySalaryContract : Contract
    {
        private int _salary;
        public HourlySalaryContract(int salary)
        {
            _salary = salary;
        }
        public override int GetcalculatedAnnualSalary()
        {
            return 120 * _salary * 12 ;
        }
    }
}
