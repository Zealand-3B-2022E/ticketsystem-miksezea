namespace TicketSystemClassLibrary.model
{
    /// <summary>
    /// Klasse for Car
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Default Konstruktør for Car
        /// </summary>
        public Car() : base()
        {
        }

        /// <summary>
        /// Konstruktør for Car
        /// </summary>
        /// <param name="licenseplate">Nummerplade ID</param>
        public Car(string licenseplate) : base(licenseplate)
        {
        }

        /// <summary>
        /// Pris for Car i kroner
        /// </summary>
        /// <returns>240</returns>
        public override double Price()
        {
            return 240;
        }

        /// <summary>
        /// Type af køretøj for Car
        /// </summary>
        /// <returns>Car</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}