using CantinaApp.Core.DomainServices;
using CantinaApp.Core.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CantinaApp.InfaStructure.Data.SQLRepositories
{
    public class SQLUserRepositories : IUserRepositories<Users>
    {
        public void Add(Users entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Users entity)
        {
            throw new NotImplementedException();
        }

        public Users Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Users> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(long id)
        {
            throw new NotImplementedException();
        }
    }
}
