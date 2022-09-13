using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkExtras.EF5;

namespace DataAccessLayer.Model
{
    [UserDefinedTableType("EmployeeType")]
    public class UDT_EmployeeType
    {
        [UserDefinedTableTypeColumn(1)]
        public string EmployeeName { get; set; }

        [UserDefinedTableTypeColumn(2)]
        public string EmployeeSalary { get; set; }

        [UserDefinedTableTypeColumn(3)]
        public string FatherName { get; set; }

        [UserDefinedTableTypeColumn(4)]
        public string Contact { get; set; }

        [UserDefinedTableTypeColumn(5)]
        public string Address { get; set; }

    }
}
