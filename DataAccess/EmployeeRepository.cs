using DataAccess.Services;
using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EmployeeRepository : IEmployeeRepository,IDisposable
    {
        private readonly AcademyTahlildadeContext db = new AcademyTahlildadeContext();

      

        public bool LoginEmp(string UserName, string Password)
        {
           bool exist = db.Employees.Any(X => X.UserName == UserName && X.Password == Password);    
            return exist;
        }
      

        public int AddNew(Employee emp)
        {
           db.Employees.Add(emp);
            db.SaveChanges();
            return emp.EmployeeID;
        }

        public List<Employee> GetAll()
        {
           return db.Employees.ToList();
        }

        public bool Delete(int EmployeeID)
        {
            bool Success = false;
            try
            {
                var emp = db.Employees.FirstOrDefault(x => x.EmployeeID == EmployeeID);
                db.Employees.Remove(emp);
                db.SaveChanges();
                Success = true;
            }
            catch (Exception ex)
            {
                Success = false;
            }
            return Success;
        }

        public bool Update(Employee newEmployee)
        {
            bool Success = false;
            try
            {
                var OldEmployee = db.Employees.FirstOrDefault(x => x.EmployeeID == newEmployee.EmployeeID);
                OldEmployee.UserName = newEmployee.UserName;
                OldEmployee.Password = newEmployee.Password;
                OldEmployee.FirstName = newEmployee.FirstName;
                OldEmployee.LastName = newEmployee.LastName;
                OldEmployee.Mobile = newEmployee.Mobile;
                db.SaveChanges();
                Success = true;
            }
            catch (Exception ex)
            {

            }
            return Success;
        }

        public Employee Get(int EmployeeID)
        {
            Employee emp = db.Employees.FirstOrDefault(x => x.EmployeeID== EmployeeID);
            return emp;
        }
        

        public Employee GetEmployeeByUserName(string UserName)
        {
           return db.Employees.FirstOrDefault(x => x.UserName == UserName);
        }
        

        public List<Employee> SearchEmployee(EmployeeSearchModel emp)
        {
            var q = from item in db.Employees select item;
            if (!string.IsNullOrEmpty(emp.LastName))
            {
                q = q.Where(x => x.LastName.StartsWith(emp.LastName));
            }
            if (!string.IsNullOrEmpty(emp.Mobile))
            {
                q = q.Where(x => x.Mobile.StartsWith(emp.Mobile));
            }

                return q.ToList();
        }

        public void Dispose()
        {
            this.db.Dispose();
        }
    }
}
