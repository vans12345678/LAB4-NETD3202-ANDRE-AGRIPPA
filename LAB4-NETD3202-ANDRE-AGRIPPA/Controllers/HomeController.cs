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
        public static List<BookModel> bookList = new List<BookModel>();
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
                //Adds to book list
                bookList.Add(new BookModel(book.title, book.isbn, book.version, book.price, book.condition));
                ViewData["Message"] = book.ToString();


                return View("YourAppraisal", book);
            }
            else
            {
                 return View("Fail");
            }
        }
        public IActionResult ViewAppraisals()
        {
            //Return book list to view appraisals
            return View(bookList);
        }

        
    }
}
