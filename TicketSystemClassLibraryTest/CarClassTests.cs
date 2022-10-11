namespace TicketSystemTest
{
    /// <summary>
    /// Tests af Car klassen
    /// </summary>
    [TestClass]
    public class CarClassTests
    {
        /// <summary>
        /// Tester at metoden Price() giver 240
        /// </summary>
        /// <param name="value">Pris</param>
        [DataRow(240)]
        [TestMethod]
        public void Price_AreEqual_240(double value)
        {
            // Arrange
            var car = new Car("test");

            // Act
            double price = car.Price();

            // Assert
            Assert.AreEqual(value, price);
        }

        /// <summary>
        /// Tester at metoden Price() fejler når pris ikke er 240
        /// </summary>
        /// <param name="value">Pris</param>
        [DataRow(241)]
        [DataRow(0)]
        [TestMethod]
        public void Price_AreNotEqual_240(double value)
        {
            // Arrange
            var car = new Car("test");

            // Act
            double price = car.Price();

            // Assert
            Assert.AreNotEqual(value, price);
        }

        /// <summary>
        /// Tester at metoden VehicleType() giver Car
        /// </summary>
        /// <param name="value">Køretøjstype</param>
        [DataRow("Car")]
        [TestMethod]
        public void VehicleType_AreEqual_Car(string value)
        {
            // Arrange
            var car = new Car("test");

            // Act
            string vehicleType = car.VehicleType();

            // Assert
            Assert.AreEqual(value, vehicleType);
        }

        /// <summary>
        /// Tester at metoden VehicleType() fejler hvis type ikke er Car
        /// </summary>
        /// <param name="value">Køretøjstype</param>
        [DataRow("MC")]
        [DataRow("")]
        [TestMethod]
        public void VehicleType_AreNotEqual_Car(string value)
        {
            // Arrange
            var car = new Car("test");

            // Act
            string vehicleType = car.VehicleType();

            // Assert
            Assert.AreNotEqual(value, vehicleType);
        }

        /// <summary>
        /// Tester at værdien for Car's property "licenseplate" ikke feljer ved korrekt værdi
        /// </summary>
        /// <param name="value">Licenseplate værdi</param>
        /// <param name="correctValue">Korrekte licenseplate værdi</param>
        [DataRow("1234567", "1234567")]
        [DataRow("1", "1")]
        [DataRow("1a2bX", "1a2bX")]
        [TestMethod]
        public void Car_LicensePlate_AreEqual_Between_1_And_7(string value, string correctValue)
        {
            // Arrange
            var car = new Car(value);

            // Act
            string result = car.Licenseplate;

            // Assert
            Assert.AreEqual(correctValue, result);
        }

        /*
        [DataRow("")]
        [DataRow("12345678")]
        [TestMethod]
        []
        public void Car_LicensePlate_AreNotEqual_Between_1_And_7(string value)
        {
            // Arrange
            Car car = new Car(value);

            // Act
            string result = car.Licenseplate;

            // Assert
            Assert.AreEqual(, result);
        }
        */
    }
}