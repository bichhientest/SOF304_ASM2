using NUnit.Framework;
using SOF304_ASM2;
namespace SOF304_ASM.UnitTests
{
    public class Tests
    {
        private ElectricityBill bill;

        [Test]
        public void Test1()
        {
            ElectricityBill bill =new ElectricityBill();

            double validResult1 = bill.CalculateCost(10, 5);
            double invalidResult1 = bill.CalculateCost(-5, 10);
            double invalidResult2 = bill.CalculateCost(20, 0);
            double invalidResult3 = bill.CalculateCost(100, -2);
        }
        [Test]
        public void TestCalculateCost_InvalidQuantity()
        {
            int quantity = -5;
            int pricePerUnit = 10;
            Assert.Throws<ArgumentException>(() => bill.CalculateCost(quantity, pricePerUnit));
        }
        [Test]
        public void TestCalculateCost_ZeroPricePerUnit()
        {
            int quantity = 20;
            int pricePerUnit = 0;
            double result = bill.CalculateCost(quantity, pricePerUnit);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void TestCalculateCost_NegativePricePerUnit()
        {
            int quantity = 100;
            int pricePerUnit = -2;
            double result = bill.CalculateCost(quantity, pricePerUnit);
            Assert.AreEqual(-200, result);
        }
    }
}