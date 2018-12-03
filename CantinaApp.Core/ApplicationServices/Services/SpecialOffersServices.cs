using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CantinaApp.Core.DomainServices;
using CantinaApp.Core.Entity.Entities;

namespace CantinaApp.Core.ApplicationServices.Services
{
    public class SpecialOffersServices : ISpecialOffersServices
    {
        readonly ISpecialOffersRepositories _sOffersRepo;

        public SpecialOffersServices(ISpecialOffersRepositories sOffersRepo)
        {
            _sOffersRepo = sOffersRepo;
        }

        public SpecialOffers AddSpecialOffer(SpecialOffers specialOffers)
        {
            return _sOffersRepo.CreateSpecialOffers(specialOffers);
        }

        public SpecialOffers GetSpecialOffersById(int id)
        {
            return _sOffersRepo.ReadSpecialOffers().ToList().FirstOrDefault(spc => spc.Id == id);
        }

        public SpecialOffers DeleteSpecialOffer(int id)
        {
            return _sOffersRepo.DeleteSpecialOffers(id);
        }

        public List<SpecialOffers> GetSpecialOffers()
        {
            return _sOffersRepo.ReadSpecialOffers().ToList();
        }

        public SpecialOffers UpdateSpecialOffer(SpecialOffers specialOffers)
        {
            return _sOffersRepo.UpdateSpecialOffers(specialOffers);
        }
    }
}
