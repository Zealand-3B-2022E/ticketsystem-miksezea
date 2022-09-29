namespace TicketSystemClassLibrary.model
{
    /// <summary>
    /// Abstract klasse som alle køretøjer nedarver fra
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// Nummerplade på køretøj
        /// </summary>
        protected string Licenseplate { get; private set; }

        /// <summary>
        /// Dato for køretøj
        /// </summary>
        protected DateTime Date { get; private set; }


        protected Vehicle()
        {
        }

        protected Vehicle(string licenseplate)
        {
            if (licenseplate == null || licenseplate.Length == 0 || licenseplate.Length > 7 )
            {
                throw new ArgumentException($"'{nameof(licenseplate)}' should contain 1 to 7 characters. You typed: {licenseplate}");
            }
            this.Licenseplate = licenseplate;
            this.Date = new();
        }

        /// <summary>
        /// Abstract metode der angiver pris i kroner for køretøj
        /// </summary>
        /// <returns>Pris i kroner</returns>
        public abstract double Price();

        /// <summary>
        /// Abstract metode der angiver type af køretøj
        /// </summary>
        /// <returns>Type af køretøj</returns>
        public abstract string VehicleType();

        /// <summary>
        /// ToString for Vehicle og klasser der arver fra Vehicle
        /// </summary>
        /// <returns>Vehicle: \t\t{this.VehicleType()} \nLicense plate ID: \t{this.Licenseplate} \nPrice: \t\t{this.Price()} kr.</returns>
        public override string? ToString()
        {
            return $"Vehicle: \t\t{this.VehicleType()} \nLicense plate ID: \t{this.Licenseplate} \nPrice: \t\t{this.Price()} kr.";
        }
    }
}
