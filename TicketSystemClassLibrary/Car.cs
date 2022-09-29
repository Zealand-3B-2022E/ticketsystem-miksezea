namespace TicketSystemClassLibrary
{
    
    public class Car
    {
        public Car(string licenseplate, DateTime date)
        {
            Licenseplate = licenseplate;
            Date = date;
        }

        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }
    }
}