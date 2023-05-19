using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab4_1_.Composite;

namespace lab4_1_.Client
{
    public class DataContext
    {
        public Organization CreateDefaultOrganization()
        {
            var department1 = new Department
            {
                Code = "001",
                Name = "Department 1",
                Positions = new List<Position>
                {
                    new Position { Name = "Manager", Stakes = 1, Salary = 5000 },
                    new Position { Name = "Engineer", Stakes = 5, Salary = 3000 }
                },
                SubDepartments = new List<Department>
                {
                    new Department
                    {
                        Code = "001.1",
                        Name = "Subdepartment 1.1",
                        Positions = new List<Position>{
                            new Position { Name = "Assistant", Stakes = 3, Salary = 2000 }
                        }
                    }
                }
            };
            var department2 = new Department
            {
                Code = "002",
                Name = "Department 2",
                Positions = new List<Position>
                {
                    new Position { Name = "Manager", Stakes = 1, Salary = 5000 },
                    new Position { Name = "Analyst", Stakes = 2, Salary = 4000 }
                }
            };
            
            var organization = new Organization
            {
                Departments = new List<Department> { department1, department2 }
            };
            return organization;
        }
    }
}
