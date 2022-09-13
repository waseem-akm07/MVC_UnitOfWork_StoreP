using System;
using System.Collections.Generic;
using System.Linq;
using EntityFrameworkExtras.EF5;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject.ViewModel;
using DataAccessLayer.Model;

namespace BusinessAccessLayer.Repository
{
    public class BusinessLayer : IBusinessLayer
    {
        
        private MvcprctdbEntities _entities = new MvcprctdbEntities();


        /// <summary>
        /// Get employees list
        /// </summary>
        /// <returns> list of employees </returns>
        public IEnumerable<EmployeeGetModel> GetEmployees()
        {
            IEnumerable<EmployeeGetModel> data = new List<EmployeeGetModel>();

            
            data = from result in _entities.GetEmployees().ToList()
                   select new EmployeeGetModel
                   {
                       EmployeeId = result.EmployeeId,
                       EmployeeName = result.EmployeeName,
                       EmployeeSalary = result.EmployeeSalary,
                       EmployeeDetails = new EmployeeDetails
                       {
                           DetailId = result.DetailId,
                           FatherName = result.FatherName,
                           Contact = result.Contact,
                           Address = result.Address
                       }
                   };

            return data;

            // throw new NotImplementedException();
        }


        /// <summary>
        /// Get specific employee data
        /// </summary>
        /// <param name="id"> employee id </param>
        /// <returns> data of specific employee </returns>
        public IEnumerable<EmployeeGetModel> GetEmployee(int id)
        {
            IEnumerable<EmployeeGetModel> data = new List<EmployeeGetModel>();

            data = from result in _entities.GetEmployeeById(id).ToList()
                   select new EmployeeGetModel
                   {
                       EmployeeId = result.EmployeeId,
                       EmployeeName = result.EmployeeName,
                       EmployeeSalary = result.EmployeeSalary,
                       EmployeeDetails = new EmployeeDetails
                       {
                           DetailId = result.DetailId,
                           FatherName = result.FatherName,
                           Contact = result.Contact,
                           Address = result.Address
                       }
                   };

            return data;
        }


        /// <summary>
        /// Insert list of employees
        /// </summary>
        /// <param name="model"> to fetch employee list</param>
        public void Create(List<EmployeeGetModel> model)
        {
            //User-define-Table type model class list
            List<UDT_EmployeeType> listData = new List<UDT_EmployeeType>();

            foreach(var emp in model)
            {
                //add Bulk data into UDT list
                listData.Add(new UDT_EmployeeType
                {
                    EmployeeName = emp.EmployeeName,
                    EmployeeSalary = emp.EmployeeSalary,
                    FatherName = emp.EmployeeDetails.FatherName,
                    Contact = emp.EmployeeDetails.Contact,
                    Address = emp.EmployeeDetails.Address
                });
            }

            //pass UDT list to insertBulkEmployee Sp parameter
            var procedure = new SP_InsertBulkEmployees()
            {
                EmployeeTypes = listData
            };

            //Now finally execute insertBulkEmployee Store procedure
            _entities.Database.ExecuteStoredProcedure(procedure);            
        }


        /// <summary>
        /// Update specific employee data
        /// </summary>
        /// <param name="id"> employee id</param>
        /// <param name="model"> to fetch specific employee data </param>
        public void Update(int id, EmployeeGetModel model)
        {
            _entities.UpdateEmployee(id, model.EmployeeName, model.EmployeeSalary, model.EmployeeDetails.FatherName,
                model.EmployeeDetails.Contact, model.EmployeeDetails.Address);
        }


        /// <summary>
        /// Delete specific employee
        /// </summary>
        /// <param name="id"> employee id </param>
        public void Delete(int id)
        {
            _entities.DeleteEmployee(id);
        }
    }
}
