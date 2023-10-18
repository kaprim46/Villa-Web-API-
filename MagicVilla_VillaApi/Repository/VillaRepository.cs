using System;
using System.Linq.Expressions;
using MagicVilla_VillaApi.Data;
using MagicVilla_VillaApi.Models;
using MagicVilla_VillaApi.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaApi.Repository
{
	public class VillaRepository : Repository<Villa>,IVillaRepository
	{
        private readonly ApplicartionDbContext _db;

        public VillaRepository(ApplicartionDbContext db) : base(db)
		{
            _db = db;
        }

        public async Task<Villa> UpdateAsync(Villa entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Villas.Update(entity);
            await SaveAsync();
            return entity;
        }
    }
}

