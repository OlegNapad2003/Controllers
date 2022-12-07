using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.Identity.Order.Extensions.Msal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Models;
using MVC.Repository;

namespace MVC.Controllers
{
    public class OrderController : Controller
    {
        [HttpPut]
        public Order Create(Order Order)
        {
            Storage.OrderStorage.Create(Order);
            return Storage.OrderStorage.Read(Order.Id);
        }

        [HttpGet]
        public Order Read(int OrderId)
        {
            return Storage.OrderStorage.Read(OrderId);
        }

        [HttpPatch]
        public Order Update(int OrderId, Order newOrder)
        {
            return Storage.OrderStorage.Update(OrderId, newOrder);
        }

        [HttpDelete]
        public bool Delete(int OrderId)
        {
            return Storage.OrderStorage.Delete(OrderId);
        }

        [HttpGet("Enter")]
        public string Enter(string str)
        {
            return str; //метод входа на сайт
        }
    }
}