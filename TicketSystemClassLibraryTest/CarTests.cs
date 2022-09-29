using TicketSystemClassLibrary.model;

namespace TicketSystemTest
{
    /// <summary>
    /// Test af bilklasse
    /// </summary>
    [TestClass]
    public class CarTests
    {
        /// <summary>
        /// Test af metoden Price()
        /// </summary>
        /// <param name="value">Pris</param>
        [DataRow(240)]
        [TestMethod]
        public void PriceTest(double value)
        {
            // Arrange
            var car = new Car();

            // Act
            double price = car.Price();

            // Assert
            Assert.AreEqual(value, price);
        }

        /// <summary>
        /// Test af metoden VehicleType()
        /// </summary>
        /// <param name="value">Biltype</param>
        [DataRow("Car")]
        [TestMethod]
        public void VehicleTypeTest(string value)
        {
            // Arrange
            var car = new Car();

            // Act
            string vehicleType = car.VehicleType();

            // Assert
            Assert.AreEqual(value, vehicleType);
        }
    }
}