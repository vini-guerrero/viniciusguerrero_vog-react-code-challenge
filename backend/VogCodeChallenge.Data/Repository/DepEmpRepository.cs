using System.Collections.Generic;
using System.Linq;
using VogCodeChallenge.Data.Entities;

namespace VogCodeChallenge.Data.Repository
{
    /// <summary>
    ///Data  Repository - Property for Employee Repository class
    /// </summary>
    public class DepEmpRepository : IDepEmpRepository
    {
        /// <summary>
        ///  Data Context - Private Section 
        /// </summary>
        private readonly DataContext _dataContext;

        /// <summary>
        ///  Constructor Param
        /// </summary>
        /// <param name="dataContext"></param>
        public DepEmpRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        /// <summary>
        /// 
        /// Retrieve process -  List of Departments
        /// </summary>
        /// <returns>List of Depatments</returns>
        public IList<DepartmentEntity> GetAllDepartments()
        {            
            return MockFile.CreateDepartmentMockData();
        }

        /// <summary>
        /// Retrieve process - List of Employees
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns>List of Employees</returns>
        public IList<EmployeeEntity> GetAllEmployeeDetailsByDepId(string departmentId)
        {
            return MockFile.CreateEmployeeMockData(departmentId);
        }
          
        /// <summary>
        /// Retrieve process - List of all Employee
        /// </summary>
        /// <returns>list of Employee</returns>
        public IEnumerable<EmployeeEntity> GetAllEmployees()
        {
            return MockFile.EmployeeMockData();
        }   

        /// <summary>
        /// Retrieve process - Department Details
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns>Department details</returns>
        public DepartmentEntity GetDepartmentByDepId(string departmentId)
        {
            return MockFile.CreateDepartmentDataForGivenId(departmentId);
        }
    }
}
