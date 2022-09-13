﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MvcprctdbEntities : DbContext
    {
        public MvcprctdbEntities()
            : base("name=MvcprctdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int DeleteEmployee(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteEmployee", idParameter);
        }
    
        public virtual ObjectResult<GetEmployeeById_Result> GetEmployeeById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetEmployeeById_Result>("GetEmployeeById", idParameter);
        }
    
        public virtual ObjectResult<GetEmployees_Result> GetEmployees()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetEmployees_Result>("GetEmployees");
        }
    
        public virtual int InsertEmployees(string employeeName, string employeeSalary, string fatherName, string contact, string address)
        {
            var employeeNameParameter = employeeName != null ?
                new ObjectParameter("EmployeeName", employeeName) :
                new ObjectParameter("EmployeeName", typeof(string));
    
            var employeeSalaryParameter = employeeSalary != null ?
                new ObjectParameter("EmployeeSalary", employeeSalary) :
                new ObjectParameter("EmployeeSalary", typeof(string));
    
            var fatherNameParameter = fatherName != null ?
                new ObjectParameter("FatherName", fatherName) :
                new ObjectParameter("FatherName", typeof(string));
    
            var contactParameter = contact != null ?
                new ObjectParameter("Contact", contact) :
                new ObjectParameter("Contact", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertEmployees", employeeNameParameter, employeeSalaryParameter, fatherNameParameter, contactParameter, addressParameter);
        }
    
        public virtual int UpdateEmployee(Nullable<int> id, string employeeName, string employeeSalary, string fatherName, string contact, string address)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var employeeNameParameter = employeeName != null ?
                new ObjectParameter("EmployeeName", employeeName) :
                new ObjectParameter("EmployeeName", typeof(string));
    
            var employeeSalaryParameter = employeeSalary != null ?
                new ObjectParameter("EmployeeSalary", employeeSalary) :
                new ObjectParameter("EmployeeSalary", typeof(string));
    
            var fatherNameParameter = fatherName != null ?
                new ObjectParameter("FatherName", fatherName) :
                new ObjectParameter("FatherName", typeof(string));
    
            var contactParameter = contact != null ?
                new ObjectParameter("Contact", contact) :
                new ObjectParameter("Contact", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateEmployee", idParameter, employeeNameParameter, employeeSalaryParameter, fatherNameParameter, contactParameter, addressParameter);
        }
    
        public virtual int InsertBulkEmployees()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertBulkEmployees");
        }
    }
}