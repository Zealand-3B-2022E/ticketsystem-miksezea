using TicketSystemClassLibrary.model;

namespace TicketSystemTest
{
    /// <summary>
    /// Tests af MC klassen
    /// </summary>
    [TestClass]
    public class MCClassTests
    {
        /// <summary>
        /// Testobjekt af MC
        /// </summary>
        private MC mc;

        /// <summary>
        /// Ops�tter testobjekt for tests, hvor licenseplate v�rdi ikke er relevant
        /// </summary>
        [TestInitialize]
        public void BeforeEachTest()
        {
            mc = new MC("test");
        }

        /// <summary>
        /// Tester at metoden Price() giver 125
        /// </summary>
        /// <param name="value">Pris</param>
        [DataRow(125)]
        [TestMethod]
        public void MC_Price_AreEqual_125(double value)
        {
            // Arrange

            // Act
            double price = mc.Price();

            // Assert
            Assert.AreEqual(value, price);
        }

        /// <summary>
        /// Tester at metoden Price() fejler n�r pris ikke er 125
        /// </summary>
        /// <param name="value">Pris</param>
        [DataRow(126)]
        [DataRow(0)]
        [TestMethod]
        public void MC_Price_AreNotEqual_125(double value)
        {
            // Arrange

            // Act
            double price = mc.Price();

            // Assert
            Assert.AreNotEqual(value, price);
        }

        /// <summary>
        /// Tester at der kommer rabat p� pris hvis Brobizz = true
        /// </summary>
        [TestMethod]
        public void MC_Price_With_Discount()
        {
            // Arrange
            mc.Brobizz = true;

            // Act
            double price = mc.Price();

            // Assert
            Assert.AreEqual(125 * 0.95, price);
        }

        /// <summary>
        /// Tester at metoden VehicleType() giver MC
        /// </summary>
        /// <param name="value">K�ret�jstype</param>
        [DataRow("MC")]
        [TestMethod]
        public void MC_VehicleType_AreEqual_MC(string value)
        {
            // Arrange

            // Act
            string vehicleType = mc.VehicleType();

            // Assert
            Assert.AreEqual(value, vehicleType);
        }

        /// <summary>
        /// Tester at metoden VehicleType() fejler hvis type ikke er MC
        /// </summary>
        /// <param name="value">K�ret�jstype</param>
        [DataRow("Car")]
        [DataRow("")]
        [TestMethod]
        public void MC_VehicleType_AreNotEqual_MC(string value)
        {
            // Arrange

            // Act
            string vehicleType = mc.VehicleType();

            // Assert
            Assert.AreNotEqual(value, vehicleType);
        }

        /// <summary>
        /// Tester at v�rdien for MC's property "licenseplate" ikke feljer ved korrekt v�rdi
        /// </summary>
        /// <param name="value">Licenseplate v�rdi</param>
        [DataRow("1234567")]
        [DataRow("1")]
        [DataRow("1a2bX")]
        [TestMethod]
        public void MC_LicensePlate_AreEqual_Between_1_And_7(string value)
        {
            // Arrange
            var mc2 = new MC(value);

            // Act
            string result = mc2.Licenseplate;

            // Assert
            Assert.AreEqual(value, result);
        }

        /// <summary>
        /// Tester at v�rdien for MC's property 'licenseplate' fejler ved ukorrekt v�rdi
        /// </summary>
        /// <param name="value"></param>
        [DataRow("")]
        [DataRow("12345678")]
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MC_LicensePlate_AreNotEqual_Between_1_And_7(string value)
        {
            // Arrange
            var mc2 = new MC(value);

            // Act
            string result = mc2.Licenseplate;

            // Assert
            Assert.AreNotEqual(value, result);
        }

    }
}
