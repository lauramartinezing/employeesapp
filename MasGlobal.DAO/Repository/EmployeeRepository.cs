using MasGlobal.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace MasGlobal.DAO.Repository
{

    public class EmployeeRepository
    {
        static HttpClient client = new HttpClient();

        public List<Employee> GetEmployees()
        {
            try
            {
                return GetData();
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public Employee GetEmployeeById(int id)
        {
            return GetData().Where(x=>x.Id==id).FirstOrDefault();
        }

        private List<Employee> GetData()
        {
            return new List<Employee>()
            {
                new Employee(){
                    Id=1,
                    Name= "Juan",
                    Rol= new Rol()
                    {
                        Id=1,
                        Name= "Administrator",
                        Description=null
                    },
                    contractTypeName="HourlySalaryEmployee",
                    hourlySalary=60000,
                    monthlySalary=80000
                },
                new Employee(){
                     Id=2,
                    Name= "Sebastian",
                    Rol= new Rol()
                    {
                        Id=1,
                        Name= "Contractor",
                        Description=null
                    },
                    contractTypeName="MonthlySalaryEmployee",
                    hourlySalary=60000,
                    monthlySalary=80000
                },
            };
                }
    }
}
