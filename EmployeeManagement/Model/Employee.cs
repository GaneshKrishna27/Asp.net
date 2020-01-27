using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Model
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "length can be maximum 10")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",ErrorMessage ="invalid mail")]
        [ValidateDomain(allowdomain: "cts.com")]
        public string Email { get; set; }
        public Dept Dept { get; set; }
        public Employee(int id, string name, string email, Dept dept)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Dept = dept;
        }
        public Employee()
        {

        }

    }
}