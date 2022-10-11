using TicketSystemClassLibrary.model;

namespace OresundTicketLibrary.model
{
    public class OresundCar : Car
    {
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

        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}
