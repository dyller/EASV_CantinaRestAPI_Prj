using CantinaApp.Core.DomainServices;
using CantinaApp.Core.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CantinaApp.InfaStructure.Data.SQLRepositories
{
    public class SQLMainFoodRepositories : IMainFoodRepositories
    {
        readonly CantinaAppContext _ctx;

        public SQLMainFoodRepositories(CantinaAppContext ctx)
        {
            _ctx = ctx;
        }

        public int Count()
        {
            return _ctx.MainFood.Count();
        }

        public MainFood CreateMainFood(MainFood mainFood)
        {
            _ctx.Attach(mainFood).State = EntityState.Added;
            _ctx.SaveChanges();
            return mainFood;
        }

        public MainFood DeleteMainFood(int id)
        {
            var mFood = _ctx.Remove(new MainFood() { Id = id }).Entity;
            _ctx.SaveChanges();
            return mFood;
        }

        public MainFood GetMainFoodByID(int id)
        {
            return _ctx.MainFood.FirstOrDefault(m => m.Id == id);
        }

        public MainFood ReadById(int id)
        {
            return _ctx.MainFood.Include(p => p.FoodIconType)
                .Include(m => m.Allergens).Include(f => f.Ingredients)
                .FirstOrDefault(c => c.Id == id);
        }

        public MainFood ReadByIdIncludeAllergens(int id)
        {
            return _ctx.MainFood
                 .Include(o => o.Allergens)
                 .FirstOrDefault(o => o.Id == id);
        }

        public MainFood ReadByIdIncludeFoodIcons(int id)
        {
            return _ctx.MainFood
                 .Include(o => o.FoodIconType)
                 .FirstOrDefault(o => o.Id == id);
        }

        public MainFood ReadByIdIncludeIngredients(int id)
        {
            return _ctx.MainFood
                 .Include(o => o.Ingredients)
                 .FirstOrDefault(o => o.Id == id);
        }

        public IEnumerable<MainFood> ReadMainFood(Filter filter = null)
        {
            return _ctx.MainFood.Include(o => o.FoodIconType)
                .Include(m => m.Allergens).Include(f => f.Ingredients);
        }

        public MainFood UpdateMainFood(MainFood foodUpdate)
        {
            _ctx.MainFood.Update(foodUpdate);
            _ctx.SaveChanges();
            return foodUpdate;
        }
    }
}
