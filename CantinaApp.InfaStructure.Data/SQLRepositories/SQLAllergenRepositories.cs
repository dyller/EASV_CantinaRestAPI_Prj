using CantinaApp.Core.DomainServices;
using CantinaApp.Core.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CantinaApp.InfaStructure.Data.SQLRepositories
{
    public class SQLAllergenRepositories : IAllergensRepositories
    {
        readonly CantinaAppContext _ctx;

        public SQLAllergenRepositories(CantinaAppContext ctx)
        {
            _ctx = ctx;
        }

        public Allergen CreateAllergen(Allergen allergen)
        {
            _ctx.Attach(allergen).State = EntityState.Added;
            _ctx.SaveChanges();
            return allergen;
        }

        public Allergen GeAllergenByID(int id)
        {
            return _ctx.Allergen.FirstOrDefault(m => m.Id == id);
        }

        public Allergen ReadById(int id)
        {
            return _ctx.Allergen.Include(p => p.FoodIconType)
                        .FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Allergen> ReadMAllergen()
        {
            return _ctx.Allergen;
        }

        public Allergen ReadyByIdIncludeFoodIcon(int id)
        {
            return _ctx.Allergen
                         .Include(o => o.FoodIconType)
                         .FirstOrDefault(o => o.Id == id);
        }

        public Allergen UpdateAllergen(Allergen allergenUpdate)
        {
            _ctx.Attach(allergenUpdate).State = EntityState.Modified;
            _ctx.Entry(allergenUpdate).Reference(o => o.AllergenType).IsModified = true;
            _ctx.SaveChanges();
            return allergenUpdate;
        }

        public Allergen DeleteAllergen(int id)
        {
            var alrgDelete = _ctx.Allergen.ToList().FirstOrDefault(b => b.Id == id);
            _ctx.Allergen.Remove(alrgDelete);
            _ctx.SaveChanges();
            return alrgDelete;
        }
    }
}
