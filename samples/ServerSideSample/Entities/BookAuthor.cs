using System.ComponentModel.DataAnnotations;

namespace CCTruckQ.Entities
{
   public class BookAuthor
   {
      [Key]
      public long ISBN { get; set; }
      public int AuthorId { get; set; }
      public byte? AuthorOrd { get; set; }
   }
}