using System;
using MasGlobal.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasGlobal.Test
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void GetEmployeesTestMethod()
        {
            EmployeeService service = new EmployeeService();
            var list= service.GetEmployees();
            Assert.AreEqual(2, list.Count);
        }
        [TestMethod]
        public void NameEmployeeTestMethod()
        {
            EmployeeService service = new EmployeeService();
            var employee = service.GetEmployeeById(1);
            Assert.AreEqual("Juan", employee.name);
        }
        [TestMethod]
        public void Salary1EmployeeTestMethod()
        {
            EmployeeService service = new EmployeeService();
            var employee = service.GetEmployeeById(2);
            Assert.AreEqual(960000, employee.annualSalary);
        }
        [TestMethod]
        public void Salary2EmployeeTestMethod()
        {
            EmployeeService service = new EmployeeService();
            var employee = service.GetEmployeeById(1);
            Assert.AreEqual(86400000, employee.annualSalary);
        }
    }
}
