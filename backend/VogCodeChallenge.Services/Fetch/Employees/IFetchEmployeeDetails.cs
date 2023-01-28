using System;
using System.Collections.Generic;
using System.Text;
using VogCodeChallenge.Services.Models;

namespace VogCodeChallenge.Services
{
    /// <summary>
    /// Retrieve Process - Employee Details Interface
    /// </summary>
    public interface IFetchEmployeeDetails
    {
        /// <summary>
        /// Retrieve Process - Employee Details
        /// </summary>
        /// <returns>Employee details</returns>
        IEnumerable<EmployeeModel> GetAll();

        /// <summary>
        /// Retrieve Process - list of all Employee details
        /// </summary>
        /// <returns>List of Employee details</returns>
        IList<EmployeeModel> ListAll();

        /// <summary>
        ///Action handler to get Department details
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns>Department Details</returns>
        DepartmentModel GetDepartmentByDepId(string departmentId);

    }
}