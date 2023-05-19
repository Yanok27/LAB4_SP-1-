using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab4_1_.Composite;

namespace lab4_1_.Client
{
    public interface IMenu
    {
        public void ShowMenu();
        public void FillDefaultData();
        public void ShowStaffSchedule();
        public void RemoveDepartmentByCode(string code);
        public void RemovePositionInDepartmentByName(string code, string name);
        public void RemoveSubDepartmentInDepartmentByCode(string code, string subcode);
        public void AddComponent(Component component);
        public void AddComponentByCode(string code, Component component);
    }
}
