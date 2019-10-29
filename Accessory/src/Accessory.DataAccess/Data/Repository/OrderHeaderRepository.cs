using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accessory.DataAccess.Data.Repository.IRepository;
using Accessory.Models;

namespace Accessory.DataAccess.Data.Repository
{
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderHeader orderHeader)
        {
            var orderHeaderFromDb = _db.OrderHeaders.FirstOrDefault(m => m.Id == orderHeader.Id);
            _db.OrderHeaders.Update(orderHeaderFromDb);

            _db.SaveChanges();

        }
    }
}
