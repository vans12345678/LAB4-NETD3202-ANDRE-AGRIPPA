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
        private string output;
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
                bookList.Add(new BookModel(book.title, book.isbn, book.version, book.price, book.condition));
                ViewData["Message"] = book.ToString();

                return View("YourAppraisal", book);
            }
            else
            {
                 return View("Fail");
            }
        }

        public IActionResult ViewAppraisals(List<BookModel> bookList)
        {
            // foreach (BookModel item in bookList)
            // {
            //     output += item.ToString();
            // }

            int x = bookList.Count;
            ViewData["Message"] = x.ToString();
            return View("ViewAppraisals", bookList);
        }
    }
}
