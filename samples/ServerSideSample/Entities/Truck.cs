using System;
using System.ComponentModel.DataAnnotations;

namespace CCTruckQ.Entities
{
    public class Truck
    {
        [Key]
        public int id { get; set; }
        public DateTime DateCreate { get; set; }
        public string TruckPlateNo { get; set; }
        public string TruckBrand { get; set; }
        public int TruckType_id { get; set; }
        public int TruckOwnerType_id { get; set; }
        public string TruckOwner { get; set; }
        public double LoadWeight { get; set; }

        
    }
    public class Truck_Receive
    {
        public string CardNo { get; set; }
        public string TruckNo { get; set; }
        public object ContainerNo { get; set; }
        public object SealNo { get; set; }
        public object TruckStateName { get; set; }
        public object TruckType { get; set; }
        public object GateInName { get; set; }
        public object TempFront { get; set; }
        public object TempMiddle { get; set; }
        public object TempBack { get; set; }
        public object TempFront2 { get; set; }
        public object TempMiddle2 { get; set; }
        public object TempBack2 { get; set; }
        public object TempFront3 { get; set; }
        public object TempMiddle3 { get; set; }
        public object TempBack3 { get; set; }
        public object ProvinceThaiName { get; set; }
        public object ProvinceEngName { get; set; }
        public DateTime ? GateInDate { get; set; }
        public double ? WeightIn { get; set; }
        public object GateOutDate { get; set; }
        public object WeightOut { get; set; }
        public object WeightOutDate { get; set; }
        public object TrailerTailNo { get; set; }
        public object StartLoadUser { get; set; }
        public object StartLoadDate { get; set; }
        public object EndLoadUser { get; set; }
        public object EndLoadDate { get; set; }
        public int OrderId { get; set; }
    }
}
