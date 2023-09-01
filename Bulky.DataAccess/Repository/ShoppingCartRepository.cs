using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly ApplicationDbContext _db;

        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ShoppingCart shoppingCart)
        {
            var shoppingCartFrmDB = _db.ShoppingCarts.FirstOrDefault(q => q.Id == shoppingCart.Id);
            if (shoppingCartFrmDB != null)
            {
                shoppingCartFrmDB.ProductId = shoppingCart.ProductId;
                shoppingCartFrmDB.Count = shoppingCart.Count;
                shoppingCartFrmDB.ApplicationUserId = shoppingCart.ApplicationUserId;
            }
        }
    }
}
