using DataAccess.Services;
using DomainModel.Model;
using DomainModel.VeiwModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RegistrationRepository : IRegistrationRepository, IDisposable
    {
       private readonly AcademyTahlildadeContext db = new AcademyTahlildadeContext();

       
        
        public int RegisterationSabteName(Registration o)
        {
            db.Registrations.Add(o);
            db.SaveChanges();
            return o.RegistrationID;
        }
        public Registration Get(int RegistrationID)
        {
            return db.Registrations.FirstOrDefault(x => x.RegistrationID == RegistrationID);
        }

        public int RegistrationPayment(Payment re)
        {
           db.Payments.Add(re); 
            db.SaveChanges();
            return re.PayementID;
        }
        public List<DomainModel.VeiwModel.RegistrationDetails> GetListRegistrationDetails()
        {


            var q = from register in db.Registrations
                    join course in db.Courses
                    on register.CourseID equals course.CourseID
                    join student in db.Students
                    on register.StudentID equals student.StudentID
                    join employe in db.Employees
                    on register.EmployeeID equals employe.EmployeeID
                    select new DomainModel.VeiwModel.RegistrationDetails
                    {
                        RegistrationID = register.RegistrationID,
                        RegistrationDate = register.RegistrationDate,
                        CourseName = course.CourseName,
                        StudentFullInfo = student.FirstName + " " + student.LastName,
                        UserName = employe.UserName,
                        Tuition=course.Tuition,
                        TotalPayment= register.TotalPayment,
                        Description=register.Description,
                        Tuitionn= register.Tuitionn,

                    };
            return q.ToList();
        }
        public void RemoverItemFromPayment(int PaymentID)
        {
            var od = db.Payments.FirstOrDefault(x => x.PayementID == PaymentID);
            db.Payments.Remove(od);
            db.SaveChanges();
        }

        public void Delete(int RegisterId)
        {
            db.Registrations.Remove(db.Registrations.FirstOrDefault(x=>x.RegistrationID == RegisterId));
            db.SaveChanges();
        }
        public bool Update(Registration newreg)
        {
            bool success = false;
            try
            {
                var oldregister = db.Registrations.FirstOrDefault(x => x.RegistrationID == newreg.RegistrationID);
                oldregister.TotalPayment = newreg.TotalPayment;
                oldregister.RegistrationDate = newreg.RegistrationDate;
                oldregister.Tuitionn = newreg.Tuitionn;
                oldregister.Description = newreg.Description;
                oldregister.CourseID= newreg.CourseID;
                oldregister.StudentID= newreg.StudentID;

                
                db.SaveChanges();
                success = true;

            }
            catch (Exception ex)
            {

            }
            return success;
        }

       // public List<paymentlist> GetPaymentbyRegisterid()
      //  {
             //return db.Payments.Where(x => x.RegisterationID == registra);
          //  var q = from register in db.Registrations
           //         join payment in db.Payments
          //           on register.PaymentID equals payment.PayementID
              //       { 
            //    RegistrationName=
            //          };
      //  }
        public void Dispose()
        {
           this.db.Dispose();
        }

    }
}
