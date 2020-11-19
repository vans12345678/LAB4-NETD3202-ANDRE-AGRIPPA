/*
 * Name: Andre Agrippa
 * File: BookModel.cs
 * Date: 11/17/2020
 * Purpose: BookModel class that has attributes of a book
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB4_NETD3202_ANDRE_AGRIPPA.Models
{
    public class BookModel
    {
        //Getters and setters for textbook
        public string title { get; set; }

        public Int64 isbn { get; set; }

        public double version { get; set; }

        public double price { get; set; }

        public string condition { get; set; }

        //Default constructor 
        public BookModel()
        {

        }
        //Parameterized constructor
        public BookModel(string title, Int64 isbn, double version, double price, string condition)
        {
            this.title = title;
            this.isbn = isbn;
            this.version = version;
            this.price = price;
            this.condition = condition;
        }
        public double CalculateAppraise(double price, string condition)
        {
            //Formula to calculate appraisal price
            if (condition == "Bad")
            {
                return Math.Round((price / 4), 2);
            }
            if (condition == "Good")
            {
                return Math.Round((price / 3), 2);
            }
            else
            {
                return Math.Round((price / 2), 2);
            }
        }

        public string ToString()
        {
            return "Your textbook: " + title + ",  Version: " + version + " Was appraised at: $" +
                   CalculateAppraise(price, condition);
        }
    }
}
