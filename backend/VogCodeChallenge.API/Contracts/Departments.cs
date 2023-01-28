using System.Collections.Generic;

namespace VogCodeChallenge.API.Contracts
{
    /// <summary>
    /// Custom Class Department Contract 
    /// </summary>
    public class Department
    {
        /// <summary>
        /// Department Unique Id Property
        /// </summary>
        public string DepartmentId { get; set; }

        /// <summary>
        /// Department Name Property
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// Employee List Per Department
        /// </summary>
        public IEnumerable<Employee> Employees { get; set; }

    }
}
