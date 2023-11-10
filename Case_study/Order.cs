using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_study
{
    internal class Order : Customer
    {

        public int OrderId { get; set; }

        public Book? books { get; set; }
        //public object PhoneNumber1 { get; internal set; }

        public void ProcessOrder(Book book)
        {
            Console.WriteLine("Order Details:" + CustomerId1, CustomerName1);
            Console.WriteLine("Book oreder:" + book.Title, book.Author);
        }

        public double CalculateCost(Book book)
        {
            double TotalCost = book.Price;
            return TotalCost;
        }

    }
}