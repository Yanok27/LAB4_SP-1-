using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab4_1_.Composite;

namespace lab4_1_.Client
{
    public class Menu:IMenu
    {
        private Organization _organization;
        public Menu()
        {
            _organization = new Organization();
        }
        public void AddComponent(Component component) => _organization.Add(component);

        public void AddComponentByCode(string code, Component component) => _organization.Departments.First(x => x.Code == code).Add(component);

        public void FillDefaultData() => _organization = new DataContext().CreateDefaultOrganization();

        public void RemoveDepartmentByCode(string code) => _organization.Remove(_organization.Departments.First(x => x.Code == code));

        public void RemovePositionInDepartmentByName(string code, string name) => _organization.Departments.First(x => x.Code == code).Positions
                .Remove(_organization.Departments.First(x => x.Code == code).Positions.First(x => x.Name == name));

        public void RemoveSubDepartmentInDepartmentByCode(string code, string subcode) =>
            _organization.Departments.First(x => x.Code == code).SubDepartments
                .Remove(_organization.Departments.First(x => x.Code == code).SubDepartments.First(x => x.Code == subcode));

        public void ShowMenu()
        {
            Console.WriteLine("1 - Заповнити iнформацiю за замовчуванням\n" +
                "2 - Виведення штатного розкладу та iєрархії пiдроздiлiв\n" +
                "3 - Додати новий пiдроздiл\n" +
                "4 - Додати пiдлеглий пiдроздiл за кодом пiдроздiлу\n" +
                "5 - Додати посаду за кодом пiдроздiлу\n" +
                "6 - Видалити пiдроздiл за кодом\n" +
                "7 - Видилити пiдлеглий пiдроздiл за кодами\n" +
                "8 - Видалити позицiю за iм'ям та кодом пiдроздiлу\n" +
                "0 - Завершити роботу");
        }

        public void ShowStaffSchedule()
        {
            foreach (var department in _organization.Departments)
            {
                Console.WriteLine($"Department: {department.Name} ({department.Code})");
                Console.WriteLine($"Total Staff: {department.GetTotalStaff()}");
                Console.WriteLine($"Total Salary: {department.GetTotalSalary()}");

                Console.WriteLine("Positions:");
                foreach (var position in department.Positions)
                {
                    Console.WriteLine($"- {position.Name}: {position.Stakes} Stakes, Salary: {position.Salary}");
                }

                Console.WriteLine("Subdepartments:");
                _organization.PrintDepartmentStructure(department);

                Console.WriteLine();
            }
        }
    }

}
