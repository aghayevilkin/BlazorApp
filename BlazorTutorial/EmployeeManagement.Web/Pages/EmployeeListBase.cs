using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
        }

        public IEnumerable<Employee> Employees { get; set; }


        private void LoadEmployees()
        {

            System.Threading.Thread.Sleep(3000);

            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Ilkin",
                LastName = "Aghayev",
                Email = "Ilkinga@code.edu.az",
                DateOfBirth = new DateTime(2001,4,6),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "Baku"},
                PhotoPath = "Images/1.jpg"
            };

            Employee e2 = new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Quliyev",
                Email = "John@gmail.com",
                DateOfBirth = new DateTime(1995, 6, 8),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "Baku" },
                PhotoPath = "Images/2.jpg"
            };

            Employee e3 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Abbas",
                LastName = "Abbasov",
                Email = "Ilkinga@code.edu.az",
                DateOfBirth = new DateTime(1889, 5, 2),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "Baku" },
                PhotoPath = "Images/1.jpg"
            };


            Employees = new List<Employee> { e1, e2, e3 };

        }
    }
}
