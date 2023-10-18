using System;
using System.Linq.Expressions;
using MagicVilla_VillaApi.Data;
using MagicVilla_VillaApi.Models;
using MagicVilla_VillaApi.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaApi.Repository
{
	public class VillaNumberRepository : Repository<VillaNumber>,IVillaNumberRepository
	{
        private readonly ApplicartionDbContext _db;

        public VillaNumberRepository(ApplicartionDbContext db) : base(db)
		{
            _db = db;
        }

        public async Task<VillaNumber> UpdateAsync(VillaNumber entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.VillaNumbers.Update(entity);
            await SaveAsync();
            return entity;
        }
    }
}

