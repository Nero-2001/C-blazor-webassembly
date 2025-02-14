﻿using CCTruckQ.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CCTruckQ.Interfaces
{
   public interface IPublisherService
   {
      Task<int> Create(Publisher publisher);
      Task<Publisher> ReadByPk(int Id);
      Task<int> Update(Publisher publisher);
      Task<int> Delete(int Id);
      Task<int> Count(string search);
      Task<List<Publisher>> FetchAll();
      Task<List<Publisher>> ListAll(int skip,
                                    int take,
                                    string orderBy,
                                    string direction,
                                    string search);
   }
}