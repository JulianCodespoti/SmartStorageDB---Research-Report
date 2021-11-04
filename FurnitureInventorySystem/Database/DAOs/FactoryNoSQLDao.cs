using System.Collections.Generic;
using System.Linq;
using LiteDB;

namespace FurnitureInventorySystem.Database.DAOs
{
    public class FactoryNoSQLDao : IDao<Factory>
    {
        public Factory Get(int id)
        {
            using var db = new LiteDatabase(@"MyData.db");
            var col = db.GetCollection<Factory>("factories");
            return col.FindById(id);
        }

        public IEnumerable<Factory> GetAll()
        {
            using var db = new LiteDatabase(@"MyData.db");
            var col = db.GetCollection<Factory>("factories");
            if (col.Count() != 0) return col.FindAll().ToList();
            var factory = new Factory()
                {Address = "37 Ford Avenue", Email = "Juliancodespoti@gmail.com", Id = 1, Name = "JuliansFactory"};
            col.Insert(factory);
            return col.FindAll().ToList(); 
        }

        public void Update(int id, Factory item)
        {
            using var db = new LiteDatabase(@"MyData.db");
            var col = db.GetCollection<Factory>("factories");
            col.Update(id,item);
        }

        public void Delete(int id)
        {
            using var db = new LiteDatabase(@"MyData.db");
            var col = db.GetCollection<Factory>("factories");
            col.Delete(id);
        }

        public void Add(Factory item)
        {
            using var db = new LiteDatabase(@"MyData.db");
            var col = db.GetCollection<Factory>("factories");
            col.Insert(item);
        }
    }
}