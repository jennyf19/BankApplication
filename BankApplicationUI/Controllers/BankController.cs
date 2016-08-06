using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankApplication;

namespace BankApplicationUI.Controllers
{
    public class BankController : Controller
    {
        // GET: Bank
        public ActionResult Index()
        {
            var accounts = Bank.GetAllAccountsByCustomerEmail("test@test.com");
            return View(accounts);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Account account)
        {
            Bank.CreateAccount(account.Name, account.TypeOfAccount, null);
            return RedirectToAction("Index");
        }
    }
}