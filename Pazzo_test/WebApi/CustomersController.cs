using Pazzo_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;

namespace Pazzo_test.WebApi
{
    public class CustomersController : ApiController 
    {
        private NorthwindEntities db = new NorthwindEntities();

        /// <summary>
        /// 取得顧客資料
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Customers/getCustomers")]
        public System.Web.Http.Results.JsonResult<CustomersViewModel>  getCustomers()
        {
            var employees = db.Customers.Select(m => new CustomersViewModel.Customers()
            {
                Address = m.Address,
                City = m.City,
                CompanyName = m.CompanyName,
                ContactName = m.ContactName,
                Country = m.Country,
                CustomerID = m.CustomerID,
                Phone = m.Phone
            }).ToList();

            CustomersViewModel result = new CustomersViewModel() { items = employees, total = 50 };

            //var CustomersList = db.Customers.AsParallel().ToList();
            //var result = Mapper.Map<CustomersViewModel>(CustomersList);

            //result.total = 50;
            return Json(new CustomersViewModel() { items = employees, total = 50 });
        }

        /// <summary>
        /// 查詢單筆顧客資料
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Customers/CustomerByID")]
        public CustomersViewModel.Customers CustomerByID(string ID)
        {
            var employees = db.Customers.Where(p =>p.CustomerID == ID).Select(m => new CustomersViewModel.Customers()
            {
                Address = m.Address,
                City = m.City,
                CompanyName = m.CompanyName,
                ContactName = m.ContactName,
                Country = m.Country,
                CustomerID = m.CustomerID,
                Phone = m.Phone
            }).FirstOrDefault();

            return employees;
        }
    }
}
