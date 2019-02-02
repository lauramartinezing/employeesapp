using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MasG.App.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using MasGlobal.Model;

namespace MasG.App.Controllers
{
    public class HomeController : Controller
    {
        HttpClient client = new HttpClient();
        private string URL = "https://localhost:44355/";


        public IActionResult Index()
        {
            client.BaseAddress = new Uri(URL);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/employees").Result;
            List<Employee> dataObjects = response.Content.ReadAsAsync<IEnumerable<Employee>>().Result.ToList();

            return View(new EmployeesViewModel() { employeesList= dataObjects});
        }

        [HttpPost]
        public IActionResult Search(int id)
        {
            return View("Index", GetEmployees(id));
        }


        private EmployeesViewModel GetEmployees(int id)
        {
            client.BaseAddress = new Uri(URL);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (id==0)
            {
                HttpResponseMessage response = client.GetAsync("api/employees").Result;
                List<Employee> dataObjects = response.Content.ReadAsAsync<IEnumerable<Employee>>().Result.ToList();
                return new EmployeesViewModel() { employeesList = dataObjects };
            }
            else
            {
                HttpResponseMessage response = client.GetAsync("api/employees/" + id).Result;
                Employee dataObjects = response.Content.ReadAsAsync<Employee>().Result;
                return new EmployeesViewModel() { employeesList = new List<Employee>() { dataObjects } };
            }

        }
    }
}
