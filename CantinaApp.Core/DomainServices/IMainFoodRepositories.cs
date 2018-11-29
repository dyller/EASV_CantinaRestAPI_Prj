using CantinaApp.Core.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CantinaApp.Core.DomainServices
{
    public interface IMainFoodRepositories
    {
        MainFood GetMainFoodByID(int id);

        IEnumerable<MainFood> ReadMainFood();

        MainFood CreateMainFood(MainFood mainFood);

        MainFood DeleteMainFood(int id);

        MainFood ReadById(int id);

        MainFood UpdateMainFood(MainFood foodUpdate);

        MainFood ReadByIdIncludeIngredients(int id);

        MainFood ReadByIdIncludeAllergens(int id);

        MainFood ReadByIdIncludeFoodIcons(int id);
    }
}
