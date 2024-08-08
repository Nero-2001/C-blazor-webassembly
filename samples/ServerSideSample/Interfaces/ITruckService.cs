using CCTruckQ.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace CCTruckQ.Interfaces
{
    public interface ITruckService
    {
        Task<int> Create(Truck truck);
        Task<int> Delete(int Id);
        Task<int> Count(string search);
        Task<int> Update(Truck truck);
        Task<Truck> GetById(int Id);
        Task<Truck> GetByTruckPlate(string PlateNo);
        Task<List<Truck>> ListAll(int skip, int take,
            string orderBy, string direction, string search);
        Task<List<Truck_Receive>> ListAllTruckAPI(int skip, int take,
           string orderBy, string direction, string search);
        Task<List<Truck_Receive>> ListAllTruck_API();
    }
}