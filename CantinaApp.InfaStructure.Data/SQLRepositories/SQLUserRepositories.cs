using CantinaApp.Core.DomainServices;
using CantinaApp.Core.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CantinaApp.InfaStructure.Data.SQLRepositories
{
    public class SQLUserRepositories : IUserRepositories<Users>
    {

        private readonly CantinaAppContext db;

        public SQLUserRepositories(CantinaAppContext context)
        {
            db = context;
        }

        public void Add(Users entity)
        {
            db.User.Add(entity);
            db.SaveChanges();
        }

        public void Edit(Users entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Users Get(long id)
        {
            return db.User.FirstOrDefault(b => b.Id == id);
        }

        public IEnumerable<Users> GetAll()
        {
            return db.User.ToList();
        }

        public void Remove(long id)
        {
            var item = db.User.FirstOrDefault(b => b.Id == id);
            db.User.Remove(item);
            db.SaveChanges();
        }
    }
}
