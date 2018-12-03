using CantinaApp.Core.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CantinaApp.Core.ApplicationServices
{
    public interface IAllergenServices
    {
        List<Allergen> GetAllergens();

        Allergen AddAllergen(Allergen allergen);

        Allergen DeleteAllergen(int id);

        Allergen FindAllergenId(int id);

        Allergen UpdateAllergen(Allergen allergenUpdate);
    }
}
