using CCTruckQ.Interfaces;
using CCTruckQ.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Policy;
using System.Xml.Linq;

namespace CCTruckQ.Data
{
    public  class TruckService : ITruckService
    {
        private readonly IDapperService _dapperService;
        public TruckService(IDapperService dapperService)
        {
            this._dapperService = dapperService;
        }
        public Task<int> Create(Truck truck)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("DateCreate", truck.DateCreate, DbType.DateTime);
            dbPara.Add("TruckPlateNo", truck.TruckPlateNo, DbType.String);
            dbPara.Add("TruckBrand", truck.TruckBrand, DbType.String);
            dbPara.Add("TruckType_id", truck.TruckType_id, DbType.Int64);
            dbPara.Add("TruckOwnerType_id", truck.TruckOwnerType_id, DbType.Int64);
            dbPara.Add("TruckOwner", truck.TruckOwner, DbType.String);
            dbPara.Add("LoadWeight", truck.LoadWeight, DbType.Double);

            var truckId = Task.FromResult
               (_dapperService.Insert<int>("[dbo].[Upd_TruckAdd]",
               dbPara, commandType: CommandType.StoredProcedure));
            return truckId;
        }
        public Task<Truck> GetById(int id)
        {
            var truck = Task.FromResult
               (_dapperService.Get<Truck>
               ($"select * from [Truck] where id = {id}", null, commandType: CommandType.Text));
            return truck;
        }
        public Task<Truck> GetByTruckPlate(string PlateNo)
        {
            var truck = Task.FromResult
           (_dapperService.Get<Truck>
           ($"select * from [Truck] where TruckPlateNo like '%{PlateNo}%' ", null, commandType: CommandType.Text));
            return truck;
        }
        public Task<int> Delete(int id)
        {
            var deleteTruck = Task.FromResult
               (_dapperService.Execute
               ($"Delete [Truck] where id = {id}", null, commandType: CommandType.Text));
            return deleteTruck;
        }
        public Task<int> Count(string search)
        {
            var totTruck = Task.FromResult(_dapperService.Get<int>
               ($"select COUNT(*) from [Truck] WHERE TruckPlateNo like '%{search}%' ", null, commandType: CommandType.Text));
            return totTruck;
        }
        public Task<List<Truck>> ListAll(int skip, int take,
           string orderBy, string direction = "DESC", string search = "")
        {
            var trucks = Task.FromResult
               (_dapperService.GetAll<Truck>
               ($"SELECT * FROM [Truck] WHERE TruckPlateNo like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return trucks;
        }
        public Task<List<Truck_Receive>> ListAllTruckAPI(int skip, int take, string orderBy, string direction, string search)
        {
            var trucks = Task.FromResult
            (_dapperService.GetAll<Truck_Receive>
            ($"SELECT * FROM [Truck] WHERE TruckPlateNo like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return trucks;
        }
        public Task<List<Truck_Receive>> ListAllTruck_API()
        {
              var trucks = Task.FromResult
               (_dapperService.GetAll<Truck_Receive>
               ($"SELECT * FROM [ReceiveAPI_DataTruck]  ", null, commandType: CommandType.Text));
            return trucks;
        }
        public Task<int> Update(Truck truck)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("id", truck.id);
            dbPara.Add("DateCreate", truck.DateCreate, DbType.DateTime);
            dbPara.Add("TruckPlateNo", truck.TruckPlateNo, DbType.String);
            dbPara.Add("TruckBrand", truck.TruckBrand, DbType.String);
            dbPara.Add("TruckType_id", truck.TruckType_id, DbType.Int64);
            dbPara.Add("TruckOwnerType_id", truck.TruckOwnerType_id, DbType.Int64);
            dbPara.Add("TruckOwner", truck.TruckOwner, DbType.String);
            dbPara.Add("LoadWeight", truck.LoadWeight, DbType.Double);
            var updateTruck = Task.FromResult
               (_dapperService.Update<int>("[dbo].[Upd_Truck]",
               dbPara, commandType: CommandType.StoredProcedure));
            return updateTruck;
        }

     
    }
}
