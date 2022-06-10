using Microsoft.VisualStudio.TestTools.UnitTesting;
using Övning5;

namespace Övning5Test
{
    [TestClass]
    public class GarageTest
    {
        [TestMethod]
        
        public void Add_WhenGarageFull_ReturnFalse()
        {
            //--Arrange
            Garage<IVehicle> garage = new Garage<IVehicle>(3);
            garage.Add(new Car("DEF456", "White", 4, 1.64));
            garage.Add(new Car("GHI789", "Black", 6, 24));
            garage.Add(new Car("JKL101", "Blue", 4, 19));
            //--Act

            //--Assert
            Assert.IsFalse(garage.Add(new Car("AB2123", "Red", 4, 15)));

        }
    }

}