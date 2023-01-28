using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VogCodeChallenge.Data.Entities;

namespace VogCodeChallenge.Data
{
    public static class MockFile
    {
        /// <summary>
       /// Procedure  to create a mock data for departments
        /// </summary>
        /// <returns>list of department entity</returns>
        public static IList<DepartmentEntity> CreateDepartmentMockData()
        {
            var department = new List<DepartmentEntity>
            {
                new DepartmentEntity { DepartmentId = "1", DepartmentName = "Management"},
                new DepartmentEntity { DepartmentId = "2", DepartmentName = "Reception"},
                new DepartmentEntity { DepartmentId = "3", DepartmentName = "Sales"},
                new DepartmentEntity { DepartmentId = "4", DepartmentName = "Accounting"},
                new DepartmentEntity { DepartmentId = "5", DepartmentName = "Customer Service"},
                new DepartmentEntity { DepartmentId = "6", DepartmentName = "Quality Assurance"},
                new DepartmentEntity { DepartmentId = "7", DepartmentName = "Warehouse"},
            };

            return department;
        }

        /// <summary>
         /// Procedure  to create a mock data for employees
        
        /// </summary>
        /// <returns>list of employee entity</returns>
        public static IList<EmployeeEntity> CreateEmployeeMockData(string departmentId)
        {
            List<EmployeeEntity> employee = EmployeeMockData();

            return employee.Where(x => x.DepartmentId == departmentId).ToList();
        }

        /// <summary>
        ///  /// Procedure  to create a mock data for List of Employees
        /// </summary>
        /// <returns>List of Employees</returns>
        public static List<EmployeeEntity> EmployeeMockData()
        {
            return new List<EmployeeEntity>
            {
                new EmployeeEntity { EmployeeId = "1", DepartmentId = "1", FirstName = "Michael", LastName = "Scott", JobTitle="Regional Manager", Address="Scranton, Pennsylvania" },
                new EmployeeEntity { EmployeeId = "2", DepartmentId = "1", FirstName = "Jan", LastName = "Levinson", JobTitle="Vice President of Northeast Sales", Address="Scranton, Pennsylvania" },
                new EmployeeEntity { EmployeeId = "3", DepartmentId = "2", FirstName = "Pam", LastName = "Beesly", JobTitle="Receptionist", Address="Scranton, Pennsylvania" },
                new EmployeeEntity { EmployeeId = "4", DepartmentId = "3", FirstName = "Jim", LastName = "Halpert", JobTitle="Sales Representative", Address="Scranton, Pennsylvania" },
                new EmployeeEntity { EmployeeId = "5", DepartmentId = "3", FirstName = "Dwight", LastName = "Schrute", JobTitle="Assistant Regional Manager", Address="Scranton, Pennsylvania" },
                new EmployeeEntity { EmployeeId = "6", DepartmentId = "3", FirstName = "Stanley", LastName = "Hudson", JobTitle="Sales Representative", Address="Scranton, Pennsylvania" },
                new EmployeeEntity { EmployeeId = "7", DepartmentId = "3", FirstName = "Phyllis", LastName = "Vance", JobTitle="Sales Representative", Address="Scranton, Pennsylvania" },
                new EmployeeEntity { EmployeeId = "8", DepartmentId = "3", FirstName = "Andy", LastName = "Bernard", JobTitle="Sales Regional Director", Address="Scranton, Pennsylvania" },
                new EmployeeEntity { EmployeeId = "9", DepartmentId = "3", FirstName = "Meredith", LastName = "Palmer", JobTitle="Unknown", Address="Scranton, Pennsylvania" },
                new EmployeeEntity { EmployeeId = "10", DepartmentId = "4", FirstName = "Kevin", LastName = "Malone", JobTitle="Accountant", Address="Scranton, Pennsylvania" },
                new EmployeeEntity { EmployeeId = "11", DepartmentId = "4", FirstName = "Angela", LastName = "Martin", JobTitle="Accountant", Address="Scranton, Pennsylvania" },
                new EmployeeEntity { EmployeeId = "12", DepartmentId = "4", FirstName = "Oscar", LastName = "Martinez", JobTitle="Accountant", Address="Scranton, Pennsylvania" },
                new EmployeeEntity { EmployeeId = "13", DepartmentId = "5", FirstName = "Kelly", LastName = "Kapoor", JobTitle="Customer Service Representative", Address="Scranton, Pennsylvania" },
                new EmployeeEntity { EmployeeId = "14", DepartmentId = "6", FirstName = "Creed", LastName = "Bratton", JobTitle="Quality Assurance Representative", Address="Scranton, Pennsylvania" },
                new EmployeeEntity { EmployeeId = "15", DepartmentId = "7", FirstName = "Darryl", LastName = "Philbin", JobTitle="Warehouse Foreman", Address="Scranton, Pennsylvania" },
                new EmployeeEntity { EmployeeId = "16", DepartmentId = "7", FirstName = "Roy", LastName = "Anderson", JobTitle="Warehouse Dock Worker", Address="Scranton, Pennsylvania" },
                
            };
        }

        /// <summary>
       /// Retrieve process - Department detail for the supplied department ID
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns>Department details</returns>
        public static DepartmentEntity CreateDepartmentDataForGivenId(string departmentId)
        {
            var department = CreateDepartmentMockData();
            return department.Where(x => x.DepartmentId == departmentId).FirstOrDefault();
        }

    }
}
