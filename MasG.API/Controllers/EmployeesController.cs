using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasGlobal.Core;
using MasGlobal.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MasG.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public List<Employee> Get()
        {
            IEmployeeService services = new EmployeeService();
            return services.GetEmployees();
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            IEmployeeService services = new EmployeeService();
            return services.GetEmployeeById(id);

        }
    }
}