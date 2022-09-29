using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.model
{
    public class MC
    {
        public MC() : this("Not assigned")
        {
        }

        /// <summary>
        /// Konstruktør for MC
        /// </summary>
        /// <param name="licenseplate">Nummerplade</param>
        /// <param name="date">Dato</param>
        public MC(string licenseplate)
        {
            Licenseplate = licenseplate;
            Date = new DateTime();
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
        /// <param name="price">Pris for MC</param>
        /// <returns>125</returns>
        public double Price(double price = 125)
        {
            return price;
        }

        /// <summary>
        /// Metode til at returnere type af køretøj (string)
        /// </summary>
        /// <returns>MC</returns>
        public string VehicleType(string type = "MC")
        {
            return type;
        }
    }
}
