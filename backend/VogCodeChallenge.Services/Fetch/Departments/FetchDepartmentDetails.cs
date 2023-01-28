using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using VogCodeChallenge.Services.Models;
using VogCodeChallenge.Data.Repository;

namespace VogCodeChallenge.Services
{
    /// <summary>
    /// Fetch Department Details class
    /// </summary>
    public class FetchDepartmentDetails : IFetchDepartmentDetails
    {
        /// <summary>
        ///  Department repository - Private Section 
        /// </summary>
        private readonly IDepEmpRepository _departmentRepository;
        
        /// <summary>
        /// Mapper - Private Section
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        ///  Constructor Parameter 
        /// </summary>
        /// <param name="departmentRepository"></param>
        /// <param name="mapper"></param>
        public FetchDepartmentDetails(IDepEmpRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Retrieve Process -  List of  Departments model
        /// </summary>
        /// <returns>List of Department model</returns>
        public IList<DepartmentModel> GetAllDepartments()
        {
            var departmentDetails = new List<DepartmentModel>();
            
            // Get List of all the Departments
            var department = _departmentRepository.GetAllDepartments();
            
            if(department != null)
            {
                departmentDetails = _mapper.Map<List<DepartmentModel>>(department);

                // Retrieve Employee details for department
                foreach (DepartmentModel dep in departmentDetails)
                {
                    var employeeDetails = _departmentRepository.GetAllEmployeeDetailsByDepId(dep.DepartmentId);
                    var result = employeeDetails != null ? _mapper.Map<List<EmployeeModel>>(employeeDetails) : null;
                    dep.Employees = result;
                }
            }           

            return departmentDetails;
        }
    }
}