using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface IEmployeeRepository
    {

        bool LoginEmp(string UserName, string Password);
        int AddNew(Employee emp);
        List<Employee> GetAll();
        bool Delete(int EmployeeID);
        bool Update (Employee newEmployee);
        Employee Get(int EmployeeID);
        Employee GetEmployeeByUserName(string UserName);

        List<Employee> SearchEmployee(EmployeeSearchModel emp);
    }
}
