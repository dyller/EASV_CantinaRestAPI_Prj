using CantinaApp.Core.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CantinaApp.Core.ApplicationServices
{
    public interface IMainFoodServices
    {
        MainFood GetMainFoodInstance();

        List<MainFood> GetMainFood();

        MainFood AddMainFood(MainFood mainFood);

        MainFood DeleteMainFood(int id);

        MainFood FindMainFoodId(int id);

        MainFood FindMainFoodIdIncludeIngredients(int id);

        MainFood FindMainFoodIdIncludeAllergents(int id);

        MainFood UpdateMainFood(MainFood mainFoodUpdate);

        List<MainFood> GetFilteredMainFood(Filter filter);
    }
}
