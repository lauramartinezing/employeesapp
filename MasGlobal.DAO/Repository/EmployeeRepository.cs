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

    public class EmployeeRepository : BaseRepository
    {
        public List<Employee> GetEmployees()
        {
            try
            {
                HttpResponseMessage response = ApiClient("Employees");
                List<Employee> dataObjects = response.Content.ReadAsAsync<IEnumerable<Employee>>().Result.ToList();

                return dataObjects;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        //This Method was implemented because  the Api does't have a Get by id  endpoint
        public Employee GetEmployeeById(int id)
        {
            try
            {
                Employee dataObjects = GetEmployees().Where(x=>x.id==id).FirstOrDefault();
                return dataObjects;
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
        
}
