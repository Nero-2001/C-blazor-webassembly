using CCTruckQ.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CCTruckQ.Interfaces
{
   public interface IMasterBizTypeService
   {
      Task<int> Create(MasterBizType MasterBizType);
      Task<MasterBizType> ReadByPk(int id);
      Task<int> Update(MasterBizType MasterBizType);
      Task<int> Delete(int id);
      Task<int> Count(string search);
      Task<List<MasterBizType>> FetchAll();
      Task<List<MasterBizType>> ListAll(int skip,
                                    int take,
                                    string orderBy,
                                    string direction,
                                    string search);
   }
}