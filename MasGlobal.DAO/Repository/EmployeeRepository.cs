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

    public class EmployeeRepository: BaseRepository
    {
        static HttpClient client = new HttpClient();
        private const string URL = "http://masglobaltestapi.azurewebsites.net/";
        private string urlParameters = "api/Employees";

        public List<Employee> GetEmployees()
        {
            try
            {
                  // Blocking call! Program will wait here until a response is received or a timeout occurs.
                var dataObjects = response.Content.ReadAsAsync<IEnumerable<Employee>>().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
                foreach (var d in dataObjects)
                {
                    Console.WriteLine("{0}", d.name);
                }
                return GetData();
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public Employee GetEmployeeById(int id)
        {
            return GetData().Where(x => x.id == id).FirstOrDefault();
        }

        private List<Employee> GetData()
        {
            return new List<Employee>()
            {
                new Employee(){
                    id=1,
                    name= "Juan",
                    roleId=1,
                    roleName= "Administrator",
                    roleDescription=null,
                    contractTypeName="HourlySalaryEmployee",
                    hourlySalary=60000,
                    monthlySalary=80000
                },
                new Employee(){
                    id=2,
                    name= "Sebastian",
                    roleId =1,
                    roleName= "Contractor",
                    roleDescription=null,
                    contractTypeName="MonthlySalaryEmployee",
                    hourlySalary=60000,
                    monthlySalary=80000
                },
            };
        }
    }
}
