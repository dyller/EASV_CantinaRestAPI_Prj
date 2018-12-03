using CantinaApp.Core.DomainServices;
using CantinaApp.Core.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CantinaApp.InfaStructure.Data.SQLRepositories
{
    public class SQLFoodIconRepositories : IFoodIconRepositories
    {
        readonly CantinaAppContext _ctx;

        public SQLFoodIconRepositories(CantinaAppContext ctx)
        {
            _ctx = ctx;
        }

        public FoodIcon CreateFoodIcon(FoodIcon foodIcon)
        {
            _ctx.Attach(foodIcon).State = EntityState.Added;
            _ctx.SaveChanges();
            return foodIcon;
        }

        public FoodIcon GetFoodIconByID(int id)
        {
            return _ctx.FoodIcon.FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<FoodIcon> ReadMFoodIcon()
        {
            return _ctx.FoodIcon;
        }

        public FoodIcon UpdateFoodIcon(FoodIcon foodIconUpdate)
        {
            var updated = _ctx.FoodIcon.Update(foodIconUpdate).Entity;
            _ctx.SaveChanges();
            return updated;
        }

        public FoodIcon DeleteFoodIcon(int id)
        {
            var iconDelete = _ctx.FoodIcon.ToList().FirstOrDefault(b => b.Id == id);
            _ctx.FoodIcon.Remove(iconDelete);
            _ctx.SaveChanges();
            return iconDelete;
        }
    }
}
