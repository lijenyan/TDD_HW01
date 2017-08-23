using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_HW01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> Orders = GetOrders();
            OrderAggregate orderAggregate = new OrderAggregate();
            orderAggregate.Orders = Orders;
            orderAggregate.NumIntoAGroup = 4;
            orderAggregate.DoAggregate(x=>x.Revenue);
            foreach (int result in orderAggregate.SumResults)
            {
                Console.WriteLine(string.Format("Sum is {0}", result));
            }
            Console.ReadLine();
        }

        protected static List<Order> GetOrders()
        {
            List<Order> Orders = new List<Order>
            {
                new Order{ id=1, Cost =1 , Revenue =11 ,SellPrice=21},
                new Order{ id=2, Cost =2 , Revenue =12 ,SellPrice=22},
                new Order{ id=3, Cost =3 , Revenue =13 ,SellPrice=23},
                new Order{ id=4, Cost =4 , Revenue =14 ,SellPrice=24},
                new Order{ id=5, Cost =5 , Revenue =15 ,SellPrice=25},
                new Order{ id=6, Cost =6 , Revenue =16 ,SellPrice=26},
                new Order{ id=7, Cost =7 , Revenue =17 ,SellPrice=27},
                new Order{ id=8, Cost =8 , Revenue =18 ,SellPrice=28},
                new Order{ id=9, Cost = 9, Revenue =19 ,SellPrice=29},
                new Order{ id=10, Cost =10 , Revenue =20 ,SellPrice=30},
                new Order{ id=11, Cost =11 , Revenue =21 ,SellPrice=31},

            };

            return Orders;
        }
    }
}
