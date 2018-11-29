using CantinaApp.Core.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CantinaApp.Core.ApplicationServices
{
    public interface ISpecialOffersServices
    {
        SpecialOffers GetMOTDsInstance();

        List<SpecialOffers> GetMOTDs();

        SpecialOffers AddSpecialOffer(SpecialOffers specialOffers);

        SpecialOffers DeleteSpecialOffer(int id);

        SpecialOffers FindSpecialOfferId(int id);

        SpecialOffers UpdateSpecialOffer(SpecialOffers specialOffers);
    }
}
