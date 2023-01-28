using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VogCodeChallenge.Data.Entities
{
    /// <summary>
    /// Employee Entity  - Property for Employee Entity Class
    /// </summary>
    public class EmployeeEntity
    {
        /// <summary>
        ///Employee ID - Property for Employee ID Class
        /// </summary>
        [Key]
        public string EmployeeId { get; set; }

        /// <summary>
        /// Employee First Name - Property for Employee First Name Class
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        ///  Employee Last Name - Property for Employee Last Name Class
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        ///  Employee Job Title - Property for Employee Job Title Class
        /// </summary>
        public string JobTitle { get; set; }

        /// <summary>
        ///  Employee Adress - Property for Employee Adress Class
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        ///  Department ID - Property for Division unique adress
        /// </summary>
        public string DepartmentId { get; set; }
    }
}
