using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using BusinessAccessLayer.Repository;
using DataTransferObject.ViewModel;

namespace UnitofWork_with_StoreP_Repo.Models
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class empController : ApiController
    {
        private IBusinessLayer _businessLayer = new BusinessLayer();
                

        /// <summary>
        /// Get employees list
        /// </summary>
        /// <returns> list of employees </returns>
        [HttpGet]
        [Route("api/getemployees")]
        public IEnumerable<EmployeeGetModel> GetEmployees()
        {
            return _businessLayer.GetEmployees();
        }

        
        /// <summary>
        /// Get specific employee data
        /// </summary>
        /// <param name="id"> employee id </param>
        /// <returns> data of specific employee </returns>
        [HttpGet]
        [Route("api/getemployee/{id}")]
        public IEnumerable<EmployeeGetModel> GetEmployee(int id)
        {
            return _businessLayer.GetEmployee(id);
        }


        /// <summary>
        /// Insert list of employees
        /// </summary>
        /// <param name="model"> to fetch employee list</param>
        [HttpPost]
        [Route("api/postemployee")]
        public void Post(List<EmployeeGetModel> model)
        {
            if (ModelState.IsValid)
            {
               _businessLayer.Create(model);
            }    
        }

        
        /// <summary>
        /// Update specific employee data
        /// </summary>
        /// <param name="id"> employee id</param>
        /// <param name="model"> to fetch specific employee data </param>
        [HttpPut]
        [Route("api/emp/putemployee/{id}")]
        public void Put(int id, EmployeeGetModel model)
        {
            if (ModelState.IsValid)
            {
                _businessLayer.Update(id, model);
            }
        }

        
        /// <summary>
        /// Delete specific employee
        /// </summary>
        /// <param name="id"> employee id </param>
        [HttpDelete]
        [Route("api/emp/delete/{id}")]
        public void Delete(int id)
        {
            _businessLayer.Delete(id);
        }
    }
}
