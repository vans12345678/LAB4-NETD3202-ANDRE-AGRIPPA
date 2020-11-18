/*
 * Name: Andre Agrippa
 * File: HomeController.cs
 * Date: 11/17/2020
 * Purpose: HomeController that calls views of various pages
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAB4_NETD3202_ANDRE_AGRIPPA.Models;
using Microsoft.AspNetCore.Mvc;

namespace LAB4_NETD3202_ANDRE_AGRIPPA.Controllers
{
    public class HomeController : Controller
    {
        List<BookModel> bookList = new List<BookModel>();
        public IActionResult Index()
        {
            BookModel message = new BookModel();
            return View(message);
        }

        [HttpGet]
        public IActionResult Appraise()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Appraise(BookModel book)
        {
            if (ModelState.IsValid)
            {
                ViewData["Message"] = "Your textbook: " + book.title + ",  Version: " + book.version + 
                                      "Was appraised at: $" + book.CalculateAppraise(book.price, book.condition);
                return View("YourAppraisal", book);
            }
            else
            {
                 return View("Fail");
            }
           
        }
    }
}
