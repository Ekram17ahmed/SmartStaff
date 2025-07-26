using SmartStaff.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStaff.DAL.Entities
{
    public class Employee
    {
        public int Id { get; private set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; private set; }
        public int Age { get; private set; }
        public double Salary { get; private set; }
        public DateTime CreatedON { get; private set; }
        public string CreatedBy { get; private set; }
        public bool isDeleted { get; private set; }
        public DateTime? ModifiedON { get; private set; }
        //[ForeignKey("Departement")]
        //public int? DeptID { get; private set; }
        //public Departement? Departement { get; set; }
        public EmployeeType employeeType { get; private set; }
        
    }
}
