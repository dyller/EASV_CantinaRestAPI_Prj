using CantinaApp.Core.DomainServices;
using CantinaApp.Core.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CantinaApp.Core.ApplicationServices.Services
{
    public class FoodIconServices : IFoodIconServices
    {
        readonly IFoodIconRepositories _foodIcnRepo;

        public FoodIconServices(IFoodIconRepositories foodIcnRepo)
        {
            _foodIcnRepo = foodIcnRepo;
        }

        public FoodIcon AddFoodIcon(FoodIcon foodIcon)
        {
            return _foodIcnRepo.CreateFoodIcon(foodIcon);
        }

        public FoodIcon DeleteFoodIcon(int id)
        {
            return _foodIcnRepo.DeleteFoodIcon(id);
        }

        public FoodIcon FindFoodIconById(int id)
        {
            return _foodIcnRepo.ReadMFoodIcon().ToList().FirstOrDefault(spc => spc.Id == id);
        }

        public List<FoodIcon> GetFoodIcon()
        {
            return _foodIcnRepo.ReadMFoodIcon().ToList();
        }

        public FoodIcon UpdateFoodIcon(FoodIcon foodIconUpdate)
        {
            return _foodIcnRepo.UpdateFoodIcon(foodIconUpdate);
        }
    }
}
