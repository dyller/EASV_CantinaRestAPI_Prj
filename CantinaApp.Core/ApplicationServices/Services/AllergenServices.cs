using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CantinaApp.Core.DomainServices;
using CantinaApp.Core.Entity.Entities;

namespace CantinaApp.Core.ApplicationServices.Services
{
    public class AllergenServices : IAllergenServices
    {
        readonly IAllergensRepositories _allergensRepo;

        public AllergenServices(IAllergensRepositories allergensRepo)
        {
            _allergensRepo = allergensRepo;
        }

        public Allergen AddAllergen(Allergen allergen)
        {
            return _allergensRepo.CreateAllergen(allergen);
        }

        public Allergen DeleteAllergen(int id)
        {
            return _allergensRepo.DeleteAllergen(id);
        }

        public Allergen FindAllergenId(int id)
        {
            return _allergensRepo.ReadById(id);
        }

        public List<Allergen> GetAllergens()
        {
            return _allergensRepo.ReadMAllergen().ToList();
        }

        public Allergen UpdateAllergen(Allergen allergenUpdate)
        {
            return _allergensRepo.UpdateAllergen(allergenUpdate);
        }
    }
}
