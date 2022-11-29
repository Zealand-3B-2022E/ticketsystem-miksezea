namespace TicketSystemClassLibrary.model
{
    /// <summary>
    /// Abstract klasse som alle k�ret�jer nedarver fra
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// Nummerplade p� k�ret�j
        /// </summary>
        public string Licenseplate { get; private set; }

        /// <summary>
        /// Dato for k�ret�j
        /// </summary>
        public DateTime Date { get; set; }

        public bool Brobizz { get; set; }

        /// <summary>
        /// Default konstukt�r for Vehicle
        /// </summary>
        protected Vehicle() : this("NoValue")
        {
        }

        /// <summary>
        /// Konstrukt�r for Vehicle
        /// </summary>
        /// <param name="licenseplate">Nummerplade ID</param>
        /// <exception cref="ArgumentOutOfRangeException">Nummerplade ID skal v�re mellem 1-7 tegn</exception>
        protected Vehicle(string licenseplate)
        {
            if (licenseplate.Length < 1 || licenseplate.Length > 7)
            {
                throw new ArgumentOutOfRangeException($"Value of '{nameof(licenseplate)}' should contain 1 to 7 characters. You typed: {licenseplate}");
            }
            this.Licenseplate = licenseplate;
            this.Date = new();
            this.Brobizz = false;
        }

        /// <summary>
        /// Abstract metode der angiver pris i kroner for k�ret�j
        /// </summary>
        /// <returns>Pris i kroner</returns>
        public abstract double Price();

        /// <summary>
        /// Abstract metode der angiver type af k�ret�j
        /// </summary>
        /// <returns>Type af k�ret�j</returns>
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
