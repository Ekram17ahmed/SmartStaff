using SmartStaff.DAL.DataBase;
using SmartStaff.DAL.Entities;
using SmartStaff.DAL.Repo.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStaff.DAL.Repo.Implementation
{
    
    
    public class EmployeeRepo : IEmployeeRepo
    {
        //context
        private readonly SmartStaffDbContext db;
        public EmployeeRepo()
        {
            db = new SmartStaffDbContext();
        }
        public bool Create(Employee employee)
        {
            throw new NotImplementedException();
        }

        public bool Delet(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
