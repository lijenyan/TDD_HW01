using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_HW01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace TDD_HW01.Tests
{
    [TestClass()]
    public class OrderAggregateTests
    {
        [TestMethod]
        public void Test_11_Goods_3_Cost_Itmes_Into_One_Group_Each_Group_SUM_Is_6_15_24_21()
        {
            //arrange
            var target = new GenericAggragate<Order>();
            target.Entities = ProduceOrders();
            target.NumIntoAGroup = 3;
            List<int> result =new List<int> { 6, 15, 24, 21 };
            //act
            target.DoAggregate(x=>x.Cost);
            List<int> actual = target.SumResults;
            //assert
            CollectionAssert.AreEqual(result, actual);
        }

        [TestMethod]
        public void Test_11_Goods_4_Revenue_Itmes_Into_One_Group_Each_Group_SUM_Is_50_66_60()
        {
            //arrange
            var target = new GenericAggragate<Order>();
            target.Entities = ProduceOrders();
            target.NumIntoAGroup = 4;
            List<int> result =new List<int> { 50, 66, 60 };
            //act
            target.DoAggregate(x=>x.Revenue);
            List<int> actual = target.SumResults;
            //assert
            CollectionAssert.AreEqual(result, actual);
        }

        [TestMethod]
        public void Test_Negative_Number_Itme_Result_Is_ArgumentException_With_FluentAssertion()
        {
            //arrange
            var target = new GenericAggragate<Order>();
            target.Entities = ProduceOrders();
            target.NumIntoAGroup = -1;
            //act
            Action act = () => target.DoAggregate(x=>x.Revenue);
            //assert
            act.ShouldThrow<ArgumentException>();
        }

        [TestMethod]
        public void Test_Not_Exist_ColumnName_Result_Is_ArgumentException_With_FluentAssertion()
        {
            //未完.不知道要如何模擬不存在的欄位
            //arrange
            var target = new GenericAggragate<Order>();
            target.Entities = ProduceOrders();
            target.NumIntoAGroup = 4;
            List<int> result =new List<int> { 50, 66, 60 };
            //act
            Action act = () => target.DoAggregate(x=>x.Cost);
            //assert
            act.ShouldThrow<ArgumentException>();
        }

        [TestMethod]
        public void Test_Zero_Itme_Result_Is_Zero()
        {
            //arrange
            var target = new GenericAggragate<Order>();
            target.Entities = ProduceOrders();
            target.NumIntoAGroup = 0;
            List<int> result =new List<int> { 0 };
            //act
            target.DoAggregate(x=>x.Cost);
            List<int> actual = target.SumResults;
            //assert
            CollectionAssert.AreEqual(result, actual);
        }

        protected static List<Order> ProduceOrders()
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