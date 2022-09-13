using DataTransferObject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Repository
{
    public interface IBusinessLayer
    {
        /// <summary>
        /// List of all employees
        /// </summary>
        /// <returns> List of all employees </returns>
        IEnumerable<EmployeeGetModel> GetEmployees();

        /// <summary>
        /// List of specific employee
        /// </summary>
        /// <param name="id"> Employee id </param>
        /// <returns> List of specific employee </returns>
        IEnumerable<EmployeeGetModel> GetEmployee(int id);

        /// <summary>
        /// Add new employee Record
        /// </summary>
        /// <param name="employeeModel"> to fetch employee record </param>
        void  Create(List<EmployeeGetModel> employeeModel);

        /// <summary>
        /// Update specific employee Record
        /// </summary>
        /// <param name="id"> employee id </param>
        /// <param name="employeeModel"> to fetch employee record </param>
        void Update(int id, EmployeeGetModel employeeModel);

        /// <summary>
        /// To delete employee record
        /// </summary>
        /// <param name="id"> employee id </param>
        void Delete(int id);


    }
}
