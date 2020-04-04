using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreMVCcrud.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreMVCcrud.Controllers
{
    public class CustController : Controller
    {

        private readonly ApplicationDbContext _db;

        public CustController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var displaydata = _db.tb_customer.ToList();
            return View(displaydata);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(NewEmp nec)
        {
            if (ModelState.IsValid)
            {
                _db.Add(nec);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nec);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getempdetails = await _db.tb_customer.FindAsync(id);
            return View(getempdetails);
        
        }
        [HttpPost]
        public async Task<IActionResult> Edit(NewEmp nc)
        {
            if (ModelState.IsValid)
            {
                _db.Update(nc);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nc);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getempdetails = await _db.tb_customer.FindAsync(id);
            return View(getempdetails);

        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getempdetails = await _db.tb_customer.FindAsync(id);
            return View(getempdetails);

        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var getempdetails = await _db.tb_customer.FindAsync(id);
            _db.tb_customer.Remove(getempdetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }


    }
}