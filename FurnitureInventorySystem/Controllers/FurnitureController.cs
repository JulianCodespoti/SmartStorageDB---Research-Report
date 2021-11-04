using FurnitureInventorySystem.Database;
using FurnitureInventorySystem.View;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using FurnitureInventorySystem.Database.DAOs;

namespace FurnitureInventorySystem.Controllers
{
    internal class FurnitureController
    {
        private readonly IDao<Furniture> _furnitureDao = new FurnitureDao();
        
        public DataTable LoadFurnitureAsDataTableFrom(int id)
        {
            var furnitureFromSelectedFactory = _furnitureDao.GetAll().Where(furniture => furniture.Factory_Id == id);
            var furnitureAsTable = ListManager<Furniture>.LoadDataTableFrom(furnitureFromSelectedFactory);
            return furnitureAsTable;
        }
        
        internal void AddFurniture(Furniture furniture)
        {
            _furnitureDao.Add(furniture);
        }
        
        internal IEnumerable<Furniture> GetFurnitureFrom(int factoryId)
        {
            return _furnitureDao.GetAll().Where(furniture => furniture.Factory_Id == factoryId);
        }
        
        public Furniture GetByName(string name, int factoryId)
        {
            return _furnitureDao.GetAll().FirstOrDefault(furniture => furniture.Name == name && furniture.Factory_Id == factoryId);
        }
        
        public void RemoveFurniture(int id)
        {
            _furnitureDao.Delete(id);
        }
        
        public void RemoveQuantity(Furniture furniture, int quantity)
        {
            furniture.Quantity -= quantity;
            _furnitureDao.Update(furniture.Id, furniture);
        }
        
        public void UpdateFurniture(Furniture furniture, int factoryId)
        {
            _furnitureDao.Update(factoryId, furniture);
        }
        
        
        // private readonly IDao<Furniture> _furnitureNoSQLDao = new FurnitureNoSQLDao();
        //
        // public DataTable LoadFurnitureAsDataTableFrom(int id)
        // {
        //     var furnitureFromSelectedFactory = _furnitureNoSQLDao.GetAll().Where(furniture => furniture.Factory_Id == id);
        //     var furnitureAsTable = ListManager<Furniture>.LoadDataTableFrom(furnitureFromSelectedFactory);
        //     return furnitureAsTable;
        // }
        //
        // internal void AddFurniture(Furniture furniture)
        // {
        //     _furnitureNoSQLDao.Add(furniture);
        // }
        //
        // internal IEnumerable<Furniture> GetFurnitureFrom(int factoryId)
        // {
        //     return _furnitureNoSQLDao.GetAll().Where(furniture => furniture.Factory_Id == factoryId);
        // }
        //
        // public Furniture GetByName(string name, int factoryId)
        // {
        //     return _furnitureNoSQLDao.GetAll().FirstOrDefault(furniture => furniture.Name == name && furniture.Factory_Id == factoryId);
        // }
        //
        // public void RemoveFurniture(int id)
        // {
        //     _furnitureNoSQLDao.Delete(id);
        // }
        //
        // public void RemoveQuantity(Furniture furniture, int quantity)
        // {
        //     furniture.Quantity -= quantity;
        //     _furnitureNoSQLDao.Update(furniture.Id, furniture);
        // }
        //
        // public void UpdateFurniture(Furniture furniture, int factoryId)
        // {
        //     // _furnitureNoSQLDao.Update(factoryId, furniture);
        //     _furnitureNoSQLDao.Update(furniture.Id, furniture);
        // }
    }
}