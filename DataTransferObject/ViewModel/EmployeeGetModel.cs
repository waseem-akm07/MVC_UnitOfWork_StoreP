using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.ViewModel
{
    public class EmployeeGetModel
    {
        public int EmployeeId { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string EmployeeSalary { get; set; }
        public EmployeeDetails EmployeeDetails { get; set; }
    }
}
