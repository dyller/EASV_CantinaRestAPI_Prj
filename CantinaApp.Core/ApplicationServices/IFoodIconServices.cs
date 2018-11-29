using CantinaApp.Core.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CantinaApp.Core.ApplicationServices
{
    public interface IFoodIconServices
    {
        FoodIcon GetFoodIconInstance();

        List<Allergen> GetFoodIcon();

        FoodIcon AddFoodIcon(FoodIcon foodIcon);

        FoodIcon DeleteFoodIcon(int id);

        FoodIcon FindFoodIconId(int id);

        FoodIcon UpdateFoodIcon(FoodIcon foodIconUpdate);
    }
}
