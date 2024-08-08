using CCTruckQ.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CCTruckQ.Interfaces
{
   public interface IBookAuthorService
   {
      Task<int> Create(BookAuthorName bookAuthorNamer);
      Task<int> Delete(long isbn, int authorId);
      Task<List<BookAuthorName>> FetchAll(long isbn);
      /*
      Task<BookAuthor> ReadByPk(long isbn, int authorId);
      Task<int> Update(BookAuthor bookAuthor);
      Task<int> Count(long isbn);      
      Task<List<BookAuthor>> ListAll(int skip, int take,
                             string orderBy, string direction);
      */
   }
}