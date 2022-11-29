using TicketSystemClassLibrary.model;

namespace StoreBaeltTicketLibrary.model
{
    /// <summary>
    /// Klasse for WeekendCar
    /// </summary>
    public class StoreBaeltCar : Car
    {
        /// <summary>
        /// Pris med weekendrabat og Brobizz
        /// </summary>
        /// <returns>pris</returns>
        public override double Price()
        {
            if (Date.ToString("dddd") == "Saturday" && Date.ToString("dddd") == "Sunday")
            {
                if (Brobizz)
                {
                    return 240 * 0.8 * 0.95;
                }
                else
                {
                    return 240 * 0.8;
                }
            }
            else if (Brobizz)
            {
                return 240 * 0.95;
            }
            else
            {
                return 240;
            }
        }
    }
}