﻿using CCTruckQ.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CCTruckQ.Interfaces
{
   public interface IAuthorService
   {
      Task<int> Create(Author author);
      Task<Author> ReadByPk(int Id);
      Task<int> Update(Author author);
      Task<int> Delete(int Id);
      Task<int> Count(string search);
      Task<List<Author>> ListAll(int skip,
                                 int take,
                                 string orderBy,
                                 string direction,
                                 string search);
   }
}
