using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab4_1_.Composite;

namespace lab4_1_.Client
{
    public class Reader
    {
        public Department ReadDepartment()
        {
            var department = new Department();

            Console.WriteLine("Enter code:");
            department.Code = Console.ReadLine();

            Console.WriteLine("Enter name:");
            department.Name = Console.ReadLine();

            char cont = 'n';
            Console.WriteLine("Want to add positions? Enter y/n");
            cont = Console.ReadLine()[0];
            department.Positions = new List<Position>();
            while (cont == 'y')
            {
                department.Positions.Add(ReadPosition());
                Console.WriteLine("Want to add more positions? Enter y/n");
                cont = Console.ReadLine()[0];
            }

            Console.WriteLine("Want to add subdepartments? Enter y/n");
            cont = Console.ReadLine()[0];
            while (cont == 'y')
            {
                department.SubDepartments.Add(ReadDepartment());
                Console.WriteLine("Want to add more subdepartments? Enter y/n");
                cont = Console.ReadLine()[0];
            }

            return department;
        }

        public Position ReadPosition()
        {
            var position = new Position();
            Console.WriteLine("Enter name:");
            position.Name = Console.ReadLine();
            Console.WriteLine("Enter stakes:");
            position.Stakes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter salary");
            position.Salary = Convert.ToDecimal(Console.ReadLine());
            return position;
        }
    }

}
