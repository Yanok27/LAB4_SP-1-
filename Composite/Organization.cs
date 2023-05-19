using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1_.Composite
{
    public class Organization:Component
    {
        public List<Department> Departments { get; set; }

        public void PrintDepartmentStructure(Department department, string indent = "")
        {
            Console.WriteLine($"{indent}{department.Name} ({department.Code})");

            foreach (var position in department.Positions)
                Console.WriteLine($"{indent} - {position.Name}");
            if (department.SubDepartments != null)
                foreach (var subDepartment in department.SubDepartments)
                    PrintDepartmentStructure(subDepartment, indent + "  ");
        }
        public override void Add(Component component)
        {
            if (component is Department)
                Departments.Add((Department)component);
        }

        public override void Remove(Component component)
        {
            if (component is Department)
                Departments.Remove((Department)component);
        }
    }
}
