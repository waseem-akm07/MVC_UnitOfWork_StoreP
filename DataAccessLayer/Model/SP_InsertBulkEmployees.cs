using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkExtras.EF5;
using System.Data;

namespace DataAccessLayer.Model
{
    [StoredProcedure("InsertBulkEmployees")]
    public class SP_InsertBulkEmployees
    {
        [StoredProcedureParameter(SqlDbType.Udt, ParameterName="bulkEmployee")]
        public List<UDT_EmployeeType> EmployeeTypes { get; set; }
    }
}
