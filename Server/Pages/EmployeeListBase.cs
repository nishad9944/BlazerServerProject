using Microsoft.AspNetCore.Components;
using Web;

namespace Server.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> employeeLists { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadEmployee();
            return base.OnInitializedAsync();
        }

        private void LoadEmployee()
        {
            Employee e1 = new Employee()
            {
                EmployeeId = 1,
                FirstName = "Nishad",
                LastName="Lamsoge",
                DateOfBirth = new DateTime(1999,01,13),
                Email="nishadlamsoge@gmail.com",
                Gender=Gender.Male,
                Department = new Department() { DepartmentId=1,DepartmentName="IT"},
                PhotoPath="/images/image1"
            };
            Employee e2 = new Employee()
            {
                EmployeeId = 1,
                FirstName = "Nishad",
                LastName = "Lamsoge",
                DateOfBirth = new DateTime(1999, 01, 13),
                Email = "nishadlamsoge@gmail.com",
                Gender = Gender.Male,
                Department = new Department(){ DepartmentId = 1, DepartmentName = "IT" },
                PhotoPath = "/images/image1"
            };
            Employee e3 = new Employee()
            {
                EmployeeId = 1,
                FirstName = "Nishad",
                LastName = "Lamsoge",
                DateOfBirth = new DateTime(1999, 01, 13),
                Email = "nishadlamsoge@gmail.com",
                Gender = Gender.Male,
                Department = new Department() { DepartmentId = 1, DepartmentName = "IT" },
                PhotoPath = "/images/image1"
            };
            Employee e4 = new Employee()
            {
                EmployeeId = 1,
                FirstName = "Nishad",
                LastName = "Lamsoge",
                DateOfBirth = new DateTime(1999, 01, 13),
                Email = "nishadlamsoge@gmail.com",
                Gender = Gender.Male,
                Department = new Department() { DepartmentId = 1, DepartmentName = "IT" },
                PhotoPath = "/images/image1"
            };

            employeeLists = new List<Employee>() { e1 , e2 , e3, e4};
        }
    }
}
