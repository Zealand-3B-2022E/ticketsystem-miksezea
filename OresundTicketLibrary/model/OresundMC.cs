using TicketSystemClassLibrary.model;

namespace OresundTicketLibrary.model
{
    public class OresundMC : MC
    {
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

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
