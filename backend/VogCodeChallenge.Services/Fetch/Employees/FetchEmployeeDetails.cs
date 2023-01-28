using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VogCodeChallenge.Services.Models;
using VogCodeChallenge.Data.Entities;
using VogCodeChallenge.Data.Repository;

namespace VogCodeChallenge.Services
{
    /// <summary>
    /// Retrieve Process - Employee Details Class
    /// </summary>
    public class FetchEmployeeDetails : IFetchEmployeeDetails
    {
        /// <summary>
        /// Repository - Private Section 
        /// </summary>
        private readonly IDepEmpRepository _depEmpRepository;

        /// <summary>
        /// Mapper- Private Section 
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor Parameter 
        /// </summary>
        /// <param name="departmentRepository"></param>
        /// <param name="mapper"></param>
        public FetchEmployeeDetails(IDepEmpRepository departmentRepository, IMapper mapper)
        {
            _depEmpRepository = departmentRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Retrieve Process - for Employee Details
        /// </summary>
        /// <returns>Employee details</returns>
        public IEnumerable<EmployeeModel> GetAll()
        {
            return GetEmployeeDetails();
        }

        /// <summary>
        /// Retrieve Process - list of Employee details
        /// </summary>
        /// <returns>List of Employee details</returns>
        public IList<EmployeeModel> ListAll()
        {
            return GetEmployeeDetails().ToList();
        }

        /// <summary>
        /// Retrieve Process - get Department details 
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns>Department Details</returns>
        public DepartmentModel GetDepartmentByDepId(string departmentId)
        {
            //Get the Department detail
            var department = _depEmpRepository.GetDepartmentByDepId(departmentId);
            var depMapping = new DepartmentModel();

            if (department != null)
            {
                //Get Employee detail for the relevant department
                var employeeDetails = _depEmpRepository.GetAllEmployeeDetailsByDepId(department.DepartmentId);
                var empMapping = employeeDetails != null ? _mapper.Map<List<EmployeeModel>>(employeeDetails) : null;

                depMapping = _mapper.Map<DepartmentModel>(department);
                depMapping.Employees = empMapping;
            }
            
            return depMapping;                        
        }

        /// <summary>
        /// Action handler to get list of Employee details 
        /// </summary>
        /// <returns>list of Employee details</returns>
        private IEnumerable<EmployeeModel> GetEmployeeDetails()
        {
            var employee = _depEmpRepository.GetAllEmployees();
            var empMapping = employee != null ? _mapper.Map<IEnumerable<EmployeeModel>>(employee) : null;
            return empMapping;
        }
        
    }
}
