using System;
using Builder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestBuilder
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Car car = CarBuilder
                .CreateNew()
                .AddName("Ford")
                .AddModel("Focus")
                .Build();

            Assert.AreEqual("Mi automovil es Ford, Modelo: Focus", car.ToString());
        }

        [TestMethod]
        public void BuildFunctionHaveToReturnCarType()
        {
            Car car = CarBuilder
                .CreateNew()
                .AddName("Ford")
                .AddModel("Focus")
                .Build();

            Assert.IsTrue(car is Car);
            System.Diagnostics.Trace.WriteLine("La función Build debe retornar Car");
        }
    }
}
