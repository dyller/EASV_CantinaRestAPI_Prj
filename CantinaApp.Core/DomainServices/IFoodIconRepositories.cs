using CantinaApp.Core.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CantinaApp.Core.DomainServices
{
    public interface IFoodIconRepositories
    {
        IEnumerable<FoodIcon> ReadMFoodIcon();

        FoodIcon CreateFoodIcon(FoodIcon foodIcon);

        FoodIcon DeleteFoodIcon(int id);

        FoodIcon UpdateFoodIcon(FoodIcon foodIconUpdate);
    }
}
