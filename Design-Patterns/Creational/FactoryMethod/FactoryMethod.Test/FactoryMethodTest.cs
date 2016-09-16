using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FakeItEasy;

namespace FactoryMethod.Test
{
    [TestFixture]
    public class FactoryMethodTest
    {
        [TestCase]
        public void TestGetSpecifications()
        {
            // Test Passed
            //CarFactory carFactory = new CarFactory();
            //ICar nano = carFactory.GetCar("nano");
            //string carName =  nano.GetSpecifications();
            //Assert.AreEqual(carName, "NanoCar");

            //Test Failed
            //Using Fakeit Easy
            ICar nano = A.Fake<ICar>();
            A.CallTo(() => nano.GetSpecifications()).Returns("XYZ");
            string car = nano.GetSpecifications();
            Assert.AreEqual(car, "NanoCar");
        }
    }
}
