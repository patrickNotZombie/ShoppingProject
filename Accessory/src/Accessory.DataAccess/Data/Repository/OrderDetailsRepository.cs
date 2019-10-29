using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accessory.DataAccess.Data.Repository.IRepository;
using Accessory.Models;

namespace Accessory.DataAccess.Data.Repository
{
    public class OrderDetailsRepository : Repository<OrderDetails>, IOrderDetailsRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderDetailsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderDetails orderDetails)
        {
            var orderDetailsFromDb = _db.OrderDetailses.FirstOrDefault(m => m.Id == orderDetails.Id);
            _db.OrderDetailses.Update(orderDetailsFromDb);

            _db.SaveChanges();

        }
    }
}
