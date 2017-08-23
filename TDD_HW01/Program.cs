using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_HW01;

namespace TDD_HW01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> Orders = GetOrders();
            //Order
            //GenericAggragate<Order> genericAggragate = new GenericAggragate<Order>();
            //genericAggragate.Entities = Orders;
            //genericAggragate.NumIntoAGroup = 4;
            //genericAggragate.DoAggregate(x=>x.Revenue);

            //Empoyee
            List<Employee> employee  = GetEmployees();
            GenericAggragate<Employee> genericAggragate = new GenericAggragate<Employee>();
            genericAggragate.Entities = employee;
            genericAggragate.NumIntoAGroup = 4;
            genericAggragate.DoAggregate(x => x.Age);

            foreach (int result in genericAggragate.SumResults)
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

        protected static List<Employee> GetEmployees()
        {
            List<Employee> Entities = new List<Employee>
            {
                new Employee{ id=1, Name ="A1" , Age =11 ,Salary=21},
                new Employee{ id=2, Name ="A2" , Age =12 ,Salary=22},
                new Employee{ id=3, Name ="A3" , Age =13 ,Salary=23},
                new Employee{ id=4, Name ="A4" , Age =14 ,Salary=24},
                new Employee{ id=5, Name ="A5" , Age =15 ,Salary=25},
                new Employee{ id=6, Name ="A6" , Age =16 ,Salary=26},
                new Employee{ id=7, Name ="A7" , Age =17 ,Salary=27},
                new Employee{ id=8, Name ="A8" , Age =18 ,Salary=28},
                new Employee{ id=9, Name = "A9", Age =19 ,Salary=29},
                new Employee{ id=10, Name ="A10" , Age =20 ,Salary=30},
                new Employee{ id=11, Name ="A11" , Age =21 ,Salary=31},

            };

            return Entities;
        }
    }
}
