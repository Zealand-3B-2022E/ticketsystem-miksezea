using TicketSystemClassLibrary.model;

namespace OresundTicketLibrary.model
{
    /// <summary>
    /// Klasse for OresundMC
    /// </summary>
    public class OresundMC : MC
    {
        /// <summary>
        /// Pris for Øresundsbroen. Rabat ved Brobizz = true
        /// </summary>
        /// <returns>pris</returns>
        public override double Price()
        {
            if (Brobizz)
            {
                return 73;
            }
            else
            {
                return 210;
            }
        }

        /// <summary>
        /// Type af køretøj
        /// </summary>
        /// <returns>Oresund MC</returns>
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
