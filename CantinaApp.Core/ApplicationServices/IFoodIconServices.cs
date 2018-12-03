using CantinaApp.Core.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CantinaApp.Core.ApplicationServices
{
    public interface IFoodIconServices
    {
        FoodIcon FindFoodIconById(int id);

        List<FoodIcon> GetFoodIcon();

        FoodIcon AddFoodIcon(FoodIcon foodIcon);

        FoodIcon DeleteFoodIcon(int id);

        FoodIcon UpdateFoodIcon(FoodIcon foodIconUpdate);
    }
}
