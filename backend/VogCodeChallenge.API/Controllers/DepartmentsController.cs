using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VogCodeChallenge.API.Contracts;
using VogCodeChallenge.Services;

namespace VogCodeChallenge.API.Controllers
{
    [ApiController]
    [Route("departments")]
    public class DepartmentsController : Controller
    {
        /// <summary>
        /// FetchDepartmentDetails Class Reference
        /// </summary>
        private readonly IFetchDepartmentDetails _departmentDetails;
        
        /// <summary>
        /// Mapper Reference
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor Parameter
        /// </summary>
        /// <param name="departmentDetails"></param>
        /// <param name="mapper"></param>
        public DepartmentsController(IFetchDepartmentDetails departmentDetails, IMapper mapper)
        {
            _departmentDetails = departmentDetails;
            _mapper = mapper;
        }

        /// <summary>
        /// Action Handler For Departments and Employee List
        /// </summary>
        /// <returns>Department List</returns>
        [HttpGet]
        public IActionResult DepartmentDetails()
        {
            var departmentDetails = _departmentDetails.GetAllDepartments();
            if(departmentDetails != null && departmentDetails.Count > 0)
            {
                var result = _mapper.Map<List<Department>>(departmentDetails);
                return Ok(result);
            }
            else
            {
                return NotFound();
            }            
        }
    }
}