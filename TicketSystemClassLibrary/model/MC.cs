namespace TicketSystemClassLibrary.model
{
    /// <summary>
    /// Klasse for MC som nedarver fra Vehicle
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// Default Konstrukt�r for MC
        /// </summary>
        public MC() : base()
        {
        }

        /// <summary>
        /// Konstrukt�r for MC
        /// </summary>
        /// <param name="licenseplate">Nummerplade ID</param>
        public MC(string licenseplate) : base(licenseplate)
        {

        }

        /// <summary>
        /// Pris for MC i kroner. Rabat gives ved Brobizz = true
        /// </summary>
        /// <returns>pris</returns>
        public override double Price()
        {
            if (Brobizz)
            {
                return 125 * 0.95;
            }
            else
            {
                return 125;
            }
        }

        /// <summary>
        /// Type af k�ret�j for MC
        /// </summary>
        /// <returns>MC</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
