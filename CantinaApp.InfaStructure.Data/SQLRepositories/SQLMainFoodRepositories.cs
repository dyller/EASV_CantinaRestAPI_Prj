using CantinaApp.Core.DomainServices;
using CantinaApp.Core.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CantinaApp.InfaStructure.Data.SQLRepositories
{
    public class SQLMainFoodRepositories : IMainFoodRepositories
    {
        public int Count()
        {
            throw new NotImplementedException();
        }

        public MainFood CreateMainFood(MainFood mainFood)
        {
            throw new NotImplementedException();
        }

        public MainFood DeleteMainFood(int id)
        {
            throw new NotImplementedException();
        }

        public MainFood GetMainFoodByID(int id)
        {
            throw new NotImplementedException();
        }

        public MainFood ReadById(int id)
        {
            throw new NotImplementedException();
        }

        public MainFood ReadByIdIncludeAllergens(int id)
        {
            throw new NotImplementedException();
        }

        public MainFood ReadByIdIncludeFoodIcons(int id)
        {
            throw new NotImplementedException();
        }

        public MainFood ReadByIdIncludeIngredients(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MainFood> ReadMainFood()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MainFood> ReadMainFood(Filter filter = null)
        {
            throw new NotImplementedException();
        }

        public MainFood UpdateMainFood(MainFood foodUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
