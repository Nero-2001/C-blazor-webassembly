using System;
using System.ComponentModel.DataAnnotations;

namespace CCTruckQ.Entities
{
    public class TruckHistory
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateCreate { get; set; }
        public int Truck_id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Code_WTS { get; set; }
        public string No_WTS { get; set; }
        public double Weight_In { get; set; }
        public double Weight_Out { get; set; }
        public double Net_Weight { get; set; }
        public TimeSpan Time_In { get; set; }
        public TimeSpan Time_Out { get; set; }
        public int TicketNo { get; set; }
        public string OrderNo { get; set; }
    }
}
