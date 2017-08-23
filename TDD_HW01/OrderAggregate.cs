using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TDD_HW01
{
    public class Order
    {
        public int id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }

    public class OrderAggregate
    {
        public List<Order> Orders { get; set; }
        public int NumIntoAGroup { get; set; }
        
        public List<int> SumResults { get; set; }

        public OrderAggregate()
        {

        }
        public void DoAggregate(Func<Order, int> predicate)
        {
            SumResults = new List<int>();

            if (NumIntoAGroup == 0)
            {
                SumResults.Add(0);
                return;
            }

            if (NumIntoAGroup < 0)
            {
                throw new ArgumentException("message", "text");
            }

            for (int i = 0; i < Math.Ceiling((double)Orders.Count / NumIntoAGroup); i++)
            {
                SumResults.Add(Orders.Skip(i * NumIntoAGroup).Take(NumIntoAGroup).Sum(predicate));
            }
        }
    }
}
