
using Case_study.CustomExcep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Case_study
{
    
    

        internal class DigitalProduct : Product, IOrderable
        {


            public string? DownloadLink { get; set; }
            public string? FileFormat { get; set; }
            public List<Product> AddToCartList1 = new List<Product>();
            public List<Order> OrderList = new List<Order>();

            public static List<DigitalProduct> digitalProductsList = new List<DigitalProduct>();

        public void DigitalCart(string? pName, List<Product> dP)
        {
            if (Name.Equals(pName))
            {
                AddToCartList1.AddRange(dP);
                Console.WriteLine("Product Added to cart");
            }
            else
            {
                throw new ProductNotFoundException
                    (CustomException.messageList["NA"]);
            }
        }

        public void PlaceOrders(int quantity, List<Product> dProd)
        {
            if (AddToCartList1.Count != 0 && StockQuantity >= quantity)
            {
                Console.WriteLine("Order Placed");
            }
            else
            {
                throw new PlaceOrderException(CustomException.messageList["CE"]);
            }

        }

        public void ProcessPayment(int orderId, Order order)
        {
            if (AddToCartList1.Count != 0 &&
                order.CustomerId1 == orderId)
            {
                Console.WriteLine("Payment successful");
                OrderList.Add(order);
            }
            else
            {
                throw new ProcessPaymentException(CustomException.messageList["PS"]);
            }
        }

        public void DeliverOrders(string? pNum, Order order)
        {
            if (AddToCartList1.Count != 0 && order.PhoneNumber1.Equals(pNum))
            {
                Console.WriteLine("U can download the order");
            }
            else
            {
                throw new DeliverOrderException(CustomException.messageList["DO"]);
            }
        }
    }
}