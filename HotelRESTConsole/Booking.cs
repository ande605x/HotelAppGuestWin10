namespace HotelRESTConsole
{
    using System;
    using System.Collections.Generic;

    public partial class Booking
    {
        public int Booking_id { get; set; }

        public int Hotel_No { get; set; }

        public int Guest_No { get; set; }

        public DateTime Date_From { get; set; }

        public DateTime Date_To { get; set; }

        public int Room_No { get; set; }

        public virtual Room Room { get; set; }

        public virtual Guest Guest { get; set; }
    }
}
