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
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext _db;

        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Company company)
        {
            var companyFrmDB = _db.Companies.FirstOrDefault(q => q.Id == company.Id);

            if (companyFrmDB != null)
            {
                companyFrmDB.Name = company.Name;
                companyFrmDB.StreetAddress = company.StreetAddress;
                companyFrmDB.City = company.City;
                companyFrmDB.State = company.State;
                companyFrmDB.PostalCode = company.PostalCode;
                companyFrmDB.PhoneNumber = company.PhoneNumber;
            }
        }
    }
}
