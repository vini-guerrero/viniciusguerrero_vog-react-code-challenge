using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Contracts;
using VogCodeChallenge.Services;

namespace VogCodeChallenge.API.Controllers
{
    [ApiController]
    [Route("employees")]
    public class EmployeesController : Controller
    {
        /// <summary>
        /// FetchEmployeeDetails Class Reference
        /// </summary>
        private readonly IFetchEmployeeDetails _employeeDetails;

        /// <summary>
        /// Mapper Reference
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor Parameter
        /// </summary>
        /// <param name="fetchEmployeeDetails"></param>
        /// <param name="mapper"></param>
        public EmployeesController(IFetchEmployeeDetails fetchEmployeeDetails, IMapper mapper)
        {
            _employeeDetails = fetchEmployeeDetails;
            _mapper = mapper;
        }

        /// <summary>
        /// Action Handler For Employee List
        /// </summary>
        /// <returns>Employee List</returns>
        [HttpGet("")]
        public IActionResult GetAll()
        {
            var employeeDetails = _employeeDetails.GetAll();

            if(employeeDetails != null && employeeDetails.Count() > 0)
            {
                var result = _mapper.Map<List<Employee>>(employeeDetails);
                return Ok(result);
            }
            else
            {
                return NotFound();
            }            
        }

        /// <summary>
        /// Action Handler For Employee Based On Department Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Employee Of Department</returns>
        [HttpGet("department/{id}")]
        public IActionResult GetDepartmentById([FromRoute]string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                return NoContent();
            }
            else
            {
                var department = _employeeDetails.GetDepartmentByDepId(id);
                var result = department != null ? _mapper.Map<Department>(department) : null;
                if(result == null || String.IsNullOrEmpty(result.DepartmentId))
                {
                    return NotFound();
                }
                
                return Ok(result);
            }                
        }
    }
}
