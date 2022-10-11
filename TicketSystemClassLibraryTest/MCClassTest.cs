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
        /// Opsætter testobjekt for tests, hvor licenseplate værdi ikke er relevant
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
        public void Price_AreEqual_125(double value)
        {
            // Arrange

            // Act
            double price = mc.Price();

            // Assert
            Assert.AreEqual(value, price);
        }

        /// <summary>
        /// Tester at metoden Price() fejler når pris ikke er 125
        /// </summary>
        /// <param name="value">Pris</param>
        [DataRow(126)]
        [DataRow(0)]
        [TestMethod]
        public void Price_AreNotEqual_125(double value)
        {
            // Arrange

            // Act
            double price = mc.Price();

            // Assert
            Assert.AreNotEqual(value, price);
        }

        /// <summary>
        /// Tester at metoden VehicleType() giver MC
        /// </summary>
        /// <param name="value">Køretøjstype</param>
        [DataRow("MC")]
        [TestMethod]
        public void VehicleType_AreEqual_MC(string value)
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
        /// <param name="value">Køretøjstype</param>
        [DataRow("Car")]
        [DataRow("")]
        [TestMethod]
        public void VehicleType_AreNotEqual_MC(string value)
        {
            // Arrange

            // Act
            string vehicleType = mc.VehicleType();

            // Assert
            Assert.AreNotEqual(value, vehicleType);
        }

        /// <summary>
        /// Tester at værdien for MC's property "licenseplate" ikke feljer ved korrekt værdi
        /// </summary>
        /// <param name="value">Licenseplate værdi</param>
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
        /// Tester at værdien for MC's property 'licenseplate' fejler ved ukorrekt værdi
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
