using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CantinaApp.Core.DomainServices;
using CantinaApp.Core.Entity.Entities;

namespace CantinaApp.Core.ApplicationServices.Services
{
    public class MOTDServices : IMOTDServices
    {
        readonly IMOTDRepositories _MOTDRepo;
        public MOTDServices(IMOTDRepositories MOTDRepo)
        {
            _MOTDRepo = MOTDRepo;
        }

        public MOTD AddMOTD(MOTD motd)
        {
            return _MOTDRepo.CreateMOTD(motd) ;
        }

        public MOTD DeleteMOTD(int id)
        {
            throw new NotImplementedException();
        }

        public MOTD FindMOTDId(int id)
        {
            throw new NotImplementedException();
        }

        public List<MOTD> GetMOTDs()
        {
            return _MOTDRepo.ReadMOTD().ToList();
        }

        public MOTD GetMOTDsInstance()
        {
            throw new NotImplementedException();
        }

        public MOTD UpdateMOTD(MOTD motdUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
