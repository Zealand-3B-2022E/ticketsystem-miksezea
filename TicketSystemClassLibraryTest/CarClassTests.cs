using TicketSystemClassLibrary.model;

namespace TicketSystemTest
{
    /// <summary>
    /// Tests af Car klassen
    /// </summary>
    [TestClass]
    public class CarClassTests
    {
        /// <summary>
        /// Testobjekt af Car
        /// </summary>
        private Car car;

        /// <summary>
        /// Ops�tter testobjekt for alle tests, hvor licenseplate v�rdi ikke er relevant
        /// </summary>
        [TestInitialize]
        public void BeforeEachTest()
        {
            car = new Car("test");
        }

        /// <summary>
        /// Tester at metoden Price() giver 240
        /// </summary>
        /// <param name="value">Pris</param>
        [DataRow(240)]
        [TestMethod]
        public void Car_Price_AreEqual_240(double value)
        {
            // Arrange

            // Act
            double price = car.Price();

            // Assert
            Assert.AreEqual(value, price);
        }

        /// <summary>
        /// Tester at metoden Price() fejler n�r pris ikke er 240
        /// </summary>
        /// <param name="value">Pris</param>
        [DataRow(241)]
        [DataRow(0)]
        [TestMethod]
        public void Car_Price_AreNotEqual_240(double value)
        {
            // Arrange

            // Act
            double price = car.Price();

            // Assert
            Assert.AreNotEqual(value, price);
        }

        /// <summary>
        /// Tester at der kommer rabat p� pris hvis Brobizz = true
        /// </summary>
        [TestMethod]
        public void Car_Price_With_Discount()
        {
            // Arrange
            car.Brobizz = true;

            // Act
            double price = car.Price();

            // Assert
            Assert.AreEqual(240 * 0.95, price);
        }

        /// <summary>
        /// Tester at metoden VehicleType() giver Car
        /// </summary>
        /// <param name="value">K�ret�jstype</param>
        [DataRow("Car")]
        [TestMethod]
        public void Car_VehicleType_AreEqual_Car(string value)
        {
            // Arrange

            // Act
            string vehicleType = car.VehicleType();

            // Assert
            Assert.AreEqual(value, vehicleType);
        }

        /// <summary>
        /// Tester at metoden VehicleType() fejler hvis type ikke er Car
        /// </summary>
        /// <param name="value">K�ret�jstype</param>
        [DataRow("MC")]
        [DataRow("")]
        [TestMethod]
        public void Car_VehicleType_AreNotEqual_Car(string value)
        {
            // Arrange

            // Act
            string vehicleType = car.VehicleType();

            // Assert
            Assert.AreNotEqual(value, vehicleType);
        }

        /// <summary>
        /// Tester at v�rdien for Car's property 'licenseplate' ikke feljer ved korrekt v�rdi
        /// </summary>
        /// <param name="value">Licenseplate v�rdi</param>
        [DataRow("1234567")]
        [DataRow("1")]
        [DataRow("1a2bX")]
        [TestMethod]
        public void Car_LicensePlate_AreEqual_Between_1_And_7(string value)
        {
            // Arrange
            var car2 = new Car(value);

            // Act
            string result = car2.Licenseplate;

            // Assert
            Assert.AreEqual(value, result);
        }

        /// <summary>
        /// Tester at v�rdien for Car's property 'licenseplate' fejler ved ukorrekt v�rdi
        /// </summary>
        /// <param name="value"></param>
        [DataRow("")]
        [DataRow("12345678")]
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Car_LicensePlate_AreNotEqual_Between_1_And_7(string value)
        {
            // Arrange
            var car2 = new Car(value);

            // Act
            string result = car2.Licenseplate;

            // Assert
            Assert.AreNotEqual(value, result);
        }
        
    }
}