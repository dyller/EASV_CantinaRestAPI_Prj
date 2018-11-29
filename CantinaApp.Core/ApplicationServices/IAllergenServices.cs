using CantinaApp.Core.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CantinaApp.Core.ApplicationServices
{
    public interface IAllergenServices
    {
        Allergen GetAllergenInstance();

        List<Allergen> GetAllergens();

        Allergen AddAllergen(Allergen allergen);

        Allergen DeleteAllergen(int id);

        Allergen FindOwnerById(int id);

        Allergen UpdateOwner(Allergen allergenUpdate);
    }
}
