using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1_.Composite
{
    public class Department:Component
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public List<Position> Positions { get; set; }
        public List<Department> SubDepartments { get; set; }
        public override void Add(Component component)
        {
            if (component is Position)
                Positions.Add((Position)component);
            else if (component is Department)
                SubDepartments.Add((Department)component);
        }

        public override void Remove(Component component)
        {
            if (component is Position)
                Positions.Remove((Position)component);
            else if (component is Department)
                SubDepartments.Remove((Department)component);
        }

        public int GetTotalStaff()
        {
            int totalStaff = Positions.Sum(p => p.Stakes);
            if (SubDepartments != null)
                foreach (var subDepartment in SubDepartments)
                {
                    totalStaff += subDepartment.GetTotalStaff();
                }
            return totalStaff;
        }

        public decimal GetTotalSalary()
        {
            decimal totalSalary = Positions.Sum(p => p.Salary * p.Stakes);
            if (SubDepartments != null)
                foreach (var subDepartment in SubDepartments)
                {
                    totalSalary += subDepartment.GetTotalSalary();
                }
            return totalSalary;
        }
    }
}
