using Assignment3_SaleManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3_SaleManagement.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult List(int id)
        {

            List<Order> orders = new List<Order>();

            using (FStoreContext context = new FStoreContext())
            {
                ViewBag.Members = context.Members.ToList();
                ViewBag.CurrentMemberId = id;
                if (id == 0)
                {
                    orders = context.Orders.ToList();

                }
                else
                {
                    orders = (from m in context.Members
                              join o in context.Orders on m.MemberId equals o.MemberId
                              where o.MemberId == id
                              select new Order(
                                  o.OrderId,
                                  o.Member,
                                  o.OrderDate,
                                  o.RequiredDate,
                                  o.ShippedDate,
                                  o.Freight
                                  )).ToList();
                }

            }
            return View(orders);

        }

        public IActionResult Delete(int Id)
        {
            using (FStoreContext context = new FStoreContext())
            {
                List<OrderDetail> detail = context.OrderDetails.Where(x => x.OrderId == Id).ToList();
                context.OrderDetails.RemoveRange(detail);

                Order order = context.Orders.First(x => x.OrderId == Id);
                context.Orders.Remove(order);
                context.SaveChanges();
            }
            return RedirectToAction("List");
        }

        public IActionResult Insert(int Id)
        {
            using (FStoreContext context = new FStoreContext())
            {
                ViewBag.Members = context.Members.ToList();
            }
            return View();
        }

        public IActionResult Add(int Id, DateTime order, DateTime requirement, DateTime ship, decimal freight, int member)
        {
            Order o = new Order();
            o.OrderId = Id;
            o.OrderDate = order;
            o.RequiredDate = requirement;
            o.ShippedDate = ship;
            o.Freight = freight;
            o.MemberId = member;

            using (FStoreContext context = new FStoreContext())
            {
                context.Orders.Add(o);
                context.SaveChanges();
            }
            return RedirectToAction("List");
        }

        public IActionResult FormEdit(int Id)
        {
            Order o = new Order();
            using (FStoreContext context = new FStoreContext())
            {
                o = context.Orders.First(x => x.OrderId == Id);
                ViewBag.Members = context.Members.ToList();
            }
            return View(o);
        }

        public IActionResult Edit(int Id, DateTime order, DateTime requirement, DateTime ship, int member, decimal freight)
        {


            using (FStoreContext context = new FStoreContext())
            {

                Order o = context.Orders.First(x => x.OrderId == Id);
                o.OrderDate = order;
                o.RequiredDate = requirement;
                o.ShippedDate = ship;
                o.Freight = freight;
                o.MemberId = member;

                context.Orders.Update(o);
                context.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}
