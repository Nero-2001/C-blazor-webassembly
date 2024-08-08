using System.ComponentModel.DataAnnotations;

namespace CCTruckQ.Entities
{
   public class MasterBizType
    {
      [Key]
      public int id { get; set; }
      public string BusinessType { get; set; }
      public string Description { get; set; }

   }
}