using CCTruckQ.Interfaces;
using CCTruckQ.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace CCTruckQ.Data
{
   public class MasterBizTypeService : IMasterBizTypeService
   {
      private readonly IDapperService _dapperService;

      public MasterBizTypeService(IDapperService dapperService)
      {
         this._dapperService = dapperService;
      }

      public Task<int> Create(MasterBizType MasterBizType)
      {
         var dbPara = new DynamicParameters();
         dbPara.Add("BusinessType", MasterBizType.BusinessType, DbType.String);
         dbPara.Add("Description", MasterBizType.Description, DbType.String);
         var MasterBizTypeId = Task.FromResult(_dapperService.
             Insert<int>("[dbo].[spAddMasterBizType]", dbPara,
             commandType: CommandType.StoredProcedure));
         return MasterBizTypeId;
      }

      public Task<MasterBizType> ReadByPk(int id)
      {
         var MasterBizType = Task.FromResult(_dapperService.Get
         <MasterBizType>($"select * from [MasterBizType] where id = {id}",
         null, commandType: CommandType.Text));
         return MasterBizType;
      }

      public Task<int> Update(MasterBizType MasterBizType)
      {
         var dbPara = new DynamicParameters();
         dbPara.Add("id", MasterBizType.id);
         dbPara.Add("BusinessType", MasterBizType.BusinessType, DbType.String);
         dbPara.Add("Description", MasterBizType.Description, DbType.String);
         var updateMasterBizType = Task.FromResult(_dapperService.
             Update<int>("[dbo].[spUpdateMasterBizType]", dbPara, 
             commandType: CommandType.StoredProcedure));
         return updateMasterBizType;
      }
      public Task<int> Delete(int id)
      {
         var deleteMasterBizType = Task.FromResult(_dapperService.
             Execute($"Delete [MasterBizType] where id = {id}", null,
             commandType: CommandType.Text));
         return deleteMasterBizType;
      }

      public Task<int> Count(string search)
      {
         var totMasterBizType = Task.FromResult(_dapperService.Get<int>
             ($"select COUNT(*) from [MasterBizType] WHERE BusinessType like " +
             $"'%{search}%'", null, commandType: CommandType.Text));
         return totMasterBizType;
      }

      public Task<List<MasterBizType>> FetchAll()
      {
         var MasterBizTypes = Task.FromResult
             (_dapperService.GetAll<MasterBizType>
             ($"SELECT * FROM [MasterBizType] ORDER BY BusinessType; ",
              null, commandType: CommandType.Text));
         return MasterBizTypes;
      }

      public Task<List<MasterBizType>> ListAll(int skip, int take,
             string orderBy, string direction = "DESC",
             string search = "")
      {
         var MasterBizTypes = Task.FromResult(_dapperService.GetAll
             <MasterBizType>($"SELECT * FROM [MasterBizType] WHERE BusinessType " +
             $"like '%{search}%' ORDER BY {orderBy} {direction} " +
             $"OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ",
             null, commandType: CommandType.Text));
         return MasterBizTypes;
      }
   }
}