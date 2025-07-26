using SmartStaff.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStaff.DAL.Repo.Abstraction
{
    public interface IEmployeeRepo
    {
        bool Create(Employee employee);
        Employee GetById(int id);
        List<Employee> GetAll();
        bool Delet(int id);
        bool Update(Employee employee);
    }
}
