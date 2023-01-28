using System.Collections.Generic;
using VogCodeChallenge.Services.Models;

namespace VogCodeChallenge.Services
{
    /// <summary>
    /// Retrieve process - Department Details Interface
    /// </summary>
    public interface IFetchDepartmentDetails
    {
        /// <summary>
        /// Retrieve Process- list of Departments model 
        /// </summary>
        /// <returns>List of Department model</returns>
        IList<DepartmentModel> GetAllDepartments();

    }
}