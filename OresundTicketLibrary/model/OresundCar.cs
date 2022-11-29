using TicketSystemClassLibrary.model;

namespace OresundTicketLibrary.model
{
    /// <summary>
    /// Klasse for OresundCar
    /// </summary>
    public class OresundCar : Car
    {
        /// <summary>
        /// Pris for Øresundsbroen. Rabat ved Brobizz = true
        /// </summary>
        /// <returns>pris</returns>
        public override double Price()
        {
            if (Brobizz)
            {
                return 161;
            }
            else
            {
                return 410;
            }
        }

        /// <summary>
        /// Type af køretøj
        /// </summary>
        /// <returns>Oresund car</returns>
        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}
