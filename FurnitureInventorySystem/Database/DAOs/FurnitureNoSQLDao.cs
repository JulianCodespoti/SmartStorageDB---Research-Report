using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using LiteDB;

namespace FurnitureInventorySystem.Database.DAOs
{
    public class FurnitureNoSQLDao : IDao<Furniture>
    {
        public Furniture Get(int id)
        {
            using var db = new LiteDatabase(@"MyData.db");
            var col = db.GetCollection<Furniture>("furniture");
            return col.FindById(id);
        }

        public IEnumerable<Furniture> GetAll()
        {
            using var db = new LiteDatabase(@"MyData.db");
            var col = db.GetCollection<Furniture>("furniture");
            col.DeleteAll();
            return col.FindAll().ToList();
        }

        public void Update(int id, Furniture item)
        {
            using var db = new LiteDatabase(@"MyData.db");
            var col = db.GetCollection<Furniture>("furniture");
            col.Update(id, item);
        }

        public void Delete(int id)
        {
            using var db = new LiteDatabase(@"MyData.db");
            var col = db.GetCollection<Furniture>("furniture");
            col.Delete(id);
        }

        public void Add(Furniture item)
        {
            using var db = new LiteDatabase(@"MyData.db");
            var col = db.GetCollection<Furniture>("furniture");
            col.Insert(item);
        }
    }
}