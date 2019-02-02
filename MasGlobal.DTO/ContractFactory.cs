using MasGlobal.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal.Core
{
    
    public abstract class ContractFactory
    {
        public abstract Contract GetContract(string contractTypeName, int hourlySalary, int monthlySalary);
    }

    public class ConcreteContractFactory : ContractFactory
    {
        public override Contract GetContract(string contractTypeName, int hourlySalary, int monthlySalary)
        {
            switch (contractTypeName)
            {
                case "MonthlySalaryEmployee":
                    return new MonthlySalaryContract(monthlySalary);
                case "HourlySalaryEmployee":
                    return new HourlySalaryContract(hourlySalary);
                default:
                    throw new ApplicationException(string.Format("Contract '{0}' cannot be created", contractTypeName));
            }
        }

    }
}
