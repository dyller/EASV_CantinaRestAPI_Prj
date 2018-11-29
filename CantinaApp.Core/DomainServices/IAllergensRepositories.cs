using CantinaApp.Core.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CantinaApp.Core.DomainServices
{
    public interface IAllergensRepositories
    {
        Allergen GeAllergenByID(int id);

        IEnumerable<Allergen> ReadMAllergen();

        Allergen CreateAllergen(Allergen allergen);

        Allergen DeleteAllergen(int id);

        Allergen ReadById(int id);

        Allergen UpdateAllergen(Allergen allergenUpdate);

        Allergen ReadyByIdIncludeFoodIcon(int id);
    }
}
