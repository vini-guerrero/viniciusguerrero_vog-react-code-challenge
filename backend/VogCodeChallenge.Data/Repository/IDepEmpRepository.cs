using System.Collections.Generic;
using VogCodeChallenge.Data.Entities;

namespace VogCodeChallenge.Data.Repository
{
    /// <summary>
    /// Data Repository - Property for Employee Repository Interface
    /// </summary>
    public interface IDepEmpRepository
    {
        /// <summary>
        ///Retrieve process -  Details of Departments
        /// </summary>
        /// <returns>List of Depatments</returns>
        IList<DepartmentEntity> GetAllDepartments();

        /// <summary>
        /// Retrieve process -  List of Employee for provided Department
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns>List of Employees</returns>
        IList<EmployeeEntity> GetAllEmployeeDetailsByDepId(string departmentId);

        /// <summary>
        /// Retrieve process -  List o all  Employees 
        /// </summary>
        /// <returns>List of Employees</returns>
        IEnumerable<EmployeeEntity> GetAllEmployees();

        /// <summary>
         /// Retrieve process -  Department detail by Id
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns>Department Details</returns>
        DepartmentEntity GetDepartmentByDepId(string departmentId);

    }
}