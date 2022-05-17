using Microsoft.VisualStudio.TestTools.UnitTesting;
using MayExam2022_S00214097;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_RentIncrease()
        {
            //arrange
            RentalProperty r1 = new RentalProperty() { Price = 300m};
            decimal expectedPrice = 330m;

            //act
            r1.RentIncrease(10);

            //assert
            Assert.AreEqual(expectedPrice, r1.Price);
        }
    }

    
}