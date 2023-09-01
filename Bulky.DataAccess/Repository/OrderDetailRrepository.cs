using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class OrderDetailRrepository : Repository<OrderDetail>, IOrderDetailRrepository
    {
        private readonly ApplicationDbContext _db;

        public OrderDetailRrepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        void IOrderDetailRrepository.Update(OrderDetail orderDetail)
        {
            _db.OrderDetails.Update(orderDetail);
        }
    }
}
