using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VogCodeChallenge.Data.Entities
{
    /// <summary>
    /// Department - Entity Class
    /// </summary>
    public class DepartmentEntity
    {
        /// <summary>
        /// Department ID - Property for Department unique address
        /// </summary>
        [Key]
        public string DepartmentId { get; set; }

        /// <summary>
        /// Department Name - Property for Division Name
        /// </summary>
        public string DepartmentName { get; set; }       
                
    }
}
