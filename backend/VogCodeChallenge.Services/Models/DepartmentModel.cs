using System.Collections.Generic;

namespace VogCodeChallenge.Services.Models
{
    /// <summary>
    /// Department Model Class
    /// </summary>
    public class DepartmentModel
    {
        /// <summary>
        /// Department ID Property 
        /// </summary>
        public string DepartmentId { get; set; }

        /// <summary>
        /// Department Name Property
        /// </summary>
        public string DepartmentName { get; set; }
                
        /// <summary>
        /// List of employee associated with a respective department Property 
        /// </summary>
        public IEnumerable<EmployeeModel> Employees { get; set; }
    }
}
