using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab4_1_.Client;

namespace lab4_1_.Startup
{
    public class ProgramStartup:IStartable
    {
        public void Start()
        {
            IMenu menuManager = new Menu();

            while (true)
            {
                menuManager.ShowMenu();
                var index = Convert.ToInt32(Console.ReadLine());
                switch (index)
                {
                    case 1:
                        menuManager.FillDefaultData();
                        break;
                    case 2:
                        menuManager.ShowStaffSchedule();
                        break;
                    case 3:
                        menuManager.AddComponent(new Reader().ReadDepartment());
                        break;
                    case 4:
                        Console.WriteLine("Enter department code");
                        var code = Console.ReadLine();
                        menuManager.AddComponentByCode(code, new Reader().ReadDepartment());
                        break;
                    case 5:
                        Console.WriteLine("Enter department code");
                        code = Console.ReadLine();
                        menuManager.AddComponentByCode(code, new Reader().ReadPosition());
                        break;
                    case 6:
                        Console.WriteLine("Enter department code");
                        code = Console.ReadLine();
                        menuManager.RemoveDepartmentByCode(code);
                        break;
                    case 7:
                        Console.WriteLine("Enter department code");
                        code = Console.ReadLine();
                        Console.WriteLine("Enter subdepartment code");
                        var subcode = Console.ReadLine();
                        menuManager.RemoveSubDepartmentInDepartmentByCode(code, subcode);
                        break;
                    case 8:
                        Console.WriteLine("Enter department code");
                        code = Console.ReadLine();
                        Console.WriteLine("Enter position name code");
                        subcode = Console.ReadLine();
                        menuManager.RemovePositionInDepartmentByName(code, subcode);
                        break;
                    case 0:
                        return;
                    default:
                        break;
                }
            }

        }
    }
}
