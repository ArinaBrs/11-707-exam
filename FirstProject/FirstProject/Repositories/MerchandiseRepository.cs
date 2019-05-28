using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstProject.Interfaces;
using FirstProject.Models;

namespace FirstProject.Repositories
{
    public class MerchandiseRepository : IMerchandiseRepository
    {
        private readonly DBContext db;

        public MerchandiseRepository(DBContext db)
        {
            this.db = db;
        }

        public IEnumerable<Merchandise> Merchandises => db.Merchandise.ToList();

        public Merchandise GetMerchandiseById(int id) => db.Merchandise.FirstOrDefault(p => p.Id == id);
    }
}
