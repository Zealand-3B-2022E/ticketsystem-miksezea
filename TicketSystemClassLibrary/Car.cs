namespace TicketSystemClassLibrary
{
    /// <summary>
    /// Klasse for Car
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Konstruktør for Car
        /// </summary>
        /// <param name="licenseplate">Nummerplade</param>
        /// <param name="date">Dato</param>
        public Car(string licenseplate, DateTime date)
        {
            Licenseplate = licenseplate;
            Date = date;
        }

        /// <summary>
        /// Property for nummerplade
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Property for dato
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Metode til at returnere pris (double)
        /// </summary>
        /// <param name="price">Pris for Car</param>
        /// <returns>240</returns>
        public double Price(double price = 240)
        {
            return price;
        }

        /// <summary>
        /// Metode til at returnere biltype (string)
        /// </summary>
        /// <returns>Car</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}