using CantinaApp.Core.DomainServices;
using CantinaApp.Core.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CantinaApp.InfaStructure.Data.SQLRepositories
{
    public class SQLMOTDRepositories : IMOTDRepositories
    {
        private readonly CantinaAppContext _ctx;

        public SQLMOTDRepositories(CantinaAppContext ctx)
        {
            _ctx = ctx;
        }

        public MOTD CreateMOTD(MOTD motd)
        {
            _ctx.Attach(motd).State = EntityState.Added;
            _ctx.SaveChanges();
            return motd;
        }

        public MOTD DeleteMOTD(int id)
        {
            throw new NotImplementedException();
        }

        public MOTD GetFoodIconByID(int id)
        {
            throw new NotImplementedException();
        }

        public MOTD ReadById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MOTD> ReadMOTD()
        {
            return _ctx.MOTD;
        }

        public MOTD UpdateMOTD(MOTD motdUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
