using Assignment3_SaleManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3_SaleManagement.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult List(int id)
        {
            List<Member> members = new List<Member>();
            using (FStoreContext context = new FStoreContext())
            {
                if (id == 0)
                {
                    members = context.Members.ToList();
                }
                else
                {
                    members = context.Members.Where(x => x.MemberId == id).ToList();
                }

                ViewBag.Members = context.Members.ToList();
            }
            return View("Views/Member/List.cshtml", members);
        }
    }
}
